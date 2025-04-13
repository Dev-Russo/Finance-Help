using System.ComponentModel.DataAnnotations;

namespace Finance_Helper.Models
{
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Telefone { get; set; }

        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();

    }
}
