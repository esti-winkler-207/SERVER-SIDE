using DAL.Entities;
using DAL.Procerdures;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Repository
{
    public class SalesByCategoryRepository : ISalesByCategoryRepository
    {
        private readonly ISalesByCategoryProc _salesByCategoryProc;
        public SalesByCategoryRepository(ISalesByCategoryProc salesByCategoryProc)
        {
            _salesByCategoryProc = salesByCategoryProc;
        }
        public List<SalesByCategory> GetSalesByCategory(string CategoryName, string OrdYear)
        {
            return _salesByCategoryProc.GetSalesByCategory(CategoryName, OrdYear);
        }
    }
}
