using DomainDrivenDesign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
