using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Models
{
    public sealed class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; } = "";
        public string? Contact { get; set; }
        public decimal ConsultationFee { get; set; }
        public int SpecialtyId { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return $"{DoctorId} | {DoctorName} | Fee={ConsultationFee} | SpecId={SpecialtyId} | Active={IsActive}";
        }
            
    }
}
