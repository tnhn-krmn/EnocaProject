using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.Entities.Concrete
{
    public class Company : BaseEntity
    {
        public string? CompanyName { get; set; }
        public bool CompanyApprovalStatus { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime FinishHour { get; set; }
    }
}
