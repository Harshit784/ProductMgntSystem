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


        public async Task DeleteProductCategory(ProductService product)
        {
            
            _productContext.Remove<ProductService>(product);
           await _productContext.SaveChangesAsync();

        }

        //public ProductService GetByCategory(string catg)
        //{
        //    return _productContext.Find<ProductService>(catg);
        //}

        public async Task<IList<ProductService>> GetProductDetails()
        {
            await Task.Delay(1000);
            return  _productContext.Set<ProductService>().ToList();
        }

        public async Task AddCustomer(Customer customer)
        {
            _productContext.Add<Customer>(customer);
            
           await _productContext.SaveChangesAsync();
        }
        public async Task<CustomerOrder> SearchOrderProducts(int orderId)
        {

            return await _productContext.FindAsync<CustomerOrder>(orderId);

        }
        public async Task<ProductService> GetProductName(int productId)
        {
            return await _productContext.FindAsync<ProductService>(productId);
        }
        public async Task AddProduct(ProductService prod)
        {

            _productContext.Add<ProductService>(prod);
           await _productContext.SaveChangesAsync();
        }

        
    }
}
