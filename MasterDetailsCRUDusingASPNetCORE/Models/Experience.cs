namespace MasterDetailsCRUDusingASPNetCORE.Models
{
    public class Experience
    {
        public int ExperienceId { get; set; }

        public int EmployeeId { get; set; }

        public string JobTitle { get; set; } = null!;
        public string InstitutionName { get; set; }=null!;

        public int Duration { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
