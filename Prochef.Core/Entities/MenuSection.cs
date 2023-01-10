using Prochef.Core.Entities.Base;
using System.Collections.Generic;

namespace Prochef.Core.Entities
{
    public class MenuSection : BaseEntity
    {
        public MenuSection()
        {
            MenuItems = new List<MenuItem>();
        }

        public string  Name { get; set; }

        public int MenuId { get; set; }
        public Menu Menu { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
