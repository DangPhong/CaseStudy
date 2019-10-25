using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLCafe.BAL.Interface;
using QLCafe.Domain.Response;
using QLCafe.Domain.Request;

namespace QLCafe.API.Controllers
{

    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly IUnitService _unitService;
        public UnitController(IUnitService unitService)
        {
            _unitService = unitService;
        }
        // GET api/unit
        [HttpGet]
        [Route("api/unit/gets")]
        public IList<Unit> Unit_GetAll()
        {
            return _unitService.UnitGetAll();
        }
        // GET api/unit/5
        [HttpGet]
        [Route("api/unit/get/{id}")]
        public Unit Unit_GetById(int id)
        {
            return _unitService.UnitGetById(id);
        }

        // POST api/unit
        [HttpPost]
        [Route("api/unit/create")]
        public bool Unit_Add([FromBody] UnitAdd request)
        {
            return _unitService.UnitAdd(request);
        }

        // PUT api/unit/5
        [HttpPut]
        [Route("api/unit/update")]
        public bool Unit_Update([FromBody]UnitUpdate request)
        {
            return _unitService.UnitUpdate(request);
        }

        // DELETE api/unit/5
        [HttpGet]
        [Route("api/unit/delete/{id}")]
        public bool Unit_Delete(int id)
        {
            return _unitService.UnitDelete(id);
        }
    }
}