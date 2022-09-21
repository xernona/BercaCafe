using APIDapper.Models;
using APIDapper.Repositories.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;

namespace APIDapper.Repositories
{
    public class UniversityRepository : IRepository
    {
        public IConfiguration _configuration;  //agar bisa baca object appsetting.json

        public UniversityRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        DynamicParameters parameters = new DynamicParameters(); //menggunakan orm dapper agar bisa query sql pada method. atau menggunakan store procedure.

        //we use two function "Query" and "Execute"
        //Query use when get
        //execute use for transaction (insert, update, delete)
        public int Delete(string Id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<University> Get()
        {
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionStrings:APIDapper"])) //manggil object connection string dari file appsettings.json
            {
                var spName = "SP_GetAllUniv";
                var univ = connection.Query<University>(spName, commandType: CommandType.StoredProcedure);
                return univ;
            }
        }

        public University Get(string Id)
        {
            throw new System.NotImplementedException();
        }

        public int Insert(University university)
        {
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionStrings:APIDapper"]))
            {
                var procName = "SP_Insert";
                parameters.Add("@Name", university.Name);

                var insert = connection.Execute(procName, parameters, commandType: CommandType.StoredProcedure);
                return insert;
            }
        }

        public int Update(University university)
        {
            throw new System.NotImplementedException();
        }
    }
}
