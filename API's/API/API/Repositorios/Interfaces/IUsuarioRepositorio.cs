using API.Models;

namespace API.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarUsuarios();
        Task<UsuarioModel> BuscarUsuarioPorId(int id);

        Task<UsuarioModel> Adicionar(UsuarioModel usuario);

        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);

        Task<bool> Apagar(int id);
        
    }
}
