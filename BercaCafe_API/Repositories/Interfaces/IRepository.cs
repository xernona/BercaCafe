using APIDapper.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Collections.Generic;

namespace APIDapper.Repositories.Interfaces
{
    public interface IRepository
    {
        IEnumerable<University> Get();
        University Get(string Id);
        int Insert(University university);
        int Update(University university);
        int Delete(string Id);
    }
}
