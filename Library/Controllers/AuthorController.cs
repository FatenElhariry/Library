using Library.BLL;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class AuthorController : Controller
    {
        private ApplicationDbContext _context; 
        private AuthorRepository authorRepository;
        public AuthorController()
        {
            _context = new ApplicationDbContext();
            authorRepository = new AuthorRepository(_context);
        }
        // GET: Author
        public ActionResult Index()
        {

            return View(authorRepository.GetAllAuthors().ToList());
        }
        public ActionResult Edit(int? Id)
        {
            if (Id != null)
                ViewBag.Author = authorRepository.GetAuthorById(Id.Value);
            else
                ViewBag.Author = new Author();
            return PartialView("Index",authorRepository.GetAllAuthors().ToList());
        }
        [HttpPost]
        public ActionResult Edit(Author author)
        {
            authorRepository.AddNewAuthor(author);
            return Redirect("index");
        }

    }
}