using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Excaption
{
    public sealed class ValidationException:Exception
    {

        public ValidationException(String message) : base(message) { }
    }
}
