using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Models
{
    [Serializable]
    public partial class Invoice
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int CompanyId { get; set; }
        public int ResponsibleEmployeeId { get; set; }
        public string Note { get; set; }
        public string DistinationAddress { get; set; }
        public string ArrivalAddress { get; set; }
        public int InvoiceTypeId { get; set; }
    }
}
