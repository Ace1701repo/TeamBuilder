namespace TeamBuilderAPI.Models
{
    public class Team : BaseEntity
    {
        public string TeamName { get; set; }
        public List<Employee> Employees { get; set; }
        public Guid? CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
