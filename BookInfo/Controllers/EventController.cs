using BookInfo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookInfo.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult List()
        {
            BookInfoContext db = new BookInfoContext();
            var events = db.Events.Include("Author");

            return View(events);
        }
    }
}