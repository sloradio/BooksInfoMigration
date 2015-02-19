using BookInfo.DAL;
using BookInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookInfo.Controllers
{
    public class EditInfoController : Controller
    {
        // GET: EditInfo
        public ActionResult Index()
        {
            BookInfoContext db = new BookInfoContext();
            //var authors = db.Authors.Include("Books");
            var authors = from a in db.Authors.Include("Books")
                          where a.Name == "Tolstoy"
                          select a;

            // Just copying from the entity models to the view model
            var vmList = new List<BookViewModel>();
            foreach(Author a in authors)
            {
   
                foreach(Book b in a.Books)
                {
                    vmList.Add(new BookViewModel() {
                                Title=b.Title, Year=b.Year,
                                Author = new AuthorViewModel() {Name=a.Name }
                                });
                }
            }

            return View(vmList);
        }

        // GET: EditInfo
        // This conroller illustrates passing an author collection which includes a book collection for each author
        public ActionResult List()
        {
            BookInfoContext db = new BookInfoContext();
            //var authors = db.Authors.Include("Books");
            var authors = from a in db.Authors.Include("Books")
                          where a.Name == "Tolstoy"
                          select a;



            return View(authors);
        }
  


    }
}