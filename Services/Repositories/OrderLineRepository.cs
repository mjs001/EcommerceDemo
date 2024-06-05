using ecommerceWithAngular.Data;
using ecommerceWithAngular.Models;
using ecommerceWithAngular.Services.Infrastructure;

namespace ecommerceWithAngular.Services.Repositories
{
    public class OrderLineRepository : IOrderLine
    {
        private ApplicationDbContext _context;
        public OrderLineRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.OrderLines.Count();
        }

        public OrderLine GetOrderLine(int id)
        {
            var orderLine = _context.OrderLines.FirstOrDefault(c => c.Id == id);
            if (orderLine != null)
            {
                return orderLine;
            }
            return null;
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            return _context.OrderLines;
        }

        public void Insert(OrderLine orderline)
        {
            _context.OrderLines.Add(orderline);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(OrderLine orderline)
        {
            _context.OrderLines.Update(orderline);
        }
    }
}
