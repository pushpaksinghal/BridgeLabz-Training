using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Models
{
    public sealed class Prescription
    {
        public int PrescriptionId { get; set; }
        public int VisitId { get; set; }
        public string MedicineName { get; set; } = "";
        public string Dosage { get; set; } = "";
        public int DurationDays { get; set; }
        public string? Instructions { get; set; }
    }
}
