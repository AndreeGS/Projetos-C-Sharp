using API.Models;

namespace API.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        Task<List<TarefaModel>> BuscarTarefas();
        Task <TarefaModel> BuscarTarefaPorID(int id);
        Task<TarefaModel> AdicionarTarefa(TarefaModel tarefa);
        Task<TarefaModel> AtualizarTarefa(TarefaModel tarefa, int id);
        Task<bool>DeletarTarefa(int id);
    }
}
