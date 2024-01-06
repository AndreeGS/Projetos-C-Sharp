using API.Data;
using API.Models;
using API.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTarefasDbContext _context;
        public UsuarioRepositorio(SistemaTarefasDbContext sistemaTarefasDbContext)
        {
            _context = sistemaTarefasDbContext;
        }
        public async Task<UsuarioModel> BuscarUsuarioPorId(int id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<List<UsuarioModel>> BuscarUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();

            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario para o ID:{id} não foi encontrado no banco de dados.");
            }

            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Email = usuario.Email;

            _context.Usuarios.Update(usuarioPorId);
            await _context.SaveChangesAsync();

            return usuarioPorId;

        }


        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario para o ID:{id} não foi encontrado no banco de dados.");
            }

            _context.Usuarios.Remove(usuarioPorId);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
