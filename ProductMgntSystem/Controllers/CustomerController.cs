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
        private readonly ProductOperations _productOperations;

        public CustomerController(ProductOperations productOperations)
        {
            _productOperations = productOperations;
        }
        [HttpGet(nameof(GetProductDetails))]

        public IActionResult GetProductDetails()
        {
            var products = _productOperations.GetProductDetails();
            try
            {
                if (products == null)
                {
                    return NotFound();
                }
                return Ok(products);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
