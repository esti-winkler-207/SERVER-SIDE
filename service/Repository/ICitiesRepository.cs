using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace service.Repository
{
    public interface ICitiesRepository
    {
        List<string> GetAllCities();
    }
}
