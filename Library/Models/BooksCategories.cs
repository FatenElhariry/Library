using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class BooksCategories
    {
        [Key]
        [Column(Order =1)]
        public int BookId { get; set; }
        [Column(Order = 2)]
        public int CategoryId { get; set; }
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
        [ForeignKey("CategoryId ")]
        public virtual Categories Category { get; set; }
    }
}