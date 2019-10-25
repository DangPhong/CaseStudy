using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace QLCafe.DAL
{
    public class BaseRepository
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connecString = @"Data Source=DESKTOP-DRHRVKR;Initial Catalog=Cafe3;Integrated Security=True";
            con = new SqlConnection(connecString);
        }
    }
}
