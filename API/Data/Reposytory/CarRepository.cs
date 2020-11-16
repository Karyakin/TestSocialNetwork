using API.Entities;
using API.Interfaceses;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
=======
using System.Collections.Generic;
using System.Linq;

>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618

namespace API.Data.Reposytory
{
    public class CarRepository : ICarRepository
    {
        private readonly DataContext _context;
        public CarRepository(DataContext context)
        {
            _context = context;
        }

<<<<<<< HEAD
        public async Task<IEnumerable<Car>> GetCarsAsync() => await _context.Cars.ToListAsync();
        public async Task<Car> GetCarAsync(long id) => await _context.Cars.SingleOrDefaultAsync(x => x.Id == id);
=======
        public IEnumerable<Car> GetCars() => _context.Cars;
        public Car GetCar(long id) => _context.Cars.SingleOrDefault(x => x.Id == id);
>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618

    }
}
