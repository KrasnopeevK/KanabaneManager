using System.Collections.Generic;

namespace KanbaneManager.Entity
{
    public class Role : IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}