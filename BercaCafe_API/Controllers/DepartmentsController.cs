using BercaCafe_API.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net;

namespace BercaCafe_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository departmentsRepository;

        public DepartmentsController(IDepartmentRepository repository)
        {
            departmentsRepository = repository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var dept = departmentsRepository.GetAllDepartment();
            if (dept.Count() == 0)
            {
                return StatusCode(404, new
                {
                    status = HttpStatusCode.NotFound,
                    message = "No data"
                });
            }
            else
            {
                return StatusCode(200, new
                {
                    status = HttpStatusCode.OK,
                    message = dept.Count() + " data found",
                    result = dept
                });
            }
        }
    }
}
