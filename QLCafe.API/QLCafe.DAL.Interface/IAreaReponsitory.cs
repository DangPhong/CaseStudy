using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.DAL.Interface
{
   public  interface IAreaReponsitory
    {
        IList<Area> AreaGetAll();
        Area AreaGetByID(int Id);
        bool AreaAdd(AreaAdd request);
        bool AreaUpdate(AreaUpdate request);
        bool AreaDelete(int Id);
    }
}
