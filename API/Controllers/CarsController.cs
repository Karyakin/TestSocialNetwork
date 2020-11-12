using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Interfaceses;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CarsController : BaseApiController//в этом классе все атрибуты + он наследуется от BaseController
    {
        private readonly DataContext _dataContext;
        private readonly ICarRepository _carRepository;

        public CarsController(DataContext dataContext, ICarRepository carRepository)
        {
            _dataContext = dataContext;
            _carRepository = carRepository;
        }



        [HttpGet]
        public IEnumerable<Car> GetCars() => _carRepository.GetCars();

        [HttpGet("{id}")]
        public Car GetCar(long id) => _carRepository.GetCar(id);
    }
}
