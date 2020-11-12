
using Prochef.Infrastructure.Entities.Base;
using System.Collections.Generic;

namespace Prochef.Infrastructure.Entities
{
    public class Position : BaseEntity
    {
        public Position()
        {
            Employees = new List<Employee>();
        }

        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
