using Finance_Helper.Models;

namespace Finance_Helper.Service.UsuarioService
{
    public interface IUsuarioInterface
    {
        Task<ServiceResponse<List<UsuarioModel>>> GetUsuarios();

        Task<ServiceResponse<List<UsuarioModel>>> Createusuario(UsuarioModel newUsuario);

        Task<ServiceResponse<UsuarioModel>> GetUsuariosById(int id);

        Task<ServiceResponse<List<UsuarioModel>>> UpdateUsusario(UsuarioModel editadoUsuario);

        Task<ServiceResponse<List<UsuarioModel>>> DeleteUsuario(int id);

        Task<ServiceResponse<object>> Login(string email, string password);

        Task<ServiceResponse<string>> RefreshToken(string refreshToken);
    }
}
