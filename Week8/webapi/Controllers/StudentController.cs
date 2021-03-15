using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentservice;

        public StudentController(IStudentService studentservice)
        {
            _studentservice = studentservice;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return Ok(_studentservice.GetAllStudents());
        }
    }
}