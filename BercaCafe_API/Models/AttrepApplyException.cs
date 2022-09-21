using System;
using System.Collections.Generic;

#nullable disable

namespace BercaCafe_API.Models
{
    public partial class AttrepApplyException
    {
        public string TaskName { get; set; }
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public DateTime ErrorTime { get; set; }
        public string Statement { get; set; }
        public string Error { get; set; }
    }
}
