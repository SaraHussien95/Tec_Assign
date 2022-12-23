using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tec_Assign.Models;

namespace Tec_Assign.DSL
{
    public class Brand_DS
    {
        public DataContext dataContext;
        public Brand_DS(DataContext _dataContext)
        {
            dataContext = _dataContext;
        }
        public List<Brand> listBrand()
        {
            return dataContext.Brands.OrderBy(x => x.Id).ToList();
        }
        public Brand getBrand(int id)
        {
            return dataContext.Brands.Where(x => x.Id == id).FirstOrDefault();
        }
        public void addBrand(Brand brand)
        {
            dataContext.Brands.Add(brand);
            dataContext.SaveChanges();
        }
        public void updateBrand(Brand newBrand, int id)
        {
            Brand updateBrand = dataContext.Brands.Where(x => x.Id == id).FirstOrDefault();
            updateBrand.Name = newBrand.Name;
            updateBrand.categoryId = newBrand.categoryId;

            dataContext.SaveChanges();
        }
        public void deleteAllBrands()
        {
            List<Brand> allBrands = listBrand();
            dataContext.Brands.RemoveRange(allBrands);
            dataContext.SaveChanges();
        }
        public void deleteBrand(int id)
        {
            Brand deleted_brand = getBrand(id);
            dataContext.Brands.Remove(deleted_brand);
            dataContext.SaveChanges();
        }
    }
}
