using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Library.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Display(Name = "AuthorName", ResourceType =typeof(RESX.Book))]
        public string Name { get; set; }
        [Display(Name = "BirthDate", ResourceType = typeof(RESX.Book))]
        [DataType(DataType.Date)]
        public string BirthDate { get; set; } = DateTime.Today.ToString("dd/MM/yyyy");
        [Display(Name = "bio",ResourceType =typeof(RESX.Book))]
        public string bio { get; set; }
        [Display(Name = "photo", ResourceType = typeof(RESX.Book))]
        public byte[] photo { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}