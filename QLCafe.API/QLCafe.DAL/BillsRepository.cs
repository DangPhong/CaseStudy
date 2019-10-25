using Dapper;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QLCafe.DAL
{
    public class BillsRepository : BaseRepository, IBillsRepository
    {
        public IList<Bills> BillGetAll()
        {
            IList<Bills> billsGetAll = SqlMapper.Query<Bills>(con, "Bills_GetAll", commandType: CommandType.StoredProcedure).ToList();
            return billsGetAll;
        }

        public IList<Bills> BillIsNotPayment()
        {
            IList<Bills> billIsNotPayment = SqlMapper.Query<Bills>(con, "Bills_IsNotPayment", commandType: CommandType.StoredProcedure).ToList();
            return billIsNotPayment;
        }

        public IList<Bills> BillIsPayment()
        {
            IList<Bills> billIsPayment = SqlMapper.Query<Bills>(con, "Bills_IsPayment", commandType: CommandType.StoredProcedure).ToList();
            return billIsPayment;
        }

        public Bills BillsGetByID(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);

                Bills billsGetByID = SqlMapper.Query<Bills>(con, "Bills_GetByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return billsGetByID;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Bills BillsGetByIdTable(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TableID", Id);

                Bills billsGetByID = SqlMapper.Query<Bills>(con, "Bills_GetByIdTable",parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return billsGetByID;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int BillsAdd(BillsAdd billsAdd)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TableID", billsAdd.TableID);
                var result = SqlMapper.ExecuteScalar<int> (con, "Bills_Add", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
