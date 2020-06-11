using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace KanbaneManager.WebAPI.JWT
{
    public class AuthOptions
    {
        public const string ISSUER = "MKWebApi"; 
        public const string AUDIENCE = "BlazorWASMClient"; 
        const string KEY = "GiveMyDiplomaAndBackOff";
        public const int LIFETIME = 20;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }

    public class Token
    {
        public string Login { get; set; }
        public string Pwd { get; set; }
    }
}