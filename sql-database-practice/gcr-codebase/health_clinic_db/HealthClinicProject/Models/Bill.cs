using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Models
{
    public sealed class Bill
    {
        public int BillId { get; set; }
        public int VisitId { get; set; }
        public DateTime BillDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentStatus { get; set; } = "UNPAID";
    }
}
