using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tec_Assign.Models;
using Tec_Assign.DSL;

namespace Tec_Assign.Services
{
    public class CategoryServices
    {
        public Category_DS category_DS;
        public DataContext dataContext;
        public CategoryServices()
        {
            category_DS = new Category_DS( dataContext );
        }
        public List<Category> listCategories()
        {
            try
            {
                List<Category> categories = category_DS.listCategory();
                return categories;
            }
            catch {
                return null;

            }
        }
        public Category getCategory(int id)
        {
            try
            {
                Category category = category_DS.getCategory(id);
                return category;
            }
            catch
            {
                return null;
            }
        }
        public void addCategory(Category category)
        {
            try
            {
                if(category!=null)
                {
                    category_DS.addCategory(category);
                }
            }
            catch { }
        }
        public void updateCategory(Category newCategory, int id)
        {
            try
            {
                if (newCategory != null)
                {
                    category_DS.updateCategory(newCategory, id);
                }
            }
            catch { }
        }
        public void deleteCategory(int id)
        {
            try
            {
                category_DS.deleteCategory(id);
            }
            catch { }
        }
        public void deleteAllCategory()
        {
            try
            {
                category_DS.deleteAllCategories();
            }
            catch { }
        }
    }
}
