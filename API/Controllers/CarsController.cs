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
<<<<<<< HEAD
        private readonly ICarRepository _carRepository;

        public CarsController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Car>> GetCars() => await _carRepository.GetCarsAsync();

        [HttpGet("{id}")]
        public async Task<Car> GetCar(long id) => await _carRepository.GetCarAsync(id);
=======
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
>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618
    }
}
