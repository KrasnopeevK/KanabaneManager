using System.Collections.Generic;

namespace KanbaneManager.DL.Entities
{
    public class Department : IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}