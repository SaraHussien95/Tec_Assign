using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tec_Assign.Models;

namespace Tec_Assign.DSL
{
    public class Category_DS
    {
        public DataContext dataContext;
        public Category_DS(DataContext _dataContext)
        {
            dataContext = _dataContext;
        }
        public List<Category> listCategory()
        {
            return dataContext.Categories.OrderBy(x => x.Id).ToList();
        }
        public Category getCategory(int id)
        {
            return dataContext.Categories.Where(x => x.Id == id).FirstOrDefault();
        }
        public void addCategory(Category category)
        {
            dataContext.Categories.Add(category);
            dataContext.SaveChanges();
        }
        public void updateCategory(Category newCategory, int id)
        {
            Category updateCategory = dataContext.Categories.Where(x => x.Id == id).FirstOrDefault();
            updateCategory.Name = newCategory.Name;

            dataContext.SaveChanges();
        }
        public void deleteAllCategories()
        {
            List<Category> allCategories = listCategory();
            dataContext.Categories.RemoveRange(allCategories);
            dataContext.SaveChanges();
        }
        public void deleteCategory(int id)
        {
            Category deleted_category = getCategory(id);
            dataContext.Categories.Remove(deleted_category);
            dataContext.SaveChanges();
        }
    }
}
