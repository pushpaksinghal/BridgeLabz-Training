using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Models
{
    public sealed class Specialty
    {
        public int SpecialtyId { get; set; }
        public string SpecialtyName { get; set; } = "";
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return  $"{SpecialtyId} | {SpecialtyName} | Active={IsActive}";
        }
    }
}
