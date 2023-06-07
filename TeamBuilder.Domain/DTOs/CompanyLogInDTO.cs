using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilder.DTOs
{
    public class CompanyLogInDTO
    {
        [Required(ErrorMessage = "Company Name is mandatory")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Password is mandatory")]
        public string Password { get; set; }
    }
}
