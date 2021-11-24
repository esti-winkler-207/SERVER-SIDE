using DAL.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Procerdures
{
    public class SalesByCategoryProc : ISalesByCategoryProc
    {
        private IDbConnection db;

        public SalesByCategoryProc(IConfiguration config)
        {
            db = new SqlConnection(config.GetConnectionString("SqlJsonConnection"));
        }

        public List<SalesByCategory> GetSalesByCategory(string CategoryName, string OrdYear)
        {
            return db.Query<SalesByCategory>("SalesByCategory", new { CategoryName, OrdYear }, commandType: CommandType.StoredProcedure).ToList();
        }
    }
}
