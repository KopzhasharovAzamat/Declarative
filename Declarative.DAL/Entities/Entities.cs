namespace Declarative.DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string position { get; set; }
    }

    public class ProjectTask
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Employee author { get; set; }
        public Employee performer { get; set; }
        public int status { get; set; }
        public string comment { get; set; }
        public DateTime created { get; set; }
        public int priority { get; set; }
    }

    public class Project
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Employee leader { get; set; }
        public int priority { get; set; }
        public int status { get; set; }
        public Company customerCompany { get; set; }
        public Company performerCompany { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
    public class ProjectLeader
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string position { get; set; }
        public Project project { get; set; }
    }
    public class Company
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Employee employee { get; set; }
        public Project project { get; set; }
    }
}
