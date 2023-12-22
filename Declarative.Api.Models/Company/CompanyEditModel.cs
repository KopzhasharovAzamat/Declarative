namespace Declarative.Api.Models.Company
{
    public class CompanyEditModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
    }
}
