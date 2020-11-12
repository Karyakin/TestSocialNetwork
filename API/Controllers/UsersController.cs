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
        private readonly DataContext _dataContext;
        private readonly IUserReposytiry _userReposytiry;


        public UsersController(DataContext dataContext, IUserReposytiry userReposytiry)
        {
            _dataContext = dataContext;
            _userReposytiry = userReposytiry;
        }

        [HttpGet]
        public IEnumerable<User> GetUsers() => _userReposytiry.GetUsers();


        [HttpGet("{id}")]
        public User GetUsers(long id) => _userReposytiry.GetUser(id);

     

    }
}
