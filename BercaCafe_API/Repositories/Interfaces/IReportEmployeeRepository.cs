using BercaCafe_API.Models;
using BercaCafe_API.ViewModels;
using System;
using System.Collections.Generic;

namespace BercaCafe_API.Repositories.Interfaces
{
    public interface IReportEmployeeRepository
    {
        IEnumerable<ReportEmployeeVM> GetByEmployee(
            DateTime fromDate,
            DateTime thruDate,
            string department,
            string employeeId
            );
    }
}
