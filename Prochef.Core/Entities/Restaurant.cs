using Prochef.Core.Entities.Base;
using System.Collections.Generic;

namespace Prochef.Core.Entities
{
    public class Restaurant : BaseEntity
    {
        public Restaurant()
        {
            Employees = new List<Employee>();
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public int ChainId { get; set; }
        public Chain Chain { get; set; }

        public int MenuId { get; set; }
        public Menu Menu { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
