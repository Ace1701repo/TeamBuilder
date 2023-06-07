using System.ComponentModel.DataAnnotations;

namespace TeamBuilderAPI.Models
{
    public class Company : BaseEntity
    {
        [Required]
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }
        public List<Employee> Employees { get; set;}
        public List<Team> Teams { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public List<TeamBuilding> Buildings { get; set; }
    }
}
