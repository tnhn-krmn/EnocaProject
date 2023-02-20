using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public string OrdererName { get; set; }
    }
}
