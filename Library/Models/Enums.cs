using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public enum RegisterationStep
    {
        [Description("First step add user name Email an needed Files")]
        BasicStep = 1,
        [Description("send Activation token to user and Activate Email")]
        ActivateEmail = 2,
        [Description("Add user Data Address Alternative Phone ")]
        CompleteUserData = 3,
        [Description("Change Password ")]
        CompleteAddressData = 4
    }

    public enum FileType
    {
        Cv,
        Certifications,
        NID
    }
  
}