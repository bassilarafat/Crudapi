using Crudapi.Models;
using Crudapi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //CRUD
        [HttpGet]
        public ActionResult<List<Employee>> GetEmployee() => EmployeeService.GetEmployees();
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmploye(int id)
        {
            var emp = EmployeeService.GetEmployee(id);
            if (emp == null)
                return NotFound();
            return emp;
        }
        [HttpPost]
        public ActionResult CreateEmployee(Employee employee)
        {
            EmployeeService.Add(employee);
            return CreatedAtAction(nameof(CreateEmployee), new { id = employee.Id }, employee);     //to return 201 response code
        }

        [HttpPut]
        public ActionResult Update(Employee employee)
        {

            EmployeeService.Update(employee);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id )
        {
            var emp = EmployeeService.GetEmployee(id);
            if (emp is null)
                return NotFound();
            EmployeeService.Delete(id);
            return NoContent();
        }
        
        
    }
}
