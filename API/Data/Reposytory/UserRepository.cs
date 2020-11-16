using API.Entities;
using API.Interfaceses;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class UserRepository : IUserReposytiry
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsersAsync() => await _context.Users.ToListAsync();
        public async Task<User> GetUserAsync(long id) => await _context.Users.SingleOrDefaultAsync(x => x.Id == id);
    }
}
