using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Procerdures
{
    public interface ISalesByCategoryProc
    {
        public List<SalesByCategory> GetSalesByCategory(string CategoryName, string OrdYear);
    }
}
