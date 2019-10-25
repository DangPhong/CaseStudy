using System;
using System.Collections.Generic;
using System.Text;
using QLCafe.Domain.Request;
using QLCafe.Domain.Response;

namespace QLCafe.BAL.Interface
{
    public interface IUnitService
    {
        bool UnitAdd(UnitAdd request);
        bool UnitUpdate(UnitUpdate request);
        bool UnitDelete(int id);
        IList<Unit> UnitGetAll();
        Unit UnitGetById(int id);
    }
}
