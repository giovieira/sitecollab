using System.ComponentModel.DataAnnotations;

namespace CollabBridge.Models
{
    public class DocumentosModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do documento")]
        public string Modulo { get; set; }
        [Required(ErrorMessage = "Digite o conteúdo do documento")]
        public string Conteudo { get; set; }
    }
}
