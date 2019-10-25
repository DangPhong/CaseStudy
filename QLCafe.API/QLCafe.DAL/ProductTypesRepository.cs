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
    public class ProductTypesRepository : BaseRepository, IProductTypesRepository
    {
        public IList<ProductTypes> ProductTypesGetAll()
        {
            IList<ProductTypes> productTypesGetAll = SqlMapper.Query<ProductTypes>(con, "ProductTypes_GetAll", commandType: CommandType.StoredProcedure).ToList();
            return productTypesGetAll;
        }

        public ProductTypes ProductTypesGetById(int Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Id);
            ProductTypes productTypes = SqlMapper.Query<ProductTypes>(con, "ProductTypes_GetById", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return productTypes;
        }

        public bool ProductTypesAdd(ProductTypesAdd request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Name", request.Name);

                SqlMapper.Execute(con, "ProductTypes_Add", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)    
            {
                throw ex;
            }
        }

        public bool ProductTypesDelete(int Id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Id);
            SqlMapper.Execute(con, "ProductTypes_Delete", param: parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool ProductTypesUpdate(ProductTypesUpdate request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ID", request.ID);
                parameters.Add("@Name", request.Name);

                SqlMapper.Execute(con, "ProductTypes_Update", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
