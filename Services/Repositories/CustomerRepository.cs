using ecommerceWithAngular.Data;
using ecommerceWithAngular.Models;
using ecommerceWithAngular.Services.Infrastructure;

namespace ecommerceWithAngular.Services.Repositories
{
   /* public class CustomerRepository : ICustomer
    {
        private ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.Customers.Count();
        }

        public void Delete(int id, Customer c)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                return customer;
            }
            return null;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers;
        }

        public void Insert(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
        }
    }*/
}
