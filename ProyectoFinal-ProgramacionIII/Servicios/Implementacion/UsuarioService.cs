using Microsoft.EntityFrameworkCore;
using ProyectoFinal_ProgramacionIII.Models;
using ProyectoFinal_ProgramacionIII.Servicios.Contrato;

namespace ProyectoFinal_ProgramacionIII.Servicios.Implementacion
{
    public class UsuarioService : IUsuarioService
    {

        private readonly DbfinalContext _dbContext;

        public UsuarioService(DbfinalContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Usuario> GetUsuario(string correo, string clave)
        {
            Usuario usuario_encontrado = await _dbContext.Usuarios.Where(u => u.Correo == correo && u.Clave == clave).FirstOrDefaultAsync();

            return usuario_encontrado;
        }

        public async Task<Usuario> SaveUsuario(Usuario modelo) 
        {
            _dbContext.Usuarios.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return modelo;
        }

    }
}
