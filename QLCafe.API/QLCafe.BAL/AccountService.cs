using System;
using System.Collections.Generic;
using System.Text;
using QLCafe.BAL.Interface;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Request;
using QLCafe.Domain.Response;


namespace QLCafe.BAL
{
    public class AccountService : IAccountService
    {
        IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public bool AccountAdd(AccountAdd request)
        {
           return _accountRepository.AccountAdd(request);
        }

        public bool AccountDelete(int id)
        {
            return _accountRepository.AccountDelete(id);
        }

        public IList<AccountView> AccountGetAll()
        {
            return _accountRepository.AccountGetAll();
        }

        public Account AccountGetById(int id)
        {
            return _accountRepository.AccountGetById(id);
        }

        public bool AccountUpdate(AccountUpdate request)
        {
            return _accountRepository.AccountUpdate(request);
        }
    }
}
