using System;
using System.Collections.Generic;

#nullable disable

namespace BercaCafe_API.Models
{
    public partial class PsJob
    {
        public string Emplid { get; set; }
        public decimal EmplRcd { get; set; }
        public DateTime Effdt { get; set; }
        public decimal Effseq { get; set; }
        public string Deptid { get; set; }
        public string HrStatus { get; set; }
        public string EmplStatus { get; set; }
        public string Action { get; set; }
        public DateTime? ActionDt { get; set; }
        public string ActionReason { get; set; }
        public string Company { get; set; }
        public string Paygroup { get; set; }
        public string EmplType { get; set; }
        public string EmplClass { get; set; }
        public DateTime? HireDt { get; set; }
        public DateTime? LastHireDt { get; set; }
        public DateTime? TerminationDt { get; set; }
        public string FlgKuponMakan { get; set; }
        public string WorkLocation { get; set; }
        public string JamKerja { get; set; }
    }
}
