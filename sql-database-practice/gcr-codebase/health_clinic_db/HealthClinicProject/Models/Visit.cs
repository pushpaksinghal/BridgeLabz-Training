using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Models
{
    public sealed class Visit
    {
        public int VisitId { get; set; }
        public int AppointmentId { get; set; }
        public string Diagnosis { get; set; } = "";
        public string? Notes { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
