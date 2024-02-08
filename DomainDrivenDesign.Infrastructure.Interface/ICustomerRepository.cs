using DomainDrivenDesign.Domain.Entities;

namespace DomainDrivenDesign.Infrastructure.Interface
{
    public interface ICustomerRepository
    {
        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(string customerId);
        Customer? Get(string customerId);
        IQueryable<Customer> GetAll();
    }
}
