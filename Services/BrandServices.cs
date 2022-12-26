using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tec_Assign.DSL;
using Tec_Assign.Models;

namespace Tec_Assign.Services
{
    public class BrandServices
    {
        public Brand_DS brand_DS;
        public DataContext dataContext;
        public BrandServices()
        {
            brand_DS = new Brand_DS(dataContext);
        }
        public List<Brand> listBrands()
        {
            try
            {
                List<Brand> brands = brand_DS.listBrand();
                return brands;
            }
            catch
            {
                return null;

            }
        }
        public Brand getBrand(int id)
        {
            try
            {
                Brand brand = brand_DS.getBrand(id);
                return brand;
            }
            catch
            {
                return null;
            }
        }
        public void addBrand(Brand brand)
        {
            try
            {
                if (brand != null)
                {
                    brand_DS.addBrand(brand);
                }
            }
            catch { }
        }
        public void updateBrand(Brand newBrand, int id)
        {
            try
            {
                if (newBrand != null)
                {
                    brand_DS.updateBrand(newBrand, id);
                }
            }
            catch { }
        }
        public void deleteBrand(int id)
        {
            try
            {
                brand_DS.deleteBrand(id);
            }
            catch { }
        }
        public void deleteAllBrand()
        {
            try
            {
                brand_DS.deleteAllBrands();
            }
            catch { }
        }
    }
}
