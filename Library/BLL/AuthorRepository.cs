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

        public bool UpdateAuthor(Author author,HttpPostedFileBase photo)
        {
            try
            {
                var authorInDb = _context.Authors.FirstOrDefault(c => c.Id == author.Id);
                author.photo = Helper.ConvertToByte(photo);
                _context.Entry<Author>(authorInDb).CurrentValues.SetValues(author);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public  void AddNewAuthor(Author author,HttpPostedFileBase photo)
        {
            _context.Authors.Add(new Author() {
                Name = author.Name,
                bio = author.bio,
                BirthDate = author.BirthDate,
                photo = Helper.ConvertToByte(photo)
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

        public bool DeleteAuthor(int id)
        {
            try
            {
                var author = _context.Authors.FirstOrDefault(c => c.Id == id);
                if (author != null)
                {
                    _context.Authors.Remove(author);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                return false;
            }
          
            return true;
        }
    }
}