using Library.BLL;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class AuthorController : BaseController
    {
        private ApplicationDbContext _context; 
        private AuthorRepository authorRepository;
        public AuthorController()
        {
            _context = new ApplicationDbContext();
            authorRepository = new AuthorRepository(_context);
        }
        // GET: Author
        public ActionResult Index(int? Id)
        {
            if (Id != null)
               ViewBag.Author = authorRepository.GetAuthorById(Id.Value);

            return View(authorRepository.GetAllAuthors().ToList());
        }
        public ActionResult Edit(int? Id)
        {
            Models.Author author = new Author();
            if (Id != null)
                author = authorRepository.GetAuthorById(Id.Value);
            
            return PartialView("Partials/Edit",author);
        }
        [HttpPost]
        public ActionResult Edit([Bind(Exclude = "photo")]Author author,HttpPostedFileBase photo)
        {
                
            if (author.Id != 0)
                authorRepository.UpdateAuthor(author,photo);
            else
                authorRepository.AddNewAuthor(author,photo);
            return Redirect("index");
        }

        public ActionResult DeleteAuthor(int id)
        {
            bool IsRemoved = authorRepository.DeleteAuthor(id);
            return Json(IsRemoved, JsonRequestBehavior.AllowGet);
        }
    }
}