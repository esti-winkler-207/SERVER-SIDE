using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustOrderHistoryController : ControllerBase
    {
        private readonly ICustOrderHistory _cusRepo;
        public CustOrderHistoryController(ICustOrderHistory cusRepo)
        {
            _cusRepo = cusRepo;
        }
        [HttpGet("{CustomerID}/{startDate}/{EndDate}")]
        public List<CustOrderHistory> GetCustOrderHisory(string CustomerID, DateTime startDate, DateTime EndDate)
        {
            return _cusRepo.GetCustOrderHisory(CustomerID,startDate, EndDate);
        }
    }
}
