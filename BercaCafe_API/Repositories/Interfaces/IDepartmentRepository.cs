using System.Collections.Generic;

namespace BercaCafe_API.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<string> GetAllDepartment();

    }
}
