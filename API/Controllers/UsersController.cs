using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Interfaceses;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UsersController : BaseApiController//в этом классе все атрибуты + он наследуется от BaseController
    {
        private readonly IUserReposytiry _userReposytiry;

        public UsersController(DataContext dataContext, IUserReposytiry userReposytiry)
        {
            _userReposytiry = userReposytiry;
        }

        [HttpGet]
<<<<<<< HEAD
        public async Task<IEnumerable<User>> GetUsers() => await _userReposytiry.GetUsersAsync();

        [HttpGet("{id}")]
        public async Task<User> GetUsers(long id) => await _userReposytiry.GetUserAsync(id);
=======
        public IEnumerable<User> GetUsers() => _userReposytiry.GetUsers();


        [HttpGet("{id}")]
        public User GetUsers(long id) => _userReposytiry.GetUser(id);

     

>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618
    }
}
