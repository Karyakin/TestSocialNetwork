using API.Entities;
using API.Interfaceses;
using System;
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
        public User GetUser(long id)
        {
           return _context.Users.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<User> GetUsers() => _context.Users;
    }
}
