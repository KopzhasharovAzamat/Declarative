using Declarative.Api.Models.Project;
using Declarative.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Declarative.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService ?? throw new ArgumentNullException(nameof(projectService));
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProjectViewModel>> GetAll()
        {
            var projects = _projectService.GetAll();
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public ActionResult<ProjectViewModel> GetById(int id)
        {
            var project = _projectService.GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        [HttpPost]
        public ActionResult Create([FromBody] ProjectAddModel project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _projectService.Create(project);

            return CreatedAtAction(nameof(GetById), new { id = project.Id }, project);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] ProjectEditModel project)
        {
            if (!ModelState.IsValid || id != project.Id)
            {
                return BadRequest(ModelState);
            }

            var existingProject = _projectService.GetById(id);
            if (existingProject == null)
            {
                return NotFound();
            }

            _projectService.Update(project);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existingProject = _projectService.GetById(id);
            if (existingProject == null)
            {
                return NotFound();
            }

            _projectService.Delete(id);

            return NoContent();
        }
    }
}
