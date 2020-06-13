using System.ComponentModel.DataAnnotations;

namespace KanbaneManager.Shared.Entities.AuthModels
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