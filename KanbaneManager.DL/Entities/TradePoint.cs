namespace KanbaneManager.DL.Entities
{
    public class TradePoint : IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}