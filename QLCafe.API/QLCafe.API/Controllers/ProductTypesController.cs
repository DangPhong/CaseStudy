using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QLCafe.BAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;

namespace QLCafe.API.Controllers
{

    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        IProductTypesService _productTypesService;
        public ProductTypesController(IProductTypesService productTypesService)
        {
            _productTypesService = productTypesService;
        }

        [HttpGet]
        [Route("api/ProductTypes/gets")]
        public IList<ProductTypes> ProductTypesGetAll()
        {
            return _productTypesService.ProductTypesGetAll();
        }


        [HttpGet]
        [Route("api/ProductTypes/get/{id}")]
        public ProductTypes ProductTypesGetById(int Id)
        {
            return _productTypesService.ProductTypesGetById(Id);
        }


        [HttpPost]
        [Route("api/ProductTypes/add")]
        public bool ProductTypesAdd([FromBody] ProductTypesAdd request)
        {
            return _productTypesService.ProductTypesAdd(request);
        }


        [HttpPut]
        [Route("api/ProductTypes/update")]
        public bool ProductTypesUpdate([FromBody] ProductTypesUpdate request)
        {
            return _productTypesService.ProductTypesUpdate(request);
        }


        [HttpDelete]
        [Route("api/ProductTypes/delete/{id}")]
        public bool ProductTypesDelete(int Id)
        {
            return _productTypesService.ProductTypesDelete(Id);
        }
    }
}
