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

        [Required]
        [Display(Name = "Active Status")]
        public bool IsActive { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly JoinDate { get; set; }

        [Display(Name = "Upload Image")]
        public IFormFile ImageFile { get; set; }

        [Required]
        public string ImageName { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Salary must be a positive number.")]
        [Display(Name = "Salary", Description = "The employee's salary.")]
        public int Salary { get; set; }

        public List<ExperienceViewModel> Experiences { get; set; }
    }
}
