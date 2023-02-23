using EnocaProject.Business.Abstract;
using EnocaProject.Business.Constants;
using EnocaProject.Core.Utilities.Results;
using EnocaProject.DataAccess.Abstract;
using EnocaProject.DataAccess.Concrete.EntityFramework;
using EnocaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDAL _orderDAL;
        public OrderManager(IOrderDAL orderDAL)
        {
            _orderDAL = orderDAL;
        }
        public IResult Add(Order order)
        {
            var data = _orderDAL.IdWithDataGet(order.CompanyId);
            var nowHour = DateTime.Parse(DateTime.Now.ToString("H:mm"));

            if ((data.CompanyApprovalStatus == true))
            {
            if(order.OrderDate > data.StartHour && order.OrderDate < data.FinishHour)
            {
                _orderDAL.Add(order);
                return new SuccessResult(Messages.OrderAdded);
            }
                return new ErrorResult(Messages.OutOfOrderTime);
            }
            return new ErrorResult(Messages.CompanyNotApproved);
        }

        public IResult Delete(Order order)
        {
            _orderDAL.Delete(order);
            return new SuccessResult(Messages.OrderDeleted);
        }

        public IDataResult<List<Order>> GetList()
        {
            return new SuccessDataResult<List<Order>>(_orderDAL.GetList().ToList());
        }

        public IResult Update(Order order)
        {
            _orderDAL.Update(order);
            return new SuccessResult(Messages.OrderUpdated);
        }
    }
}
