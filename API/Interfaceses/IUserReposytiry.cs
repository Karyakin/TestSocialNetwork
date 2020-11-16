using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaceses
{
<<<<<<< HEAD
    public interface IUserReposytiry
=======
   public interface IUserReposytiry  
>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserAsync(long id);
    }
}
