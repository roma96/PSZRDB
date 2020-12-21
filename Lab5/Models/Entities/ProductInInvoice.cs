using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Models
{
    [Serializable]
    public partial class ProductInInvoice
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public string Units { get; set; }
        public double Sum { get; set; }
        public double SumWithoutTax { get; set; }
    }
}
