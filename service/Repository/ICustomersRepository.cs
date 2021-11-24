using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace service.Repository
{
    public interface ICustomersRepository
    {
        Customers GetCustomersByFields(string ContactName, string Address, string City, string Phone);

        List<Customers> GetAll();
    }
}
