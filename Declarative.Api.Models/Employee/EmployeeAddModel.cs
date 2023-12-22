namespace Declarative.Api.Models.Employee
{
    public class EmployeeAddModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public int ProjectId { get; set; }
    }
}
