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
   public class AreaReponsitory : BaseRepository , IAreaReponsitory
    {
        public bool AreaAdd(AreaAdd request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Name", request.Name);
                SqlMapper.Execute(con, "Areas_Add", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AreaDelete(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);
                var result = SqlMapper.ExecuteScalar<bool>(con, "Areas_Delete", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Area> AreaGetAll()
        {
            IList<Area> areaList = SqlMapper.Query<Area>(con, "Areas_GetAll", commandType: CommandType.StoredProcedure).ToList();
            return areaList;
        }

        public bool AreaUpdate(AreaUpdate request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Name", request.Name);
                parameters.Add("Id", request.ID);
                SqlMapper.Execute(con, "Areas_Update", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Area AreaGetByID(int Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Id);
            Area area = SqlMapper.Query<Area>(con, "Areas_GetByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return area;
        }
    }
}
