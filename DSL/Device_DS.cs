using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tec_Assign.Models;

namespace Tec_Assign.DSL
{
    public class Device_DS
    {
        public DataContext dataContext;
        public Device_DS(DataContext _dataContext)
        {
            dataContext = _dataContext;
        }
        public List<Device> listDevices()
        {
            return dataContext.Devices.Include(x => x.category).OrderBy(x => x.Id).ToList();
        }
        public Device getDevice(int id)
        {
            return dataContext.Devices.Include(x => x.category).Where(x => x.Id == id).FirstOrDefault();
        }
        public void addDevice(Device device)
        {
            dataContext.Devices.Add(device);
            dataContext.SaveChanges();
        }
        public void updateDevice(Device newDevice, int id)
        {
            Device updateDevice = dataContext.Devices.Include(x => x.category).Where(x => x.Id == id).FirstOrDefault();
            updateDevice.Type = newDevice.Type;
            updateDevice.categoryId = newDevice.categoryId;

            dataContext.SaveChanges();
        }
        public void deleteAllDevices()
        {
            List<Device> allDevices = listDevices();
            dataContext.Devices.RemoveRange(allDevices);
            dataContext.SaveChanges();
        }
        public void deleteDevice(int id)
        {
            Device deleted_devices = getDevice(id);
            dataContext.Devices.Remove(deleted_devices);
            dataContext.SaveChanges();
        }
    }
}
