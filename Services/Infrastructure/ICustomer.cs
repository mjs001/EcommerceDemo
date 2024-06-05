using ecommerceWithAngular.Models;

namespace ecommerceWithAngular.Services.Infrastructure
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(int id);
        void Insert(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
        int Count();
        void Save();
    }
}
