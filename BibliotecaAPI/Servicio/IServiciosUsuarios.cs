using BibliotecaAPI.Entidades;
using Microsoft.AspNetCore.Identity;

namespace BibliotecaAPI.Servicio
{
    public interface IServiciosUsuarios
    {
        Task<Usuario?> ObtenerUsuario();
    }
}