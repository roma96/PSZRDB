using System;

namespace Models
{
    [Serializable]
    public partial class Employee
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassportSeria { get; set; }
        public string PassportCode { get; set; }
        public string TaxpayerCode { get; set; }
        public int PositionId { get; set; }
    }
}
