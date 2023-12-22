using Microsoft.AspNetCore.Mvc;
using Declarative.Api.Models.Task;
using Declarative.BLL.Services.Interfaces;

namespace Declarative.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectTaskController : ControllerBase
    {
        private readonly IProjectTaskService _projectTaskService;

        public ProjectTaskController(IProjectTaskService projectTaskService)
        {
            _projectTaskService = projectTaskService ?? throw new ArgumentNullException(nameof(projectTaskService));
        }

        [HttpGet]
        public ActionResult<IEnumerable<TaskViewModel>> GetAll()
        {
            var projectTasks = _projectTaskService.GetAll();
            return Ok(projectTasks);
        }

        [HttpGet("{id}")]
        public ActionResult<TaskViewModel> GetById(int id)
        {
            var projectTask = _projectTaskService.GetById(id);

            if (projectTask == null)
            {
                return NotFound();
            }

            return Ok(projectTask);
        }

        [HttpPost]
        public ActionResult Create([FromBody] TaskAddModel projectTask)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _projectTaskService.Create(projectTask);

            return CreatedAtAction(nameof(GetById), new { id = projectTask.Id }, projectTask);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] TaskEditModel projectTask)
        {
            if (!ModelState.IsValid || id != projectTask.Id)
            {
                return BadRequest(ModelState);
            }

            var existingProjectTask = _projectTaskService.GetById(id);
            if (existingProjectTask == null)
            {
                return NotFound();
            }

            _projectTaskService.Update(projectTask);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existingProjectTask = _projectTaskService.GetById(id);
            if (existingProjectTask == null)
            {
                return NotFound();
            }

            _projectTaskService.Delete(id);

            return NoContent();
        }
    }
}
