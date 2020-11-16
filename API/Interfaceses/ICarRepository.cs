using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaceses
{ 
   public interface ICarRepository
    {
<<<<<<< HEAD
       Task<IEnumerable<Car>> GetCarsAsync();
       Task<Car> GetCarAsync(long id);
=======
        IEnumerable<Car> GetCars();
        Car GetCar(long id);
>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618
    }
}
