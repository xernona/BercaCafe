using BercaCafe_API.Models;
using BercaCafe_API.Repositories.Interfaces;
using BercaCafe_API.ViewModels;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace BercaCafe_API.Repositories.Data
{
    public class ReportEmployeeRepository : IReportEmployeeRepository
    {
        public IConfiguration _configuration;

        public ReportEmployeeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        DynamicParameters parameters = new DynamicParameters();

        public IEnumerable<ReportEmployeeVM> GetByEmployee(
            DateTime fromDate,
            DateTime thruDate,
            string department,
            string employeeId
            )
        {
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionStrings:BercaCafe"]))
            {
                var spName = "spReportAbsence";
                parameters.Add("@fromDate", fromDate);
                parameters.Add("@thruDate", thruDate);
                parameters.Add("@VendorID", "7");
                parameters.Add("@Dept", department);
                parameters.Add("@Empl", employeeId);
                var absen = connection.Query<ReportEmployeeVM>(spName, parameters, commandType: CommandType.StoredProcedure);
                return absen;
            }
        }

    }
}
