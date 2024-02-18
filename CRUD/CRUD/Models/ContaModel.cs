namespace CRUD.Models
{
    public class ContaModel
    {
        public int Id { get; set; }
        public string nomeTitular { get; set; }
        public double saldoConta { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataExclusao { get; set; }

        public int IdUsuario { get; set; }
        public UsuarioModel Usuario { get; set; }
    }
}
