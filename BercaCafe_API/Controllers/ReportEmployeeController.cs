using BercaCafe_API.Repositories.Data;
using BercaCafe_API.Repositories.Interfaces;
using BercaCafe_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Linq;
using System.Net;

namespace BercaCafe_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportEmployeeController : ControllerBase
    {
        private readonly IReportEmployeeRepository reportEmployeeRepository;

        public ReportEmployeeController(IReportEmployeeRepository repository)
        {
            reportEmployeeRepository = repository;
        }

        [HttpGet]
        public ActionResult GetByEmployee(
            DateTime fromDate,
            DateTime thruDate,
            string department,
            string employeeId
            )
        {

            var report = reportEmployeeRepository.GetByEmployee(fromDate, thruDate, department, employeeId);

            if(report.Count() == 0)
            {
                return StatusCode(404, new
                {
                    status = HttpStatusCode.NotFound,
                    message = "Tidak ada data"
                });
            }
            else
            {
                return StatusCode(200, new
                {
                    status = HttpStatusCode.OK,
                    message = report.Count() + " DATA ADA",
                    result = report
                });
            }
        }
    }
}
