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
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        // GET api/account
        [HttpGet]
        [Route("api/account/gets")]
        public IList<AccountView> Account_GetAll()
        {
            return _accountService.AccountGetAll();
        }
        // GET api/account/5
        [HttpGet]
        [Route("api/account/get/{id}")]
        public Account Account_GetById(int id)
        {
            return _accountService.AccountGetById(id);
        }

        // POST api/account
        [HttpPost]
        [Route("api/account/create")]
        public bool Account_Add([FromBody] AccountAdd request)
        {
            return _accountService.AccountAdd(request);
        }

        // PUT api/account/5
        [HttpPut]
        [Route("api/account/update")]
        public bool Account_Update([FromBody] AccountUpdate request)
        {
            return _accountService.AccountUpdate(request);
        }

        // DELETE api/unit/5
        [HttpGet]
        [Route("api/account/delete/{id}")]
        public bool Account_Delete(int id)
        {
            return _accountService.AccountDelete(id);
        }
    }
}