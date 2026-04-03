using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Models
{
    public sealed class PaymentTransaction
    {
        public long PaymentId { get; set; }
        public int BillId { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentMode { get; set; } = "";
        public DateTime PaidAt { get; set; }
        public string? ReferenceNo { get; set; }
    }
}
