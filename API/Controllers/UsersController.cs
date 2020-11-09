using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase//Базовый класс без поддержки View
    {
        public DataContext _dataContext { get; set; }
        public UsersController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
