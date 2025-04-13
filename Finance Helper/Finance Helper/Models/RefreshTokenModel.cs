namespace Finance_Helper.Models
{
    public class RefreshTokenModel
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Token { get; set; }
        public DateTime Expiracao { get; set; }
        public bool Revogado { get; set; }

        public UsuarioModel Usuario { get; set; }
    }

}
