using BookInfo.DAL;
using BookInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookInfo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MyThing = "Programming!";
            ViewBag.MyFavoriteNumber = 42;
            ViewBag.ADouble = 42.24;
            return View();
        }

        public ActionResult List()
        {
            BookInfoContext db = new BookInfoContext();
            var books = from b in db.Books
                         select b;
            return View(books);
        }
        public ActionResult ListMore()
        {
            BookInfoContext db = new BookInfoContext();
            Book aBook = (from b in db.Books
                        select b).FirstOrDefault<Book>();

            Author anAuthor = (from a in db.Authors
                               where a.ID == aBook.AuthorId
                               select a).FirstOrDefault<Author>();

            BookViewModel bookVM = new BookViewModel()
            {
                Title = aBook.Title,
                Author = new AuthorViewModel() {
                    Name=anAuthor.Name}
            };
            
           return View(bookVM);
        }

    }
}