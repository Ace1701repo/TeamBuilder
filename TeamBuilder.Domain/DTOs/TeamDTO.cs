
using System.ComponentModel.DataAnnotations;

namespace TeamBuilderAPI.DTOs
{
    public class TeamDTO
    {
        [Required(ErrorMessage = "Team Name is mandatory")]
        public string TeamName { get; set; }
        
    }
}
