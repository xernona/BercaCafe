using BercaCafe_API.Repositories.Interfaces;
using BercaCafe_API.ViewModels;
using Dapper;
using System;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace BercaCafe_API.Repositories.Data
{
    public class ReportDivisiRepository : IReportDivisiRepository
    {
        public IConfiguration _configuration;

        public ReportDivisiRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        DynamicParameters parameters = new DynamicParameters();

        public IEnumerable<ReportDivisiVM> GetByDivisi(DateTime fromDate, DateTime thruDate)
        {
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionStrings:BercaCafe"]))
            {
                var spName = "spReportAbsenceByDivisiNew";
                parameters.Add("@fromDate", fromDate);
                parameters.Add("@thruDate", thruDate);
                var absen = connection.Query<ReportDivisiVM>(spName, parameters, commandType: CommandType.StoredProcedure);
                return absen;
            }
        }
    }
}
