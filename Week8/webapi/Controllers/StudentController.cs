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
        private readonly SchoolContext _dbcontext;

        public StudentController(SchoolContext context)
        {
            _dbcontext = context;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            var result = _dbcontext.Student.ToList();
            return Ok(result);
        }
    }
}