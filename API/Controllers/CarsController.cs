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

        public ActionResult GetRez()
        {

            return Ok("Return OK");
        }


        [HttpGet("U1")]
        public IActionResult GetRex()
        {
            return Ok("Return OK by Interface");
        }

        [HttpGet("U2")]
        public IActionResult GetStatusCode()
        {
            return StatusCode(401);
        }

        [HttpGet("U3")]
        public IActionResult GetContent()
        {
            return Content("GetContent");
        }

        [HttpGet("U4")]
        public IActionResult NotFoundResult()
        {
            return NotFound("NotFound");
        }

        [HttpGet("U5")]
        public IActionResult UnauthorizedResult(int a)
        {
            if (a < 18)
                return Unauthorized();
            return Content("All Right");


        }
    }
}
