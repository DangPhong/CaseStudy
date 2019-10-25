using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Request;
using QLCafe.Domain.Response;

namespace QLCafe.DAL
{
    public class AccountRepository : BaseRepository, IAccountRepository
    {
        public bool AccountAdd(AccountAdd request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserName", request.UserName);
                parameters.Add("@Password", request.Password);
                parameters.Add("@Role", request.Role);
                SqlMapper.Execute(con, "Account_Add", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AccountDelete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ID", id);
            SqlMapper.Execute(con, "Account_Delete", param: parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public IList<AccountView> AccountGetAll()
        {
            IList<AccountView> accountList = SqlMapper.Query<AccountView>(con, "Account_GetAll", commandType: CommandType.StoredProcedure).ToList();
            return accountList;
        }

        public Account AccountGetById(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", id);
                return SqlMapper.Query<Account>((SqlConnection)con, "Account_GetById", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AccountUpdate(AccountUpdate request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", request.Id);
                parameters.Add("@UserName", request.UserName);
                parameters.Add("@Password", request.Password);
                parameters.Add("@Role", request.Role);
                SqlMapper.Execute(con, "Account_Update", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
