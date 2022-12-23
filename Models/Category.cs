using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tec_Assign.Models
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public List<Device> devices { set; get; }
        public List<Brand> brands { set; get; }
    }
}
