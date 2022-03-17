using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMgntSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IProductOperations _productOperations;

        public CustomerController(IProductOperations productOperations)
        {
            _productOperations = productOperations;
        }
        [HttpGet]
        [Route(nameof(GetProductDetails))]

        public ActionResult GetProductDetails()
        {
            var products = _productOperations.GetProductDetails();

            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);


        }
        [HttpGet]
        [Route("get_Category")]
        public ActionResult GetByCategory(string catg)
        {
            var categ = _productOperations.GetByCategory(catg);
            if (categ != null)
            {
                return Ok(categ);
            }

            return BadRequest();

        }
        [HttpGet]
        [Route("Search_products")]
        public ActionResult SearchCategory(string categ)
        {

            try
            {
                var search = _productOperations.SearchByCategory(categ);
                if (search == null)
                    return NotFound();

                return Ok(search);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route(nameof(AddCustomer))]
        public ActionResult AddCustomer(Customer customer)
        {
            _productOperations.AddCustomer(customer);
            return Ok(customer);
        }


        [HttpDelete]
        [Route(nameof(DeleteCategory))]

        public ActionResult DeleteCategory(ProductService product)
        {
            _productOperations.DeleteProductCategory(product);
            return Ok(product);


        }
        [HttpGet]
        [Route("Search_orderProducts_ToPerson")]
        public ActionResult SearchOrderProducts(int OrderId)
        {
            var searchh = _productOperations.SearchOrderProducts(OrderId);
            return Ok(searchh);
        }
        [HttpGet]
        [Route("Product_Selling_History")]
        public ActionResult GetProductSellingHistory(int ProductId)
        {
            var res = _productOperations.GetProductName(ProductId);
            return Ok(res);
        }
        [HttpPost]
        [Route(nameof(AddProduct))]
        public ActionResult AddProduct(ProductService prod)
        {
            _productOperations.AddProduct(prod);
            return Ok(prod);
        }
    }
}