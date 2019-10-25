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
    public class BillDetailReponsitory : BaseRepository, IBillDetailReponsitory
    {
        public int BillDetailAddByID(BillDetailAdd request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BillID", request.BillID);
                parameters.Add("@ProductID", request.ProductID);
                parameters.Add("@Number", request.Number);
                var Id = SqlMapper.ExecuteScalar<int>(con, "BillDetails_AddByIDBills", param: parameters, commandType: CommandType.StoredProcedure);
                return Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool BillDetailDelete(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);
                var result = SqlMapper.ExecuteScalar<bool>(con, "BillDetails_Delete", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList< BillDetail> BillDetailGetByID(int Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Id);
          IList<  BillDetail> billDetail = SqlMapper.Query<BillDetail>(con, "BillDetails_GetByIDBills", parameters, commandType: CommandType.StoredProcedure).ToList();
            return billDetail;
        }

        public IList<BillDetailsView> BillDetailsView(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TableId", Id);
                IList<BillDetailsView> billDetail = SqlMapper.Query<BillDetailsView>(con, "BillDetails_View", parameters, commandType: CommandType.StoredProcedure).ToList();
                return billDetail;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Pay(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TableId", Id);
                var result = SqlMapper.ExecuteScalar<bool>(con, "Pay", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
