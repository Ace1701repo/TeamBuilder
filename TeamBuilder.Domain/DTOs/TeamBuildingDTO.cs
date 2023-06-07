using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilderAPI.DTOs;


namespace TeamBuilder.Domain.DTOs
{
    public class TeamBuildingDTO
    {
        public DateTime ActivityDate { get; set; }
        public string Description { get; set; }
        public Guid CompanyId { get; set; }
        public Guid EventCentreId { get; set; }
        public Guid RestaurantId { get; set; }        
    }
}
