using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Repository
{
    public interface ISalesByCategoryRepository
    {
        public List<SalesByCategory> GetSalesByCategory(string CategoryName, string OrdYear);
    }
}
