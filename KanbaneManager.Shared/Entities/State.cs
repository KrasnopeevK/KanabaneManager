using System.Collections.Generic;

namespace KanbaneManager.Shared.Entities
{
    public class State : IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }
}