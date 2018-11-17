using Library.BLL;
using Library.Models;
using Library.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly CategoryRepository _categoryRepository;
        public CategoryController()
        {
            _context = new ApplicationDbContext();
            _categoryRepository = new CategoryRepository(_context);
        }
        // GET: Category
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult GetTreeData()
        {
            //var list = new List<JsTree3Node>();
            //list.Add(new JsTree3Node() { id = "0", text = "تصنيفات الكتب ", parent = "#" });
            //var categories = _categoryRepository.GetAll();
            //list.AddRange(categories.Select(c => new JsTree3Node() {
            //    id = c.Id.ToString(),
            //    parent = (c.parent == null ? "0":c.parent.ToString()),
            //    text = c.Name
            //}));
            var list = _categoryRepository.GetAllNode();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteCategory(int id)
        {
            bool res = _categoryRepository.DeleteCategory(id);

            return Json(res,JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddCategory(Categories category)
        {
            bool res = _categoryRepository.AddCategory(category);
            return Json(res,JsonRequestBehavior.AllowGet);
        }
    }
}