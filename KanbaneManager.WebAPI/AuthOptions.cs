using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace KanbaneManager.WebAPI
{
    public class AuthOptions
    {
        public const string ISSUER = "MKWebApi"; 
        public const string AUDIENCE = "BlazorWASMClient"; 
        const string KEY = "GiveMyDiplomaAndBackOff";
        public const int LIFETIME = 80000;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}