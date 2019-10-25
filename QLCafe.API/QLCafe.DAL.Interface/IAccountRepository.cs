using QLCafe.Domain.Request;
using System;
using System.Collections.Generic;
using System.Text;
using QLCafe.Domain.Response;

namespace QLCafe.DAL.Interface
{
    public interface IAccountRepository
    {
        bool AccountAdd(AccountAdd request);
        bool AccountUpdate(AccountUpdate request);
        bool AccountDelete(int id);
        IList<AccountView> AccountGetAll();
        Account AccountGetById(int id);
    }
}
