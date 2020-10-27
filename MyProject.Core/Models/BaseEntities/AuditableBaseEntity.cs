using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DB.Core.Models
{
    public abstract class AuditableBaseEntity<TId> : BaseEntity<TId>, IAuditableEntity
    {
        [ScaffoldColumn(false)]
        [MaxLength(100)]
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedOn { get; set; }

        [ScaffoldColumn(false)]
        [MaxLength(100)]
        public string ChangedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? ChangedOn { get; set; }
    }
}
