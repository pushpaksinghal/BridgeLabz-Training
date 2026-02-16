using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Excaption
{
    public class healthClinicException:Exception
    {
        public healthClinicException(string message) : base(message) { }
        public healthClinicException(string message, Exception inner):base(message, inner) { }
    }
}
