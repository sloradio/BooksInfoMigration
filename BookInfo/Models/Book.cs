using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookInfo.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public DateTime Year { get; set; }

    }
}