using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    public class DummyController : Controller
    {
        private CityInfoContext _contexto;

        public DummyController(CityInfoContext contexto)
        {
            _contexto = contexto; 
        }

        [HttpGet]
        [Route("api/testdatabase")]
        public IActionResult TestDataBase()
        {
            return Ok();
        }
    }
}