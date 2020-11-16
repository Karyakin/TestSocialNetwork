using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaceses
{ 
   public interface ICarRepository
    {
       Task<IEnumerable<Car>> GetCarsAsync();
       Task<Car> GetCarAsync(long id);
    }
}
