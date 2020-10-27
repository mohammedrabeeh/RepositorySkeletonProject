using System;
using System.ComponentModel.DataAnnotations;

namespace DB.Core.Models
{
    public class Employee : AuditableBaseEntity<int>
    {
        [Required][StringLength(10)]
        public string EmpCode { get; set; }
        [Required]
        [StringLength(100)]
        public string EmpName { get; set; }
     
    }
}
