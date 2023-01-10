using System;
using System.Collections.Generic;
using System.Text;
using Prochef.Core.Dtos.Response;
using Prochef.Core.Entities;

namespace Prochef.Application.Interfaces
{
    public interface IMenuService
    {
        public MenuResponse GetCurrentMenu(int menuId);
    }
}
