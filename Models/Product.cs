using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tec_Assign.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string Code { set; get; }
        public float Price { set; get; }
        public float Size { set; get; }
        public int brandId { set; get; }
        public int deviceId { set; get; }
        public Brand brand { set; get; }
        public Device device { set; get; }
    }
}
