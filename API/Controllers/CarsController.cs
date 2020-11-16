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
        private readonly ICarRepository _carRepository;

        public CarsController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Car>> GetCars() => await _carRepository.GetCarsAsync();

        [HttpGet("{id}")]
        public async Task<Car> GetCar(long id) => await _carRepository.GetCarAsync(id);
    }
}
