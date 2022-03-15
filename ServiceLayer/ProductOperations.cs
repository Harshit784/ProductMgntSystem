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
        public void AddProduct(ProductService product)
        {
            _productContext.Add<ProductService>(product);
            _productContext.SaveChanges();
        }

        public void DeleteProduct(ProductService product)
        {

        }

        public ProductService GetByCategory(string product_catg)
        {
            return _productContext.Find<ProductService>(product_catg);
        }

        public IList<ProductService> GetProductDetails()
        {
            return _productContext.Set<ProductService>().ToList();
        }

        public void UpdateProduct(ProductService product)
        {
            _productContext.Update<ProductService>(product);
            _productContext.SaveChanges();
        }
    }
}
