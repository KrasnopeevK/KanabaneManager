using System.ComponentModel.DataAnnotations.Schema;

namespace KanbaneManager.Entity
{
    public class Employee : IIdentifier
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}