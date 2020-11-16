using API.Data;
using API.DTO_dataTransferObject_;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
<<<<<<< HEAD
        public async Task<ActionResult<User>> Register(RegisterDto registerDto /*string login, string password*/)
        {
            if (UserExist(registerDto.Login))
=======
        public ActionResult<User> Register(string login, string password)
        {
            if (UserExist(login))
>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618
                return BadRequest("User allredy exist");
            using (var hmac = new HMACSHA512())
            {
                var user = new User
                {
<<<<<<< HEAD
                    Login = registerDto.Login,
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                    PasswordSalt = hmac.Key
                };
               await _context.Users.AddAsync(user);
               await _context.SaveChangesAsync();
=======
                    Login = login,
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
                    PasswordSalt = hmac.Key
                };
                _context.Users.Add(user);
                _context.SaveChanges();
>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618

                return user;
            }
        }

        [HttpPost("login")]
<<<<<<< HEAD
        public async Task<ActionResult<User>> Login(LoginDto loginDto/*string login, string password*/)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Login == loginDto.Login);
=======
        public ActionResult<User> Login(string login, string password)
        {
            var user = _context.Users.SingleOrDefault(x => x.Login == login);
>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618
            if (user == null)
                return BadRequest();
            using (var hmac = new HMACSHA512(user.PasswordSalt))
            {
<<<<<<< HEAD
                var computesHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));
=======
                var computesHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618

                for (int i = 0; i < computesHash.Length; i++)
                {
                    if (computesHash[i] != user.PasswordHash[i])
                        return Unauthorized();//ошибка неавторизации. не смог авторизоваться
                }
                return user;
            }
        }

<<<<<<< HEAD
=======



>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618
        private bool UserExist(string login) => _context.Users.Any(x => x.Login == login);



    }
}
