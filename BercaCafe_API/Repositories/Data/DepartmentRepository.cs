using BercaCafe_API.Repositories.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;

namespace BercaCafe_API.Repositories.Data
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public IConfiguration _configuration;

        public DepartmentRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        DynamicParameters parameters = new DynamicParameters();

        public IEnumerable<string> GetAllDepartment()
        {
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionStrings:BercaCafe"]))
            {
                var spName = "spDeptListNew";
                var dept = connection.Query<string>(spName, commandType: CommandType.StoredProcedure);
                return dept;
            }
        }
    }
}
