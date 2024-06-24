using System.ComponentModel.DataAnnotations;

namespace GymManagement.Models
{
    public class LeaveApplication : ApprovalActivity
    {
        public int Id { get; set; }

        [Required]
        [Display (Name = "Employee Name")]
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        [Required]
        [Display(Name = "Number of Days")]
        public int NoOfDays { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Duration")]
        public int DurationId { get; set; }

        public SystemCodeDetail? Duration { get; set; }

        [Required]
        [Display(Name = "Leave Type")]
        public int LeaveTypeId { get; set; }

        public LeaveType? LeaveType { get; set; }

        public string? Attachment { get; set; }

        [Required]
        [Display(Name = "Notes")]

        public string? Description { get; set; }

        [Required]
        [Display(Name = "Status")]
        public int StatusId { get; set; }

        public SystemCodeDetail? Status { get; set; }
    }

}
