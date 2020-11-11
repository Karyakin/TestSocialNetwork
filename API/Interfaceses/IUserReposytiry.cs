using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaceses
{
   public interface IUserReposytiry
    {
        IEnumerable<User> GetUsers();
        User GetUser(long id);
    }
}
