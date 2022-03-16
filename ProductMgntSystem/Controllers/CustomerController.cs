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
    }
}
