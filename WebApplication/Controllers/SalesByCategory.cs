using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesByCategoryController : ControllerBase
    {
        private readonly ISalesByCategoryRepository _salesByCategoryRepository;
        public SalesByCategoryController(ISalesByCategoryRepository salesByCategoryRepository)
        {
            _salesByCategoryRepository = salesByCategoryRepository;
        }
        [HttpGet("{CategoryName}/{OrdYear}")]
        public List<SalesByCategory> GetSalesByCategory(string CategoryName, string OrdYear)
        {
            return _salesByCategoryRepository.GetSalesByCategory(CategoryName, OrdYear);
        }

    }
}
