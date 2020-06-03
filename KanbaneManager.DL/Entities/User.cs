using System.ComponentModel.DataAnnotations.Schema;

namespace KanbaneManager.DL.Entities
{
    public class User : IIdentifier
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pwd { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}