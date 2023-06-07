namespace TeamBuilderAPI.Models
{
    public class TeamBuilding : BaseEntity
    {
        public DateTime ActivityDate { get; set; }
        public string Description { get; set; }
        public EventCentre EventCentre { get; set; }
        public Restaurant Restaurant { get; set; }
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }
        public Guid EventCentreId { get; set; }
        public Guid RestaurantId { get; set; }
    }
}
