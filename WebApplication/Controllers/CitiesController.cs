using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using service.Repository;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICitiesRepository _citiesRepo;

        public CitiesController(ICitiesRepository citiesRepo)
        {
            _citiesRepo = citiesRepo;
        }

        public List<string> GetAllCities()
        {
            return _citiesRepo.GetAllCities();
        }


    }
}
