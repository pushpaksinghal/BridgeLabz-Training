using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Models
{
    public sealed class BillItem
    {
        public int ItemId { get; set; }
        public int BillId { get; set; }
        public string ItemName { get; set; } = "";
        public decimal Amount { get; set; }
    }
}
