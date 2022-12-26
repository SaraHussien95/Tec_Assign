using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tec_Assign.Models;
using Tec_Assign.Services;

namespace Tec_Assign.Controllers
{
    public class DeviceController : Controller
    {
        DeviceServices deviceServices = new DeviceServices();
        public ActionResult Index()
        {
            return View(deviceServices.listDevices());
        }

        public ActionResult Details(int id)
        {
            Device device = deviceServices.getDevice(id);
            return View(device);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Device device)
        {
            try
            {
                deviceServices.addDevice(device);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            Device device = deviceServices.getDevice(id);
            return View(device);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Device updatedDevice)
        {
            try
            {
                deviceServices.updateDevice(updatedDevice, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
