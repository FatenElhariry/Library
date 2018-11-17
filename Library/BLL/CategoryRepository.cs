using Library.Models;
using Library.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.BLL
{
    public class CategoryRepository
    {
        private ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Categories> GetAll()
        {
            try
            {
                return _context.Categories.ToList();
            }
            catch (Exception ex)
            {

                return new List<Categories>();
            }
           
        }

        public bool DeleteCategory(int id)
        {
            try
            {
                Categories category = _context.Categories.FirstOrDefault(c => c.Id == id);
                if(category  != null)
                {
                    _context.Categories.Remove(category);
                    _context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public List<JsTree3Node> GetAllNode() {
            try
            {
                var list = new List<JsTree3Node>();
                list.Add(new JsTree3Node() { id = "0", text = "تصنيفات الكتب ", parent = "#" });
                var categories = GetAll();
                list.AddRange(categories.Select(c => new JsTree3Node()
                {
                    id = c.Id.ToString(),
                    parent = (c.parent == null ? "0" : c.parent.ToString()),
                    text = c.Name
                }));
                return list;
            }
            catch (Exception ex)
            {

                return new List<JsTree3Node>();
            }
         
        }
        public bool AddCategory(Categories category)
        {
            try
            {
                if(category.Id == 0 )
                     _context.Categories.Add(new Categories() { Name = category.Name, parent = category.parent});
                else
                {
                    Categories cat_Db = _context.Categories.FirstOrDefault(c => c.Id == category.Id);
                    cat_Db.Name = category.Name;
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }
    }
}