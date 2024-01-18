using API.Models;
using API.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : Controller
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;

        public TarefaController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }

        [HttpPost]
        public async Task<ActionResult<TarefaModel>> Cadastrar([FromBody]TarefaModel tarefaModel)
        {
            TarefaModel tarefa = await _tarefaRepositorio.AdicionarTarefa(tarefaModel);
            return Ok(tarefa);
        }

        [HttpGet]
        public async Task<ActionResult<List<TarefaModel>>> BuscarTarefas()
        {
            List<TarefaModel> tarefa = await _tarefaRepositorio.BuscarTarefas();
            return Ok(tarefa);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TarefaModel>> BuscarTarefaPorID(int id)
        {
            TarefaModel tarefa = await _tarefaRepositorio.BuscarTarefaPorID(id);
            return Ok(tarefa);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TarefaModel>> AtualizarTarefa([FromBody] TarefaModel tarefaModel, int id)
        {
            tarefaModel.ID = id;

            TarefaModel tarefa = await _tarefaRepositorio.AtualizarTarefa(tarefaModel, id);
            return Ok(tarefa);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeletarTarefa(int id)
        {
            bool apagado = await _tarefaRepositorio.DeletarTarefa(id);
            return Ok(apagado);
        }
    }
}
