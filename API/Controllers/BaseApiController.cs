using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]//это атрибут говорит о том, по какому роуту вызывается контроллер и мы ему говорим, 
                           //что это роут вызывается по имени контроллера. Т.Е зайдем в этот контроллер по имени Users 
    public class BaseApiController : ControllerBase 
    {

    }
}
