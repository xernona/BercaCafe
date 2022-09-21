using System;
using System.Collections.Generic;

#nullable disable

namespace BercaCafe_API.Models
{
    public partial class MsEmployee
    {
        public int UserId { get; set; }
        public int EmployeeKey { get; set; }
        public string EmployeeName { get; set; }
        public string Dept { get; set; }
        public DateTime? EffDt { get; set; }
        public DateTime? HireDt { get; set; }
        public DateTime? TerminationDt { get; set; }
        public byte? EmployeeFlag { get; set; }
        public byte? KuponFlag { get; set; }
        public string CardNo { get; set; }
    }
}
