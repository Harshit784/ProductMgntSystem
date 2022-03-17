using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(IProductOperations productOperations, ILogger<CustomerController> logger)
        {

            _logger = logger;
            _logger.LogInformation("Customer Called");
            _productOperations = productOperations;
        }
        [HttpGet]
        [Route(nameof(GetProductDetails))]

        public ActionResult GetProductDetails()
        {
            var products = _productOperations.GetProductDetails();

            try
            {
                _logger.LogInformation("Product -GetProductDetails endpoint called");

                if (products == null)
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception Occured -Exception detail", ex.InnerException);
            }
            return Ok(products);


        }
       /* [HttpGet]
        [Route("GetCategory")]
        public ActionResult GetByCategory(string catg)
        {
            var categ = _productOperations.GetByCategory(catg);
            if (categ != null)
            {
                return Ok(categ);
            }
            return BadRequest();

        }*/   



    [HttpPost]
    [Route(nameof(AddCustomer))]
    public ActionResult AddCustomer(Customer customer)
    {
            try
            {
                _logger.LogInformation("Customer -AddCustomer endpoint called");
                if (customer != null)
                {
                    _productOperations.AddCustomer(customer);
                    return Ok(customer);
                }
            }
            catch(Exception ex)
            {
                _logger.LogError("Exception Occured -Exception detail", ex.InnerException);

            }
            return BadRequest();
        }


    [HttpDelete]
    [Route("DeleteProductInCategory")]

    public ActionResult DeleteCategory(ProductService product)
    {
            try
            {
                _logger.LogInformation("Product -DeleteProduct endpoint called");
                if (product != null)
                {
                    _productOperations.DeleteProductCategory(product);
                    return Ok(product);
                }
            }
            catch(Exception ex)
            {
                _logger.LogError("Exception Occured -Exception detail", ex.InnerException);

            }
            return NotFound();

        }
    [HttpGet]
    [Route("OrderDetails")]
    public ActionResult SearchOrderProducts(int OrderId)
    {
            try
            {
                var searchh = _productOperations.SearchOrderProducts(OrderId);

                if (searchh != null)
                {
                    return Ok(searchh);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception Occured -Exception detail", ex.InnerException);

            }
            return BadRequest();
    }
    [HttpGet]
    [Route("ProductDetailsById")]
    public ActionResult GetProductSellingHistory(int ProductId)
    {
            try
            {
                _logger.LogInformation("Product -DetailsById endpoint called");
                if (ProductId != 0)
                {
                    var res = _productOperations.GetProductName(ProductId);
                    return Ok(res);
                }
            }
            catch(Exception ex)
            {
                _logger.LogError("Exception Occured -Exception detail", ex.InnerException);

            }
            return NotFound();
        }
    [HttpPost]
    [Route(nameof(AddProduct))]
    public ActionResult AddProduct(ProductService prod)
    {
            try
            {
                _logger.LogInformation("Product -AddProduct endpoint called");
                if (prod != null)
                {
                    _productOperations.AddProduct(prod);
                    return Ok(prod);
                }

            }
            catch(Exception ex)
            {
                _logger.LogError("Exception Occured -Exception detail", ex.InnerException);

            }
            return BadRequest();
        }

    }
}