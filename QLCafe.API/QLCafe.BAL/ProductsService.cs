using QLCafe.BAL.Interface;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.BAL
{
    public class ProductsService : IProductsService
    {
        IProductsRepository _productsRepository;
        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }
        public bool ProductsAdd(ProductsAdd request)
        {
            return _productsRepository.ProductsAdd(request);
        }

        public bool ProductsDelete(int Id)
        {
            return _productsRepository.ProductsDelete(Id);
        }

        public Products ProductsDetail(int id)
        {
            return _productsRepository.ProductsDetail(id);
        }

        public IList<Products> ProductsGetAll()
        {
            return _productsRepository.ProductsGetAll();
        }

        public Products ProductsGetByID(int Id)
        {
            return _productsRepository.ProductsGetByID(Id);
        }


        public IList<Products> ProductsSearch(string stringSearch)
        {
            return _productsRepository.ProductsSearch(stringSearch);
        }

        public bool ProductsUpdate(ProductsUpdate request)
        {
            return _productsRepository.ProductsUpdate(request);
        }
    }
}
