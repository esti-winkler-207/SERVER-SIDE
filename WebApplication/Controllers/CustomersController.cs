using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UkrGuru.SqlJson;
using DAL.Entities;
using service.Repository;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersRepository _cusRepo;
        public CustomersController(ICustomersRepository cusRepo)
        {
            _cusRepo = cusRepo;
        }

        [HttpGet]
        public  List<Customers> GetAllCustomers()
        {
            return  _cusRepo.GetAll();
        }

        [HttpGet("{ContactName}/{Address}/{City}/{Phone}")]
        public Customers GetCustomersByFields(string ContactName, string Address, string City, string Phone)
        {
            return _cusRepo.GetCustomersByFields(ContactName, Address, City, Phone);
        }
    }
}
