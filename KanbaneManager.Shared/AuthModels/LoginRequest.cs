using System.ComponentModel.DataAnnotations;

namespace KanbaneManager.Shared.Entities.AuthModels
{
    public class LoginRequest
    {
        [Required]
        [StringLength(50, MinimumLength=3, ErrorMessage = "Недопустимая длина имени")]
        public string Login { get; set; }

        [Required]
        [StringLength(50, MinimumLength=3, ErrorMessage = "Недопустимая длина пароля")]
        public string Password { get; set; }
    }
}