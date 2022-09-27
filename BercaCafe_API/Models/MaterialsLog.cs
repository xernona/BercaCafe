using System;
using System.Collections.Generic;

#nullable disable

namespace BercaCafe_API.Models
{
    public partial class MaterialsLog
    {
        public int LogId { get; set; }
        public int MaterialsId { get; set; }
        public int MaterialsQuantity { get; set; }
        public int Price { get; set; }
        public int TotalPrice { get; set; }
        public DateTime InputDate { get; set; }

        public virtual Material Materials { get; set; }
    }
}
