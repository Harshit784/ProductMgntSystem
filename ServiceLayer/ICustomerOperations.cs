using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace ServiceLayer
{
    public interface ICustomerOperations
    {
        IList<Customer> GetCustomerDetails();
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}
