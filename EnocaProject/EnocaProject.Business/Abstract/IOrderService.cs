﻿using EnocaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        void Add(Order order);
        void Update(Order order);
        void Delete(int orderId);
    }
}
