using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Excaption
{
    public sealed class NotFoundException:Exception
    {
        public NotFoundException(String message) : base(message) { }
    }
}
