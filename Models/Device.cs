using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tec_Assign.Models
{
    public class Device
    {
        public int Id { set; get; }
        public string Type { set; get; }
        public int categoryId { set; get; }
        public Category category { set; get; }
        public List<Product> products { set; get; }
    }
}
