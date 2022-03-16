using DomainLayer.Models;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ProductOperations : IProductOperations
    {
        public ProductContext _productContext;
        public ProductOperations(ProductContext productContext)
        {
            _productContext = productContext;
        }
        

        public void DeleteProductCategory(string categ)
        {

        }

        public ProductService GetByCategory(string catg)
        {
            return _productContext.Find<ProductService>(catg);
        }

        public IList<ProductService> GetProductDetails()
        {
            return _productContext.Set<ProductService>().ToList();
        }

        public void AddCustomer(Customer customer)
        {
            _productContext.Add<Customer>(customer);
            _productContext.SaveChanges();
        }
        public void SearchOrderProducts(int orderId)
        {
            _productContext.Find<Customer>(orderId);

        }

        public void SearchOrderDate(DateTime orderDate)
        {
            _productContext.Find<CustomerOrder>(orderDate);
        }
    }
}
