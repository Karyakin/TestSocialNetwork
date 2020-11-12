using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

        [HttpPost("register")]
        public ActionResult<User> Register(string login, string password)
        {
            if (UserExist(login))
                return BadRequest("User allredy exist");
            using (var hmac = new HMACSHA512())
            {
                var user = new User
                {
                    Login = login,
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
                    PasswordSalt = hmac.Key
                };
                _context.Users.Add(user);
                _context.SaveChanges();

                return user;
            }
        }

        [HttpPost("login")]
        public ActionResult<User> Login(string login, string password)
        {
            var user = _context.Users.SingleOrDefault(x => x.Login == login);
            if (user == null)
                return BadRequest();
            using (var hmac = new HMACSHA512(user.PasswordSalt))
            {
                var computesHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                for (int i = 0; i < computesHash.Length; i++)
                {
                    if (computesHash[i] != user.PasswordHash[i])
                        return Unauthorized();//ошибка неавторизации. не смог авторизоваться
                }
                return user;
            }
        }




        private bool UserExist(string login) => _context.Users.Any(x => x.Login == login);



    }
}
