using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaceses
{ 
   public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCar(long id);
    }
}
