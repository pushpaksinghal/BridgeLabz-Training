using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Excaption
{
    public sealed class UnauthorizedAppException : healthClinicException
    {
        public UnauthorizedAppException(string message) : base(message) { }
    }
}
