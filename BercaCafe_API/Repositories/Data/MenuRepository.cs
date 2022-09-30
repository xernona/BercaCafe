using BercaCafe_API.Models;
using BercaCafe_API.Repositories.Interfaces;
using BercaCafe_API.ViewModels;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;

namespace BercaCafe_API.Repositories.Data
{
    public class MenuRepository : IMenuRepository
    {
        public IConfiguration _configuration;
        public MenuRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        DynamicParameters parameters = new DynamicParameters();
        public IEnumerable<MenuVM> GetAllMenus()
        {
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionStrings:BercaCafe"]))
            {
                var spName = "spMenuNew";
                parameters.Add("@IDUDC", 0);
                var menu = connection.Query<MenuVM>(spName, parameters, commandType: CommandType.StoredProcedure);
                return menu;
            }

        }

        public MenuVM GetMenuById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionStrings:BercaCafe"]))
            {
                var spName = "spMenuNew";
                parameters.Add("@IDUDC", id);
                var menuSingle = connection.QuerySingle<MenuVM>(spName, parameters, commandType: CommandType.StoredProcedure);
                return menuSingle;
            }
        }
    }
}
