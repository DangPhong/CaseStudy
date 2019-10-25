using System;
using System.Collections.Generic;
using System.Text;
using QLCafe.BAL.Interface;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Request;
using QLCafe.Domain.Response;

namespace QLCafe.BAL
{
    public class UnitService: IUnitService
    {
        public readonly IUnitRepository _unitRepository;
        public UnitService(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        public bool UnitAdd(UnitAdd request)
        {
            return _unitRepository.UnitAdd(request);
        }

        public bool UnitDelete(int id)
        {
            return _unitRepository.UnitDelete(id);
        }

        public IList<Unit> UnitGetAll()
        {
            return _unitRepository.UnitGetAll();
        }

        public Unit UnitGetById(int id)
        {
            return _unitRepository.UnitGetById(id);
        }

        public bool UnitUpdate(UnitUpdate request)
        {
            return _unitRepository.UnitUpdate(request);
        }
    }
}
