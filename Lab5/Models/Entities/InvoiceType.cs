using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Models
{
    [Serializable]
    public partial class InvoiceType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
