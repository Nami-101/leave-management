using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LeaveManagementSystemCore.Models
{
    public class LeaveRequest
    {
        public int Id { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string LeaveType { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public string Reason { get; set; }

        public string Status { get; set; } = "Pending";

        [BindNever]
        [Display(Name = "User Id")]
        public string? UserId { get; set; }  // Make it nullable just to avoid default validation

        [BindNever]
        public virtual ApplicationUser? User { get; set; } // Nullable
    }
}
