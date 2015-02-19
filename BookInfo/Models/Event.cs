using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfo.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int AuthorId { get; set; }

        // Navigation property
        public virtual Author Author { get; set; }
    }
}
