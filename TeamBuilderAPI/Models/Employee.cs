using System.ComponentModel.DataAnnotations;

namespace TeamBuilderAPI.Models
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid? CompanyId { get; set; }
        public Company Company { get; set; }
        public Guid? TeamId { get; set; }
        public Team Team { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
