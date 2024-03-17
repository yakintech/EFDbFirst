using EFDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbFirst.Services
{
    public class CategoryService
    {
        public void AddCategory(Category category)
        {
            NorthwindContext db = new NorthwindContext();
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {
            NorthwindContext db = new NorthwindContext();
            List<Category> categories = db.Categories.OrderBy(q => q.CategoryName).ToList();
            return categories;
        }


        
        //disaridan id alan ve o id'ye ait kategoriyi silen metot
        public void DeleteCategory(int id)
        {
            NorthwindContext db = new NorthwindContext();
            Category category = db.Categories.FirstOrDefault(x => x.CategoryId == id);

            if(category != null)
            {
                db.Categories.Remove(category);
                db.SaveChanges();
            }   
        }


        //disaridan id alan ve o id'ye ait kategoriyi donduren metot
        public Category GetCategoryById(int id)
        {
            NorthwindContext db = new NorthwindContext();
            Category category = db.Categories.FirstOrDefault(x => x.CategoryId == id);
            return category;
        }
    }
}
