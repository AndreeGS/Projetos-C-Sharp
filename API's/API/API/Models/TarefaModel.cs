using API.Enums;

namespace API.Models
{
    public class TarefaModel
    {
        public int ID { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
    }
}
