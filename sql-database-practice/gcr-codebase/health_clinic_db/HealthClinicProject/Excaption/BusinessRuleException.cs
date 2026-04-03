using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Excaption
{
    public sealed class BusinessRuleException : healthClinicException
    {
        public BusinessRuleException(string message) : base(message) { }
    }
}
