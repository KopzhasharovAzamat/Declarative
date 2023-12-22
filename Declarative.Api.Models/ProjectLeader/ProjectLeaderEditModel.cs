namespace Declarative.Api.Models.ProjectLeader
{
    public class ProjectLeaderEditModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Position { get; set; }
        public int ProjectId { get; set; }
    }
}
