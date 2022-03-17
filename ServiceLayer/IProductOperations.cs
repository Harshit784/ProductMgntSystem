using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IProductOperations
    {
        Task<IList<ProductService>> GetProductDetails();

        //ProductService GetByCategory(string catg);

        Task DeleteProductCategory(ProductService product);
        Task AddCustomer(Customer customer);
        Task<CustomerOrder> SearchOrderProducts(int orderId);

        Task<ProductService> GetProductName(int prductId);
        Task AddProduct(ProductService prod);

    }

}
