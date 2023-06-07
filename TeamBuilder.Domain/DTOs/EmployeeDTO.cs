using System.ComponentModel.DataAnnotations;

namespace TeamBuilderAPI.DTOs
{
    public class EmployeeDTO
    {
        [Required(ErrorMessage = "First Name is mandatory")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is mandatory")]
        public string LastName { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "User Name is mandatory")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is mandatory")]
        public string Password { get; set; }
        public Guid? CompanyId { get; set; }

    }
}
