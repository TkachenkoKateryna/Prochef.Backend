
using Prochef.Core.Entities.Base;
using System.Collections.Generic;

namespace Prochef.Core.Entities
{
    public class Role : BaseEntity
    {
        public Role()
        {
            Employees = new List<Employee>();
        }

        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
