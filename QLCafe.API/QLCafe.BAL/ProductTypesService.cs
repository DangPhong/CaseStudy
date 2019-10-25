using QLCafe.BAL.Interface;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.BAL
{
    public class ProductTypesService : IProductTypesService
    {
        IProductTypesRepository _productTypesRepository;
        public ProductTypesService(IProductTypesRepository productTypesRepository)
        {
            _productTypesRepository = productTypesRepository;
        }
        public bool ProductTypesAdd(ProductTypesAdd request)
        {
            return _productTypesRepository.ProductTypesAdd(request);
        }

        public bool ProductTypesDelete(int Id)
        {
            return _productTypesRepository.ProductTypesDelete(Id);
        }

        public IList<ProductTypes> ProductTypesGetAll()
        {
            return _productTypesRepository.ProductTypesGetAll();
        }

        public ProductTypes ProductTypesGetById(int Id)
        {
            return _productTypesRepository.ProductTypesGetById(Id);
        }

        public bool ProductTypesUpdate(ProductTypesUpdate request)
        {
            return _productTypesRepository.ProductTypesUpdate(request);
        }
    }
}
