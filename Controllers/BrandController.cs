using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tec_Assign.Models;
using Tec_Assign.Services;

namespace Tec_Assign.Controllers
{
    public class BrandController : Controller
    {
        BrandServices brandServices = new BrandServices();
        public ActionResult Index()
        {
            return View(brandServices.listBrands());
        }

        public ActionResult Details(int id)
        {
            Brand brand = brandServices.getBrand(id);
            return View(brand);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Brand brand)
        {
            try
            {
                brandServices.addBrand(brand);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            Brand brand = brandServices.getBrand(id);
            return View(brand);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Brand updatedBrand)
        {
            try
            {
                brandServices.updateBrand(updatedBrand, id);
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
                brandServices.deleteBrand(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
