using EnocaProject.Core.Utilities.Results;
using EnocaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetList();
        IResult Add(Order order);
        IResult Delete(Order order);
        IResult Update(Order order);
    }
}
