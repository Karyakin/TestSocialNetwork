using API.Entities;
using API.Interfaceses;
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

        public IEnumerable<User> GetUsers() => _context.Users;
        public User GetUser(long id) => _context.Users.SingleOrDefault(x => x.Id == id);
    }
}
