using System;
using System.Collections.Generic;

#nullable disable

namespace BercaCafe_API.Models
{
    public partial class Material
    {
        public Material()
        {
            MaterialsLogs = new HashSet<MaterialsLog>();
        }

        public int MaterialsId { get; set; }
        public int CompTypeId { get; set; }
        public string MaterialsName { get; set; }
        public int Stock { get; set; }
        public int Quantity { get; set; }

        public virtual CompositionType CompType { get; set; }
        public virtual ICollection<MaterialsLog> MaterialsLogs { get; set; }
    }
}
