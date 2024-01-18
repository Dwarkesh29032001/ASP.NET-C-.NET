using EventsPortal.Api.Dal;
using EventsPortal.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EventsPortal.Api.Controllers
{
    // URI - /api/Employees
    public class EmployeesController : ApiController
    {
        private readonly EmployeesDal _employeesDal;
        public EmployeesController(EmployeesDal employeesDal)
        {
            _employeesDal = employeesDal;
        }
        public List<Employee> Get()
        {
            return _employeesDal.GetAllEmployees();
        }
        public Employee Get(int id)
        {
            return _employeesDal.GetEmployeeDetails(id);
        }
        public void Post(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeesDal.InsertEmployee(employee);
            }
        }
    }
}
