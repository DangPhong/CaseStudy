using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.DAL.Interface
{
    public interface IProductTypesRepository
    {
        IList<ProductTypes> ProductTypesGetAll();
        ProductTypes ProductTypesGetById(int Id);
        bool ProductTypesAdd(ProductTypesAdd request);
        bool ProductTypesUpdate(ProductTypesUpdate request);
        bool ProductTypesDelete(int Id);
    }
}
