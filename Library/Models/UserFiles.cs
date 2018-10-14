using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class UserFiles
    {
        public string sysgeneratedName { get; set; }

        public string Name { get; set; }
        public FileType FileType { get; set; }
        public bool IsDeleted { get; set; }
        [Key]
        [Column(Order =2)]
        public DateTime CreatedAt { get; set; }
        [ForeignKey("User")]
        [Key]
        [Column(Order =1)]
        public string UserId { get; set; }
        
        public virtual ApplicationUser User { get; set; }


    }
}