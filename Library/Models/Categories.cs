using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? parent { get; set; }
        [ForeignKey("parent")]
        public virtual Categories ParentCategory { get; set; }

        public virtual List<BooksCategories> BooksCategories { get; set; }
    }
}