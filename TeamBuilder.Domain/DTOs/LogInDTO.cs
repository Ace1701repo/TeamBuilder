using System.ComponentModel.DataAnnotations;

namespace TeamBuilderAPI.DTOs
{
    public class LogInDTO
    {
        [Required(ErrorMessage = "User Name is mandatory")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is mandatory")]
        public string Password { get; set; }
    }
}
