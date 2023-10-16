using System.ComponentModel.DataAnnotations;

namespace CollabBridge.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Informe o usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Informe a senha")]
        public string Senha { get; set; }
    }
}
