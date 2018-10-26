using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;
using Microsoft.AspNet.Identity.Owin;
using System.Globalization;

namespace Library.Controllers
{
    public class BaseController : Controller
    {
        protected ApplicationDbContext _context;
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
             set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
             set
            {
                _userManager = value;
            }
        }

        public BaseController()
        {
            _context = new ApplicationDbContext();
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("ar-EG");
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("ar-EG");
        }
    

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_userManager != null)
                {
                    _userManager.Dispose();
                    _userManager = null;
                }

                if (_signInManager != null)
                {
                    _signInManager.Dispose();
                    _signInManager = null;
                }
            }

            base.Dispose(disposing);
        }
    }
}