using BercaCafe_API.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BercaCafe_API.Repositories.Interfaces
{
    public interface IReportDivisiRepository
    {
        public IEnumerable<ReportDivisiVM> GetByDivisi(
            DateTime fromDate,
            DateTime thruDate
            );
    }
}
