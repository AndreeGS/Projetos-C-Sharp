using API.Data;
using API.Models;
using API.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly SistemaTarefasDbContext _context;

        public TarefaRepositorio (SistemaTarefasDbContext sistemaTarefasDbContext)
        {
            _context = sistemaTarefasDbContext;
        }

        public async Task<TarefaModel>BuscarTarefaPorID(int id)
        {
            return await _context.Tarefas.FirstOrDefaultAsync(t => t.ID == id);
        }

        public async Task<List<TarefaModel>> BuscarTarefas()
        {
            return await _context.Tarefas.ToListAsync();
        }

        public async Task<TarefaModel> AdicionarTarefa(TarefaModel tarefa)
        {
            await _context.Tarefas.AddAsync(tarefa);
            await _context.SaveChangesAsync();

            return tarefa;
        }

        public async Task<TarefaModel> AtualizarTarefa(TarefaModel tarefa, int id)
        {
            TarefaModel tarefaPorID = await BuscarTarefaPorID(id);

            if (tarefaPorID == null)
            {
                throw new Exception($"A tarefa com o ID: {id}, não existe! ");
            }

            tarefaPorID.Nome = tarefa.Nome;
            tarefaPorID.Descricao = tarefa.Descricao;
            tarefaPorID.Status = tarefa.Status;

            _context.Tarefas.Update(tarefaPorID);
            await _context.SaveChangesAsync();
            
            return tarefaPorID;
        }

        public async Task<bool> DeletarTarefa(int id)
        {
            TarefaModel tarefaPorID = await BuscarTarefaPorID(id);

            if (tarefaPorID == null)
            {
                throw new Exception($"A tarefa com o ID: {id}, não existe! ");
            }

            _context.Tarefas.Remove(tarefaPorID);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
