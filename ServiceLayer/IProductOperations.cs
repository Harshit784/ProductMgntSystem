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
        IList<ProductService> GetProductDetails();

        ProductService GetByCategory(string catg);

        ProductService SearchByCategory(string catg);
        void DeleteProductCategory(ProductService product);
        void AddCustomer(Customer customer);
        CustomerOrder SearchOrderProducts(int orderId);
        void SearchOrderDate(DateTime orderDate);

        ProductService GetProductName(int prductId);
        void AddProduct(ProductService prod);

    }

}
