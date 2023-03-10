using EnocaProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.Entities.Concrete
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
