using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]//это атрибут говорит о том, по какому роуту вызывается контроллер и мы ему говорим, //что это роут вызывается по имени контроллера. Т.Е зайдем в этот контроллер по имени Users 
    public class CarsController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public CarsController(DataContext dataContext)
        {
            _dataContext = dataContext;


        }

        

        
    }
}
