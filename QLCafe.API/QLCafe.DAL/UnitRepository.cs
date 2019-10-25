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
    public class UnitRepository : BaseRepository, IUnitRepository
    {
        public bool UnitAdd(UnitAdd request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Name", request.Name);
                SqlMapper.Execute(con, "Unit_Add", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UnitDelete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            SqlMapper.Execute(con, "Unit_Delete", param: parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public IList<Unit> UnitGetAll()
        {
            IList<Unit> unitList = SqlMapper.Query<Unit>(con, "Unit_GetAll", commandType: CommandType.StoredProcedure).ToList();
            return unitList;
        }

        public Unit UnitGetById(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", id);
                return SqlMapper.Query<Unit>((SqlConnection)con, "Unit_GetById", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UnitUpdate(UnitUpdate request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.Id);
                parameters.Add("@Name", request.Name);
                SqlMapper.Execute(con, "Unit_Update", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
