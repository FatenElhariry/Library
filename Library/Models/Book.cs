using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Library.Models.RESX;
namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Display(Name = "Title", ResourceType = typeof(RESX.Book))]
        public string Title { get; set; }
        [Display(Name = "AuthorName",ResourceType =typeof(RESX.Book))]
        public int AuthorId { get; set; }
        [Display(Name = "Description", ResourceType = typeof(RESX.Book))]
        public string Description { get; set; }
        [Display(Name = "ViewersNum", ResourceType = typeof(RESX.Book))]
        public int ViewersNum { get; set; }

        [MaxLength(100)]
        [Display(Name = "PublishDate", ResourceType = typeof(RESX.Book))]
        public string PublishDate { get; set; }
        [Display(Name = "AvaliableNum", ResourceType = typeof(RESX.Book))]
        public int AvaliableNum { get; set; }
        [Display(Name = "coverPath", ResourceType = typeof(RESX.Book))]
        public string coverPath { get; set; }
        [Display(Name = "bookPath", ResourceType = typeof(RESX.Book))]
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