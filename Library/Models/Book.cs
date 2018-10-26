using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }
        public string Description { get; set; }
        public int ViewersNum { get; set; }

        [MaxLength(100)]
        public string PublishDate { get; set; }
        public int AvaliableNum { get; set; }
        public string coverPath { get; set; }
        
        public string bookPath { get; set; }
        public DateTime addedAt { get; set; }
        public string AddBy { get; set; }

        public bool IsActive { get; set; }
        public bool IsOnline { get; set; }

        [ForeignKey("AddBy")]
        public virtual ApplicationUser AddByUser { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }

        public virtual List<BooksCategories> BooksCategories { get; set; }

    }
}