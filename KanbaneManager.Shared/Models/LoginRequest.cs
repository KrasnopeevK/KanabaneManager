using System.ComponentModel.DataAnnotations;

namespace KanbaneManager.BlazorApp.Models
{
    public class LoginRequest
    {
        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}