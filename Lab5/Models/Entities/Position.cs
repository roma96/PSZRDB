using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Models
{
    [Serializable]
    public partial class Position
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Name { get; set; }
    }
}
