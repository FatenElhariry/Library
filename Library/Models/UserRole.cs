using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{

    public class UserRole: IdentityRole
    {
        public UserRole(string RoleName):base(RoleName)
        {

        }

        public UserRole()
        {

        }
        public bool? ConfirmedEmail { get; set; } = true;
        public string NameAr { get; set; }
        public string  DescriptionAr { get; set; }
    }
}