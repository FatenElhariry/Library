using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Display(Name ="اسم الكاتب")]
        public string Name { get; set; }
        [Display(Name ="تاريخ الميلاد")]
        public DateTime BirthDate { get; set; } = DateTime.Now;
        [Display(Name ="السيرة الذاتية")]
        public string bio { get; set; }
        [Display(Name ="الصورة الشخصية ")]
        public byte[] photo { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}