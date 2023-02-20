using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public int CompanyId { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }


    }
}
