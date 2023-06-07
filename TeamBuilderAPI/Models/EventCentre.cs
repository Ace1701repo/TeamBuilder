namespace TeamBuilderAPI.Models
{
    public class EventCentre : BaseEntity
    {
        public string CentreName { get; set; }
        public int Capacity { get; set; }
        public string Address { get; set; }
        public DateTime BookActivity { get; set; }
        public List<TeamBuilding> Buildings { get; set; }
        
    }
}
