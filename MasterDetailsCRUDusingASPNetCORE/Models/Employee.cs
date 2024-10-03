namespace MasterDetailsCRUDusingASPNetCORE.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;
        public string Mobile { get; set; }
        public string Email { get; set; }

        public bool IsActive { get; set; }

        public DateTime JoinDate { get; set; }
        public string? ImageUrl { get; set; }

        public int Salary { get; set; }

        public virtual ICollection<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
