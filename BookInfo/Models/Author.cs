using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookInfo.Models
{
    public class Author
    {
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public virtual ICollection<Book> Books { get; set; }

    }
}