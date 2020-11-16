using API.Entities;
using API.Interfaceses;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Reposytory
{
    public class CarRepository : ICarRepository
    {
        private readonly DataContext _context;
        public CarRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Car>> GetCarsAsync() => await _context.Cars.ToListAsync();
        public async Task<Car> GetCarAsync(long id) => await _context.Cars.SingleOrDefaultAsync(x => x.Id == id);

    }
}
