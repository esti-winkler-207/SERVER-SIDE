using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace service.Repository
{
    public class CustomersRepository : ICustomersRepository
    {

        private IDbConnection db;

        public CustomersRepository(IConfiguration config)
        {
            this.db = new SqlConnection(config.GetConnectionString("SqlJsonConnection"));
        }
        public Customers GetCustomersByFields(string ContactName, string Address, string City, string Phone)
        {
            return db.Query<Customers>("find_customer", new { ContactName, Address, City, Phone }, commandType: CommandType.StoredProcedure).Single();
        }

        public List<Customers> GetAll()
        {
            return db.Query<Customers>("Customers_list", commandType: CommandType.StoredProcedure).ToList();
        }

        
    }
}
