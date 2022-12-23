using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tec_Assign.Models
{
    public class Brand
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int categoryId { set; get; }
        public Category category { set; get; }
    }
}
