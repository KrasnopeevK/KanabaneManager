using System.Collections.Generic;

namespace KanbaneManager.Shared.Entities
{
    public class TradePoint : IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<Order> Orders { get; set; }
    }
}