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

        ProductService GetByCategory(string product_catg);

       
        void DeleteProductCategory(string categ);
        void AddCustomer(Customer customer);
        void SearchOrderProducts(int orderId);
        void SearchOrderDate(DateTime orderDate );

    }
       
}
