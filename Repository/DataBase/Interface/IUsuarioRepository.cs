using ProvaMentoria.Model;

namespace ProvaMentoria.Repository.DataBase.Interface
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetUsuario();
        Task<bool> PostUsuario(Usuario usuario);

        Task<bool> PutUsuario(Usuario usuario);
        Task<bool> DeleteUsuario(int id);
    }
}
