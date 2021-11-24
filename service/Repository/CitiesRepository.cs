using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace service.Repository
{
    public class CitiesRepository : ICitiesRepository
    {
        private IDbConnection db;

        public CitiesRepository(IConfiguration config)
        {
            db = new SqlConnection(config.GetConnectionString("SqlJsonConnection"));
        }

        public List<string> GetAllCities()
        {
            return db.Query<string>("CitiesList", commandType: CommandType.StoredProcedure).ToList();
        }
    }
}
