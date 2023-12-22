namespace Declarative.Api.Models.Project
{
    public class ProjectAddModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProjectLeaderId { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public int CustomerCompanyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
