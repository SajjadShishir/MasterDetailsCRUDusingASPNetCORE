using System.ComponentModel.DataAnnotations;

namespace MasterDetailsCRUDusingASPNetCORE.Models.ViewModels
{
    public class ExperienceViewModel
    {
        [Required]
        [StringLength(30, ErrorMessage = "Title cannot exceed 30 characters.")]
        [Display(Name = "Designation ", Description = "Previous Job Desingnation")]
        public string JobTitle { get; set; } = null!;

        [Required]
        [StringLength(40, ErrorMessage = "Company name cannot exceed 40 characters.")]
        [Display(Name = "Company Name ", Description = "Previous Company Name ")]
        public string InstitutionName { get; set; } = null!;

        [Range(0, int.MaxValue, ErrorMessage = "Duration must be a positive number.")]
        public int Duration { get; set; }
    }
}
