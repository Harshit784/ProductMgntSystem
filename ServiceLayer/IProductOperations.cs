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

        void AddProduct(ProductService product);
        void UpdateProduct(ProductService product);
        void DeleteProduct(ProductService product);
    }
}
