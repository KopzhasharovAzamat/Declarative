using Declarative.Api.Models.Employee;
using Declarative.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Declarative.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
        }

        [HttpGet]
        public ActionResult<IEnumerable<EmployeeViewModel>> GetAll()
        {
            var employees = _employeeService.GetAll();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult<EmployeeViewModel> GetById(int id)
        {
            var employee = _employeeService.GetById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPost]
        public ActionResult Create([FromBody] EmployeeAddModel employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _employeeService.Create(employee);

            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] EmployeeEditModel employee)
        {
            if (!ModelState.IsValid || id != employee.Id)
            {
                return BadRequest(ModelState);
            }

            var existingEmployee = _employeeService.GetById(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }

            _employeeService.Update(employee);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existingEmployee = _employeeService.GetById(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }

            _employeeService.Delete(id);

            return NoContent();
        }
    }
}
