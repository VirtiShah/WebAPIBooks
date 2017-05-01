using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIServiceBooks.Models
{
    public class Books
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookAuthorName { get; set; }
        public int Price { get; set; }
 
    }
}