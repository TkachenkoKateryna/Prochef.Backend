using System;
using Microsoft.AspNetCore.Mvc;
using Prochef.Application.Interfaces;
using Prochef.Core.Dtos.Request.Registration;
using Prochef.Core.Dtos.Response;

namespace Prochef.WebApi.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("employees/login")]
        public IActionResult Login(LoginEmployeeRequest loginRequest)
        {
            try
            {
                var response =  _employeeService.LoginEmployee(loginRequest);
                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("employees/register")]
        public  IActionResult Register(RegistrationEmployeeRequest customerRegisterRequest)
        {
            if (!ModelState.IsValid) return BadRequest();
            _employeeService.RegisterEmployee(customerRegisterRequest);
            return Ok();
        }
    }
}
