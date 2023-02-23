using EnocaProject.Core.DataAccess.Concrete;
using EnocaProject.DataAccess.Abstract;
using EnocaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDAL : EfRepository<Order, Context>, IOrderDAL
    {
        public Company IdWithDataGet(int id)
        {
            using(var context = new Context())
            {
                return context.Companies.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
