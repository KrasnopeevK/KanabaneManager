namespace KanbaneManager.Shared.Entities.AuthModels
{
    public class LocalUserInfo
    {
        public string AccessToken { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public string Role { get; set; }
    }
}