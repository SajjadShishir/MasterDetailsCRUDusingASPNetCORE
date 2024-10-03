using System.ComponentModel.DataAnnotations;

namespace MasterDetailsCRUDusingASPNetCORE.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            Experiences = new List<ExperienceViewModel>();
        }

        public int? EmployeeId { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "First name cannot exceed 20 characters.")]
        [Display(Name = "First Name", Description = "The employee's first name.")]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(20, ErrorMessage = "Last name cannot exceed 20 characters.")]
        [Display(Name = "Last Name", Description = "The employee's first name.")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Mobile number is required.")]
        [StringLength(15, ErrorMessage = "Mobile number cannot exceed 15 characters.")]
        [RegularExpression(@"^\+?[0-9]*$", ErrorMessage = "Mobile number must be numeric and can optionally start with a '+'.")]
        [Display(Name = "Mobile Number", Description = "The employee's mobile number.")]
        public string Mobile { get; set; } = null!;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        [Display(Name = "Email Address", Description = "The employee's email address.")]
        public string Email { get; set; } = null!;

        [Required]
        [Display(Name = "Active Status")]
        public bool IsActive { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime JoinDate { get; set; }

        [Display(Name = "Upload Image")]
        public IFormFile ImageFile { get; set; }
        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Salary must be a positive number.")]
        [Display(Name = "Salary", Description = "The employee's salary.")]
        public int Salary { get; set; }

        public List<ExperienceViewModel> Experiences { get; set; }
    }
}
