using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.BAL.Interface
{
    public interface IProductsService
    {
        bool ProductsAdd(ProductsAdd request);
        bool ProductsDelete(int Id);
        bool ProductsUpdate(ProductsUpdate request);
        IList<Products> ProductsGetAll();
        Products ProductsGetByID(int Id);
        Products ProductsDetail(int id);
        IList<Products> ProductsSearch(string stringSearch);
    }
}
