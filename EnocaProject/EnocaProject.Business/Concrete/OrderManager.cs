using EnocaProject.Business.Abstract;
using EnocaProject.DataAccess.Abstract;
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
        public void Add(Order order)
        {
            _orderDAL.Add(order);
        }

        public void Delete(int orderId)
        {
            _orderDAL.Delete(new Order { Id = orderId });
        }

        public List<Order> GetAll()
        {
            return _orderDAL.GetList();
        }

        public void Update(Order order)
        {
            _orderDAL.Update(order);
        }
    }
}
