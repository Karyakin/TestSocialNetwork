using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class AccountController : BaseApiController //в этом классе все атрибуты + он наследуется от BaseController
    {
        private readonly DataContext _context;
        public AccountController(DataContext context)
        {
            _context = context; 
        }

        [HttpPost]
        public ActionResult<User> Register(string lopin, string password)
        {
            if (true)
            {

            }
        }

        private bool UserExist(string login)
        {

        }
         

    }
}
