using API.Entities;
using API.Interfaceses;
<<<<<<< HEAD:API/Data/Reposytory/UserRepository.cs
using Microsoft.EntityFrameworkCore;
=======
>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618:API/Data/UserRepository.cs
using System.Collections.Generic;
using System.Linq;


namespace API.Data
{
    public class UserRepository : IUserReposytiry
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

<<<<<<< HEAD:API/Data/Reposytory/UserRepository.cs
        public async Task<IEnumerable<User>> GetUsersAsync() => await _context.Users.ToListAsync();
        public async Task<User> GetUserAsync(long id) => await _context.Users.SingleOrDefaultAsync(x => x.Id == id);
=======
        public IEnumerable<User> GetUsers() => _context.Users;
        public User GetUser(long id) => _context.Users.SingleOrDefault(x => x.Id == id);
>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618:API/Data/UserRepository.cs
    }
}
