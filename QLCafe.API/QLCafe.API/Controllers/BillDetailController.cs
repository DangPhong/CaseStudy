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
    public class BillDetailController : ControllerBase
    {
        private readonly IBillDetailService _billDetailService;

        public BillDetailController(IBillDetailService billDetailService)
        {
            _billDetailService = billDetailService;
        }

        [HttpGet]
        [Route("api/billdetail/get/{id}")]
        public IList<BillDetail> BillDetailGetByID(int Id)
        {
            return _billDetailService.BillDetailGetByID(Id);
        }
        [HttpGet]
        [Route("api/billdetail/billdetailView/{id}")]
        public IList<BillDetailsView> BillDetailsViews(int Id)
        {
            return _billDetailService.BillDetailsView(Id);
        }

        [HttpPost]
        [Route("api/billdetail/add")]
        public int BillDetailAdd([FromBody] BillDetailAdd request)
        {
            return _billDetailService.BillDetailAddByID(request);
        }


        [HttpDelete]
        [Route("api/billdetail/delete/{id}")]
        public bool Delete(int Id)
        {
            return _billDetailService.BillDetailDelete(Id);
        }
        [HttpPut]
        [Route("api/billdetail/pay/{id}")]
        public bool Pay(int Id)
        {
            return _billDetailService.Pay(Id);
        }
    }
}