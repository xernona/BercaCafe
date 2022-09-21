using System;
using System.Collections.Generic;

#nullable disable

namespace BercaCafe_API.Models
{
    public partial class ScAbsen
    {
        public int Userid { get; set; }
        public string Badgenumber { get; set; }
        public string Ssn { get; set; }
        public string Name { get; set; }
        public string CardNo { get; set; }
    }
}
