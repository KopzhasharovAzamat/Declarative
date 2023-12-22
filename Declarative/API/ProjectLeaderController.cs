using Microsoft.AspNetCore.Mvc;
using Declarative.Api.Models.ProjectLeader;
using Declarative.BLL.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Declarative.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectLeaderController : ControllerBase
    {
        private readonly IProjectLeaderService _projectLeaderService;

        public ProjectLeaderController(IProjectLeaderService projectLeaderService)
        {
            _projectLeaderService = projectLeaderService ?? throw new ArgumentNullException(nameof(projectLeaderService));
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProjectLeaderViewModel>> GetAll()
        {
            var projectLeaders = _projectLeaderService.GetAll();
            return Ok(projectLeaders);
        }

        [HttpGet("{id}")]
        public ActionResult<ProjectLeaderViewModel> GetById(int id)
        {
            var projectLeader = _projectLeaderService.GetById(id);

            if (projectLeader == null)
            {
                return NotFound();
            }

            return Ok(projectLeader);
        }

        [HttpPost]
        public ActionResult Create([FromBody] ProjectLeaderAddModel projectLeader)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _projectLeaderService.Create(projectLeader);

            return CreatedAtAction(nameof(GetById), new { id = projectLeader.Id }, projectLeader);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] ProjectLeaderEditModel projectLeader)
        {
            if (!ModelState.IsValid || id != projectLeader.Id)
            {
                return BadRequest(ModelState);
            }

            var existingProjectLeader = _projectLeaderService.GetById(id);
            if (existingProjectLeader == null)
            {
                return NotFound();
            }

            _projectLeaderService.Update(projectLeader);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existingProjectLeader = _projectLeaderService.GetById(id);
            if (existingProjectLeader == null)
            {
                return NotFound();
            }

            _projectLeaderService.Delete(id);

            return NoContent();
        }
    }
}
