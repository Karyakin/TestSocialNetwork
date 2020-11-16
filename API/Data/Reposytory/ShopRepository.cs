using API.Data;
using API.Entities;
using API.Interfaceses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ShopRepository : IShopReposytory<Shop>
    {
        DataContext _dataContext;
        public ShopRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Shop> FindById(long id) => await _dataContext.Shops.SingleOrDefaultAsync(x=>x.Id == id);
        public async Task<IEnumerable<Shop>> Get() => await _dataContext.Shops.ToListAsync();
        public async Task<IEnumerable<Shop>> GetByName(string name) => await _dataContext.Shops.Where(x=>x.Name == name).ToListAsync();
    }
}
