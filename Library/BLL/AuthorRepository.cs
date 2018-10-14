using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.BLL
{
    public class AuthorRepository
    {
        private ApplicationDbContext _context;
        public AuthorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public  void AddNewAuthor(Author author)
        {
            _context.Authors.Add(new Author() {
                Name = author.Name,
                bio = author.bio,
                BirthDate = author.BirthDate
            });
            _context.SaveChanges();
        }

        public IQueryable<Author> GetAllAuthors()
        {
            return _context.Authors;
        }

        public Author GetAuthorById(int Id)
        {
            return _context.Authors.FirstOrDefault(c => c.Id == Id);
        }
    }
}