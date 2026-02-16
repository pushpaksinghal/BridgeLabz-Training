using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Excaption
{
    public sealed class DataBaseOperationEception:Exception
    {
        public DataBaseOperationEception(string message, Exception inner) : base(message, inner) { }
    }
}
