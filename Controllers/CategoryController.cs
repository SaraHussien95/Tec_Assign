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
    public class CategoryController : Controller
    {
        CategoryServices categoryServices = new CategoryServices();
        public ActionResult Index()
        {
            return View(categoryServices.listCategories());
        }

        public ActionResult Details(int id)
        {
            Category cat = categoryServices.getCategory(id);
            return View(cat);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {
                categoryServices.addCategory(category);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            Category category = categoryServices.getCategory(id);
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category updatedCat)
        {
            try
            {
                categoryServices.updateCategory(updatedCat, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
