using System.Collections.Generic;

namespace KanbaneManager.Shared.Entities
{
    public class Department : IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}