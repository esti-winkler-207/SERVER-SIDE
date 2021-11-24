using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Repository
{
    public interface ICustOrderHistory
    {
        List<DAL.Entities.CustOrderHistory> GetCustOrderHisory(string CustomerID, DateTime startDate, DateTime EndDate);

    }
}
