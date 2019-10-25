using QLCafe.BAL.Interface;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.BAL
{
   public class AreaService : IAreaService
    {
        private IAreaReponsitory _areaResponsitory;
        public AreaService(IAreaReponsitory areaResponsitory)
        {
            _areaResponsitory = areaResponsitory;
        }
        public bool AreaAdd(AreaAdd request)
        {
            return _areaResponsitory.AreaAdd(request);
        }

        public bool AreaDelete(int Id)
        {
            return _areaResponsitory.AreaDelete(Id);
        }

        public IList<Area> AreaGetAll()
        {
            return _areaResponsitory.AreaGetAll();
        }

        public Area AreaGetByID(int Id)
        {
            return _areaResponsitory.AreaGetByID(Id);
        }

        public bool AreaUpdate(AreaUpdate request)
        {
            return _areaResponsitory.AreaUpdate(request);
        }
    }
}
