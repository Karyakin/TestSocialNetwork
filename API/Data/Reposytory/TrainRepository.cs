using API.Entities;
using API.Interfaceses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Reposytory
{
    public class TrainRepository : ITrainsReposytory<Train>
    {
        DataContext _dataContext;
        public TrainRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Train> FindById(long id) => await _dataContext.Trains.SingleOrDefaultAsync(x=>x.Id == id);

        public async Task<IEnumerable<Train>> Get() => await _dataContext.Trains.ToListAsync();

        public async Task<IEnumerable<Train>> GetByBrand(string brand) => await _dataContext.Trains.Where(x=> x.Brand == brand).ToListAsync();
    }
}
