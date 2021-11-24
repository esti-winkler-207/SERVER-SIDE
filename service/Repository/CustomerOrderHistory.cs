using DAL.Entities;
using DAL.Procerdures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Repository
{
    public class CustomerOrderHistory : ICustOrderHistory
    {
        private readonly ICustOrderHistoryProc _custOrderHistory;

        public CustomerOrderHistory(ICustOrderHistoryProc custOrderHistory)
        {
            _custOrderHistory = custOrderHistory;
        }

        public List<CustOrderHistory> GetCustOrderHisory(string CustomerID, DateTime startDate, DateTime EndDate)
        {
            startDate = startDate.Date;
            EndDate = EndDate.Date;
            return _custOrderHistory.GetCustOrderHisory(CustomerID, startDate, EndDate);
        }
    }
}
