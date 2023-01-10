
using System.Collections.Generic;

namespace Prochef.Core.Dtos.Response
{
    public class MenuResponse
    {
        public string Name { get; set; }

        public List<MenuItemResponse> MenuItems { get; set; }
    }
}
