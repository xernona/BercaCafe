using System;
using System.Collections.Generic;

#nullable disable

namespace BercaCafe_API.Models
{
    public partial class MsUdc
    {
        public int Idudc { get; set; }
        public string TypeUdc { get; set; }
        public int? Int1 { get; set; }
        public int? Int2 { get; set; }
        public int? Int3 { get; set; }
        public string Desc1 { get; set; }
        public string Desc2 { get; set; }
        public string Desc3 { get; set; }
        public DateTime? Date1 { get; set; }
        public decimal? Mnum1 { get; set; }
        public decimal? Mnum2 { get; set; }
    }
}
