using Library.BLL;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class BooksController : BaseController
    { 
        
        private readonly BookRepository _bookRepository;
        public BooksController()
        {
            _context = new ApplicationDbContext();
            _bookRepository = new BookRepository(_context);
        }

        // GET: Books
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddBook() {

            return View();
        }
        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            return View();
        }
    }
}