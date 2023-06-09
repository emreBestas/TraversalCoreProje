﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values=JsonConvert.SerializeObject(destination);
            return Json(values);
        }
        public IActionResult GetById (int DestinationID)
        {
            var values=_destinationService.GetByID(DestinationID);
            var jsonValues=JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.GetByID(id);
            _destinationService.TDelete(values);
           
            return NoContent();
        }
        public IActionResult UpdateCity(Destination destination)
        {
            var values = _destinationService.GetByID(destination.DestinationID);
            destination.Status = true;
            destination.Price = values.Price;
            _destinationService.TUpdate(destination);
            var jsonValues = JsonConvert.SerializeObject(destination);
            return Json(jsonValues);
        }

        public static List<CityClass> cities = new List<CityClass>()
        {
            new CityClass{ CityID=1,CityName="NewYork",CityCountry="USA"},
            new CityClass{ CityID=2,CityName="London",CityCountry="UK"},
            new CityClass{ CityID=3,CityName="Eskişehir",CityCountry="Turkey"},
            new CityClass{ CityID=4,CityName="Amsterdam",CityCountry="Nederland"}
        };

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
    }
}
