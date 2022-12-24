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
        // GET: BrandController
        public ActionResult Index()
        {
            return View(brandServices.listBrands());
        }

        // GET: BrandController/Details/5
        public ActionResult Details(int id)
        {
            Brand brand = brandServices.getBrand(id);
            return View(brand);
        }

        // GET: BrandController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BrandController/Create
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

        // GET: BrandController/Edit/5
        public ActionResult Edit(int id)
        {
            Brand brand = brandServices.getBrand(id);
            return View(brand);
        }

        // POST: BrandController/Edit/5
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
    }
}
