using System.ComponentModel.DataAnnotations;

namespace TeamBuilderAPI.DTOs
{
    public class CompanyDTO
    {
        [Required(ErrorMessage = "Company Name is mandatory")]
        public string CompanyName { get; set; }
        
        [Required(ErrorMessage = "Number of employees in the company is mandatory")]
        public int NumberOfEmployees { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }

    }
}