using CollabBridge.Enums;
using System.ComponentModel.DataAnnotations;

namespace CollabBridge.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do usuário")]
        public string Email { get; set;}
        [Required(ErrorMessage = "Digite o login do usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite a senha do usuário")]
        public string Password { get; set;}
        public PerfilEnum Perfil { get; set;}
        public bool SenhaValida(string senha)
        {
            return Password == senha;
        }

    }
}
