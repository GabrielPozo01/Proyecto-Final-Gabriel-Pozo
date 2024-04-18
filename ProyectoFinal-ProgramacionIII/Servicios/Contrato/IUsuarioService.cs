using Microsoft.EntityFrameworkCore;
using ProyectoFinal_ProgramacionIII;
using ProyectoFinal_ProgramacionIII.Models;


namespace ProyectoFinal_ProgramacionIII.Servicios.Contrato
{
    public interface IUsuarioService
    {

        Task<Usuario> GetUsuario(string correo, string clave);

        Task<Usuario> SaveUsuario(Usuario modelo);

    }
}
