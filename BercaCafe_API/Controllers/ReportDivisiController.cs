using BercaCafe_API.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;

namespace BercaCafe_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportDivisiController : ControllerBase
    {
        private readonly IReportDivisiRepository reportDivisiRepository;
        public ReportDivisiController(IReportDivisiRepository repository)
        {
            reportDivisiRepository = repository;
        }

        [HttpGet]
        public ActionResult GetByDivisi(DateTime fromDate, DateTime thruDate)
        {
            var report = reportDivisiRepository.GetByDivisi(fromDate, thruDate);
            if (report.Count() == 0)
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
