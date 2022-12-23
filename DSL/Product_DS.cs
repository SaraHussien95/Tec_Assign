using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tec_Assign.Models;

namespace Tec_Assign.DSL
{
    public class Product_DS
    {
        public DataContext dataContext;
        public Product_DS(DataContext _dataContext)
        {
            dataContext = _dataContext;
        }
        public List<Product> listProduct()
        {
            return dataContext.Products.OrderBy(x => x.Id).ToList();
        }
        public Product getProduct(int id)
        {
            return dataContext.Products.Where(x => x.Id == id).FirstOrDefault();
        }
        public void addProduct(Product product)
        {
            dataContext.Products.Add(product);
            dataContext.SaveChanges();
        }
        public void updateProduct(Product newProduct, int id)
        {
            Product updateProduct = dataContext.Products.Where(x => x.Id == id).FirstOrDefault();
            updateProduct.Code = newProduct.Code;
            updateProduct.Price = newProduct.Price;
            updateProduct.Size = newProduct.Size;
            updateProduct.deviceId = newProduct.deviceId;
            updateProduct.brandId = newProduct.brandId;

            dataContext.SaveChanges();
        }
        public void deleteAllProduct()
        {
            List<Product> allProducts = listProduct();
            dataContext.Products.RemoveRange(allProducts);
            dataContext.SaveChanges();
        }
        public void deleteProduct(int id)
        {
            Product deleted_product = getProduct(id);
            dataContext.Products.Remove(deleted_product);
            dataContext.SaveChanges();
        }
    }
}
