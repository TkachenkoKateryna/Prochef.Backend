
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Prochef.Application.Interfaces;
using Prochef.Core.Entities;

namespace Prochef.WebApi.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService productService)
        {
            _menuService = productService;
        }

        [HttpGet("currentMenu")]
        public IActionResult GetMenu(int menuId)
        {
            return Json(_menuService.GetCurrentMenu(menuId));
        }
    }
}
