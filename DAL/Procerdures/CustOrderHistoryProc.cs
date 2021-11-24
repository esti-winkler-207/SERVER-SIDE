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
    public  class CustOrderHistoryProc : ICustOrderHistoryProc
    {
        private IDbConnection db;

        public CustOrderHistoryProc(IConfiguration config)
        {
            this.db = new SqlConnection(config.GetConnectionString("SqlJsonConnection"));
        }

        public  List<CustOrderHistory> GetCustOrderHisory(string CustomerID, DateTime startDate, DateTime EndDate)
        {
           return db.Query<CustOrderHistory>("CustOrderHist", new { CustomerID, startDate, EndDate }, commandType: CommandType.StoredProcedure).ToList();

        }


    }
}
