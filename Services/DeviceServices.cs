using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tec_Assign.DSL;
using Tec_Assign.Models;

namespace Tec_Assign.Services
{
    public class DeviceServices
    {
        public Device_DS device_DS;
        public DataContext dataContext;
        public DeviceServices()
        {
            device_DS = new Device_DS(dataContext);
        }
        public List<Device> listDevices()
        {
            try
            {
                List<Device> devices = device_DS.listDevices();
                return devices;
            }
            catch
            {
                return null;

            }
        }
        public Device getDevice(int id)
        {
            try
            {
                Device device = device_DS.getDevice(id);
                return device;
            }
            catch
            {
                return null;
            }
        }
        public void addDevice(Device device)
        {
            try
            {
                if (device != null)
                {
                    device_DS.addDevice(device);
                }
            }
            catch { }
        }
        public void updateDevice(Device newDevice, int id)
        {
            try
            {
                if (newDevice != null)
                {
                    device_DS.updateDevice(newDevice, id);
                }
            }
            catch { }
        }
    }
}
