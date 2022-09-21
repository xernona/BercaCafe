using System;
using System.Collections.Generic;

#nullable disable

namespace BercaCafe_API.Models
{
    public partial class TrAbsenHistory
    {
        public int EmployeeKey { get; set; }
        public int UserId { get; set; }
        public int? VendorId { get; set; }
        public int? MenuId { get; set; }
        public int? CupId { get; set; }
        public string TypeMenu { get; set; }
        public string Notes { get; set; }
        public DateTime LogTime { get; set; }
    }
}
