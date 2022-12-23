using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tec_Assign.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> dataOptions):base(dataOptions)
        {

        }
        public virtual DbSet<Brand> Brands { set; get; }
        public virtual DbSet<Category> Categories { set; get; }
        public virtual DbSet<Device> Devices { set; get; }
        public virtual DbSet<Product> Products { set; get; }
    }
}
