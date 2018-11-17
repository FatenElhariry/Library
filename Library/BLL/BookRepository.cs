using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.BLL
{
    public class BookRepository
    {
        private readonly  ApplicationDbContext _context ;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}