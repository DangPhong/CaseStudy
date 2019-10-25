using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QLCafe.BAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;

namespace QLCafe.API.Controllers
{
 
    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly IAreaService _areaService;

        public AreaController(IAreaService areaService)
        {
            _areaService = areaService;
        }

        [HttpGet]
        [Route("api/area/gets")]
        public IList<Area> AreaGetAll()
        {
            return _areaService.AreaGetAll();
        }

        [HttpGet]
        [Route("api/area/get/{id}")]
        public Area AreaGetByID(int id)
        {
            return _areaService.AreaGetByID(id);
        }

        [HttpPost]
        [Route("api/area/add")]
        public bool AreaAdd([FromBody] AreaAdd request)
        {
            return _areaService.AreaAdd(request);
        }

        [HttpPut]
        [Route("api/area/update")]
        public bool AreaUpdate([FromBody] AreaUpdate request)
        {
            return _areaService.AreaUpdate(request);
        }

        [HttpDelete]
        [Route("api/area/delete/{id}")]
        public bool Delete(int id)
        {
            return _areaService.AreaDelete(id);
        }
    }
}
