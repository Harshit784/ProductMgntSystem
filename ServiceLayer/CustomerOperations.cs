using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using RepositoryLayer;

namespace ServiceLayer
{
    class CustomerOperations : ICustomerOperations
    {
        public CustomerContext _customerContext;

        public CustomerOperations(CustomerContext customerContext)
        {
            this._customerContext = customerContext;
        }
        public void AddCustomer(Customer customer)
        {
            _customerContext.Add<Customer>(customer);
            _customerContext.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            _customerContext.Remove<Customer>(customer);
            _customerContext.SaveChanges();
        }

        public IList<Customer> GetCustomerDetails()
        {
            return _customerContext.Set<Customer>().ToList();
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerContext.Update<Customer>(customer);
            _customerContext.SaveChanges();
        }
    }
}
