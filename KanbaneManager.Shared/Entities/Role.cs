using System.Collections.Generic;

namespace KanbaneManager.Shared.Entities
{
    public class Role : IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}