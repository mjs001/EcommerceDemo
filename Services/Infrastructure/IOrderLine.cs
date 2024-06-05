using ecommerceWithAngular.Models;

namespace ecommerceWithAngular.Services.Infrastructure
{
    public interface IOrderLine
    {
        IEnumerable<OrderLine> GetOrderLines();
        OrderLine GetOrderLine(int id);
        void Insert(OrderLine orderline);
        void Update(OrderLine orderline);
        int Count();
        void Save();
    }
}
