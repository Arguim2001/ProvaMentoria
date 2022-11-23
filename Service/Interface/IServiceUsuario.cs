﻿using ProvaMentoria.Model;

namespace ProvaMentoria.Service.Interface
{
    public interface IServiceUsuario
    {
        Task<List<Usuario>> GetUsuario();

        Task<bool> PostUsuario(Usuario usuario);

        Task<bool> PutUsuario(Usuario usuario);
        Task<bool> DeleteUsuario(int id);




    }
}
