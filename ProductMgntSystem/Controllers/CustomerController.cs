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
        [Route("action")]

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
        public ActionResult GetByCategory(string catg)
        {
            var categ=_productOperations.GetByCategory(catg);
            if(categ!=null)
            {
                return Ok(categ);
            }

            return BadRequest();

        }
        [HttpPut]
        [Route("AddCustomer")]
        public ActionResult AddCustomer(Customer cust)
        {
            _productOperations.AddCustomer(cust);
            return Ok("Customer Added");
        }
        [HttpDelete]
        [Route("Delete_Categ")]
        public ActionResult DeleteProductCategory(string categ)
        {
            ProductService ps = new GetByCategory(categ);
            if (categ != null)
            {
                _productOperations.Remove<ProductService>(categ);
                return Ok("Category Deleted");
            }
            return NotFound();
        }
    }
}
