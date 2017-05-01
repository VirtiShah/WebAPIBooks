using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIServiceBooks.Models;

namespace WebAPIServiceBooks.Controllers
{
    public class BooksController : ApiController
    {
        Books[] books = new Books[]
         {
             new Books { BookID = 1, BookName = "BN1", 
                           BookAuthorName= "Author1", Price = 400 },
      new Books { BookID = 1, BookName = "BN2", 
                           BookAuthorName= "Author2", Price = 450 },
new Books { BookID = 1, BookName = "BN3", 
                           BookAuthorName= "Author3", Price = 300 },
new Books { BookID = 1, BookName = "BN4", 
                           BookAuthorName= "Author4", Price = 520 }, 
    };
        public IEnumerable<Books> GetBooks()
        {
            return books;
        }

    }
}
