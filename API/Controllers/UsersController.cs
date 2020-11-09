using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]//это атрибут говорит о том, по какому роуту вызывается контроллер и мы ему говорим, 
                            //что это роут вызывается по имени контроллера. Т.Е зайдем в этот контроллер по имени Users 
    public class UsersController : ControllerBase//Базовый класс без поддержки View
    {
        public DataContext _dataContext { get; set; }
        public UsersController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

       [HttpGet("U1")]
        public ActionResult GetUsers(string a)//  Тип ActionResult позволяет возвращать из метода коды с котороми отрабатывает метод
        {
            return BadRequest(a);
        }


        [HttpGet("U2")]
        public ActionResult GetUsers(int a)//  Тип ActionResult позволяет возвращать из метода коды с котороми отрабатывает метод
        {
          
            return BadRequest("Пришел тип инт");
        }
    }
}
