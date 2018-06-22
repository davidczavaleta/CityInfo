using AutoMapper;
using CityInfo.API.Models;
using CityInfo.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        private readonly ICityInfoRepository _cityInfoRepository;

        public CitiesController(ICityInfoRepository cityInfoRepository)
        {
            _cityInfoRepository = cityInfoRepository;
        }

        [HttpGet()]
        public IActionResult GetCities()
        {
            var cityEntities = _cityInfoRepository.GetCities();
            var results = Mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cityEntities);           

            return Ok(results); 
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id, bool includePointsOfInterest = false)
        {
            var city = _cityInfoRepository.GetCity(id, includePointsOfInterest);

            if (city == null)
            {
                return NotFound(); 
            }

            //if (includePointsOfInterest)
            //{
            //    var cityResult = new CityDto()
            //    {
            //        Id = city.Id,
            //        Name = city.Name,
            //        Description = city.Description
            //    };

            //    foreach (var pointOfInterest in city.PointsOfInterest)
            //    {
            //        cityResult.PointsOfInterest.Add(
            //            new PointOfInterestDto()
            //            {
            //                Id = pointOfInterest.Id,
            //                Name = pointOfInterest.Name,
            //                Description = pointOfInterest.Description
            //            });
            //    }

            //    return Ok(cityResult);
            //}

            //var cityWithoutPointsOfInterestResult = new CityWithoutPointsOfInterestDto()
            //{
            //    Id = city.Id,
            //    Name = city.Name,
            //    Description = city.Description
            //};

            //return Ok(cityWithoutPointsOfInterestResult);

            return includePointsOfInterest ? Ok(Mapper.Map<CityDto>(city)) : Ok(Mapper.Map<CityWithoutPointsOfInterestDto>(city));
        }
    }
}
