using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Core.Models
{
    public interface IAuditableEntity
    {
        string CreatedBy { get; set; }
        DateTime CreatedOn { get; set; }
        string ChangedBy { get; set; }
        DateTime? ChangedOn { get; set; }
    }
}
