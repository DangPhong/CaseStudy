using QLCafe.Domain.Request;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.BAL.Interface
{
    public interface IAccountService
    {
        bool AccountAdd(AccountAdd request);
        bool AccountUpdate(AccountUpdate request);
        bool AccountDelete(int id);
        IList<AccountView> AccountGetAll();
        Account AccountGetById(int id);
    }
}
