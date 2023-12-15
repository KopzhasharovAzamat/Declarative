namespace Declarative.DAL.Entities
{
    public class ProjectTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public Employee Author { get; set; }
        //public int PerformerId { get; set; }
        //public Employee Performer { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int Priority { get; set; }
    }
}
