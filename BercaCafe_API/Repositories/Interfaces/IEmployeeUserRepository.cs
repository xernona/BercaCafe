using BercaCafe_API.ViewModels;

namespace BercaCafe_API.Repositories.Interfaces
{
    public interface IEmployeeUserRepository
    {
        EmployeeUserIDVM GetByEmployeeKey(int employeeKey);
        EmployeeCardDataVM GetByCardNo(string cardNo);
    }
}
