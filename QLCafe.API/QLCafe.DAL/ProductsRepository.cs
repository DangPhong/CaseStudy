using Dapper;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QLCafe.DAL
{
    public class ProductsRepository : BaseRepository, IProductsRepository
    {
        public bool ProductsAdd(ProductsAdd request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TypeID", request.TypeID);
                parameters.Add("@UnitID", request.UnitID);
                parameters.Add("@Price", request.Price);
                parameters.Add("@Name", request.Name);
                SqlMapper.Execute(con, "Products_Add", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ProductsDelete(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);
                SqlMapper.Execute(con, "Products_Delete", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Products ProductsDetail(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                return SqlMapper.Query<Products>((SqlConnection)con, "Products_Detail", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<Products> ProductsGetAll()
        {
            IList<Products> productsGetAll = SqlMapper.Query<Products>(con, "Products_GetAll", commandType: CommandType.StoredProcedure).ToList();
            return productsGetAll;
        }

        public Products ProductsGetByID(int Id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);
                return SqlMapper.Query<Products>((SqlConnection)con, "Products_GetByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<Products> ProductsSearch(string stringSearch)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@stringSearch", stringSearch);
            IList<Products> productList = SqlMapper.Query<Products>(con, "Products_GetAll", parameters, commandType: CommandType.StoredProcedure).ToList();
            return productList;
        }

        public bool ProductsUpdate(ProductsUpdate request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", request.Id);
                parameters.Add("@TypeID", request.TypeID);
                parameters.Add("@UnitID", request.UnitID);
                parameters.Add("@Name", request.Name);
                parameters.Add("@Price", request.Price);
                SqlMapper.Execute(con, "Products_Update", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
