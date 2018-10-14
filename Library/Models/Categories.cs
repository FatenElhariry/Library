using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<BooksCategories> BooksCategories { get; set; }
    }
}