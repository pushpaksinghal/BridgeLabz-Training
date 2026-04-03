using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Models
{
    public sealed class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; } // date part used
        public TimeSpan AppointmentTime { get; set; }
        public string Status { get; set; } = "SCHEDULED";

        public override string ToString()
            => $"{AppointmentId} | P{PatientId} | D{DoctorId} | {AppointmentDate:yyyy-MM-dd} {AppointmentTime:hh\\:mm} | {Status}";
    }
}
