using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tec_Assign.DSL;
using Tec_Assign.Models;

namespace Tec_Assign.Services
{
    public class ProductServices
    {
        public Product_DS product_DS;
        public ProductServices(DataContext dataContext)
        {
            product_DS = new Product_DS(dataContext);
        }
        public List<Product> listProducts()
        {
            try
            {
                List<Product> products = product_DS.listProduct();
                return products;
            }
            catch
            {
                return null;

            }
        }
        public Product getProduct(int id)
        {
            try
            {
                Product product = product_DS.getProduct(id);
                return product;
            }
            catch
            {
                return null;
            }
        }
        public void addProduct(Product product)
        {
            try
            {
                if (product != null)
                {
                    product_DS.addProduct(product);
                }
            }
            catch { }
        }
        public void updateProduct(Product newProduct, int id)
        {
            try
            {
                if (newProduct != null)
                {
                    product_DS.updateProduct(newProduct, id);
                }
            }
            catch { }
        }
        public void deleteProduct(int id)
        {
            try
            {
                product_DS.deleteProduct(id);
            }
            catch { }
        }
        public void deleteAllProduct()
        {
            try
            {
                product_DS.deleteAllProduct();
            }
            catch { }
        }
    }
}
