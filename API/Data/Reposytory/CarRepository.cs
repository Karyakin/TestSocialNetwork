using API.Entities;
using API.Interfaceses;
using System.Collections.Generic;
using System.Linq;


namespace API.Data.Reposytory
{
    public class CarRepository : ICarRepository
    {
        private readonly DataContext _context;
        public CarRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetCars() => _context.Cars;
        public Car GetCar(long id) => _context.Cars.SingleOrDefault(x => x.Id == id);

    }
}
