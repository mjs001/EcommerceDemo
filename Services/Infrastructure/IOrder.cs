﻿using ecommerceWithAngular.Models;

namespace ecommerceWithAngular.Services.Infrastructure
{
    public interface IOrder
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(int id);
        void Delete(int id);
        int Count();
        void Save();
    }
}
