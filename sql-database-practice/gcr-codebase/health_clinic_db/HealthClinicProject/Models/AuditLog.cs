using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Models
{
    public sealed class AuditLog
    {
        public long AuditId { get; set; }
        public string TableName { get; set; } = "";
        public string ActionType { get; set; } = "";
        public string RecordPk { get; set; } = "";
        public DateTime ChangedAt { get; set; }
        public string? ChangedBy { get; set; }
    }
}
