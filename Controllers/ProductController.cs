using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tec_Assign.Models;
using Tec_Assign.Services;

namespace Tec_Assign.Controllers
{
    public class ProductController : Controller
    {
        ProductServices productServices ;
        public ProductController(DataContext _dataContext)
        {
            productServices = new ProductServices(_dataContext);
        }
        public ActionResult Index()
        {
            return View(productServices.listProducts());
        }

        public ActionResult Details(int id)
        {
            Product pro = productServices.getProduct(id);
            return View(pro);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                productServices.addProduct(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            Product product = productServices.getProduct(id);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product updatedPro)
        {
            try
            {
                productServices.updateProduct(updatedPro, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            try
            {
                productServices.deleteProduct(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
