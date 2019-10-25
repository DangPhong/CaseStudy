using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLCafe.BAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;

namespace QLCafe.API.Controllers
{
    
    [ApiController]
    public class BillsController : ControllerBase
    {
        IBillsService _billsService;
        public BillsController(IBillsService billsService)
        {
            _billsService = billsService;
        }
        [HttpGet]
        [Route("api/Bills/gets")]
        public IList<Bills> BillsGetAll()
        {
            return _billsService.BillGetAll();
        }


        [HttpGet]
        [Route("api/Bills/get/{id}")]
        public Bills BillsGetById(int Id)
        {
            return _billsService.BillsGetByID(Id);
        }


        [HttpGet]
        [Route("api/Bills/gettable/{id}")]
        public Bills BillsGetByIdTable(int Id)
        {
            return _billsService.BillsGetByIdTable(Id);
        }

        [HttpGet]
        [Route("api/Bills/IsPayment")]
        public IList<Bills> BillsIsPayment()
        {
            return _billsService.BillIsPayment();
        }


        [HttpGet]
        [Route("api/Bills/IsNotPayment")]
        public IList<Bills> BillsIsNotPayment()
        {
            return _billsService.BillIsNotPayment();
        }


        [HttpPost]
        [Route("api/Bills/add")]
        public int BillsAdd(BillsAdd billsAdd)
        {
            return _billsService.BillsAdd(billsAdd);
        }
    }
}