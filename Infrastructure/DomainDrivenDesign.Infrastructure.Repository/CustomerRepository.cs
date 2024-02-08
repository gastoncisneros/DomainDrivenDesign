using DomainDrivenDesign.Domain.Entities;
using DomainDrivenDesign.Infrastructure.Data;
using DomainDrivenDesign.Infrastructure.Interface;

namespace DomainDrivenDesign.Infrastructure.Repository
{
    internal class CustomerRepository(NorthwindDbContext context) : ICustomerRepository
    {
        private readonly NorthwindDbContext _context = context;

        public Customer? Get(string customerId)
        {
            Customer? customer = _context.Customers.FirstOrDefault(x => x.CustomerId.Equals(customerId));

            return customer;
        }

        public IQueryable<Customer> GetAll()
        {
            return _context.Customers.AsQueryable();
        }

        public bool Insert(Customer customer)
        {
            try
            {// Agregar fluent validation
                _context.Customers.Add(customer);
            }
            catch (Exception ex) // Agregar CQRS, Mediator y Mediator Behaviors
            {
                return false;
            }

            return true;
        }

        public bool Update(Customer customer)
        {
            try
            {
                _context.Customers.Update(customer);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool Delete(string customerId)
        {
            try
            {
                Customer? customer = _context.Customers.FirstOrDefault(x => x.CustomerId.Equals(customerId));

                //Throw the customer does not exists
                if (customer == null)
                {
                    return true;
                }

                _context.Customers.Remove(customer);
                _context.SaveChanges(true);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
