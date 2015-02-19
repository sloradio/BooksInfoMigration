using BookInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookInfo.DAL
{
     public class BookInfoInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookInfoContext>
     //public class BookInfoInitializer : System.Data.Entity.DropCreateDatabaseAlways<BookInfoContext>
     {
        protected override void Seed(BookInfoContext context)
        {
            // Initialize authors
            var authors = new List<Author>
            {
                new Author{Name="Leo Tolstoy", Birthday=DateTime.Parse("1878-09-09")},
                new Author{Name="Mary Norton", Birthday=DateTime.Parse("1903-12-10")},
                new Author{Name="J. D. Sallinger", Birthday=DateTime.Parse("1919-01-01")}
            };

            authors.ForEach(b => context.Authors.Add(b));
            context.SaveChanges(); 
            
            var books = new List<Book>
            {
                new Book{Title="Anna Kerinena", Year=DateTime.Parse("1878-01-01"), AuthorId=1},
                new Book{Title="War and Peace", Year=DateTime.Parse("1869-01-01"), AuthorId=1},
                new Book{Title="The Borrowers", Year=DateTime.Parse("1952-01-01"), AuthorId=2},
                new Book{Title="Catcher in the Rye", Year=DateTime.Parse("1951-01-01"), AuthorId=3}
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            var events = new List<Event>
            {
                new Event{Description="Book signing", Date=DateTime.Parse("2015-03-01"), AuthorId=1},
                new Event{Description="Book signing", Date=DateTime.Parse("2015-04-01"), AuthorId=2},
                new Event{Description="Lunch with an author", Date=DateTime.Parse("2015-05-01"), AuthorId=3} 
 /*             new Event{Description="Book signing", Date=DateTime.Parse("2015-03-01")},
                new Event{Description="Book signing", Date=DateTime.Parse("2015-04-01")},
                new Event{Description="Lunch with an author", Date=DateTime.Parse("2015-04-01")} */
            };

            events.ForEach(e => context.Events.Add(e));
            context.SaveChanges();

        }
    }
}