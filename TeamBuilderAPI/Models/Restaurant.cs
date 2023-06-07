namespace TeamBuilderAPI.Models
{
    public class Restaurant :BaseEntity
    {
        public string RestaurantName { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }
        public DateTime BookRestaurant { get; set; }
        public List<TeamBuilding> Buildings { get; set; }

    }
}
