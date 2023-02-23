using EnocaProject.Core.DataAccess.Abstract;
using EnocaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.DataAccess.Abstract
{
    public interface IOrderDAL : IEntityRepository<Order>
    {
        Company IdWithDataGet(int id);
    }
}
