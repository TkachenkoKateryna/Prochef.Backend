using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prochef.Application.Interfaces;

namespace Prochef.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public AdminController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeRole(int userId, int roleId)
        {

            return Ok();
        }

        public ActionResult GetUsers()
        {
            return Ok();
        }

        public ActionResult GetUser(string userId)
        {
            return Ok();
        }

        public ActionResult BanUser(int userId)
        {
            return Ok();
        }

    }
}
