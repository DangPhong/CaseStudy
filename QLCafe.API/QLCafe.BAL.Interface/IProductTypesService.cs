using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.BAL.Interface
{
    public interface IProductTypesService
    {
        IList<ProductTypes> ProductTypesGetAll();
        ProductTypes ProductTypesGetById(int Id);
        bool ProductTypesAdd(ProductTypesAdd request);
        bool ProductTypesUpdate(ProductTypesUpdate request);
        bool ProductTypesDelete(int Id);
    }
}
