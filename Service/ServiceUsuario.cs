using Microsoft.AspNetCore.Mvc;
using ProvaMentoria.Model;
using ProvaMentoria.Repository.DataBase.Interface;
using ProvaMentoria.Service.Interface;

namespace ProvaMentoria.Service
{
    public class ServiceUsuario : IServiceUsuario
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public ServiceUsuario(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<List<Usuario>> GetUsuario() => await _usuarioRepository.GetUsuario();

        public async Task<bool> PostUsuario(Usuario usuario)
        {
            var usuarios = await _usuarioRepository.GetUsuario();
            foreach (var user in usuarios)
            {
                if (usuario.Nome == user.Nome)

                    return false;
            }
            return await _usuarioRepository.PostUsuario(usuario);
        }
        public async Task<bool> PutUsuario(Usuario usuario) => await _usuarioRepository.PutUsuario(usuario);

        public async Task<bool> DeleteUsuario(int id) => await _usuarioRepository.DeleteUsuario(id);
    }
}
