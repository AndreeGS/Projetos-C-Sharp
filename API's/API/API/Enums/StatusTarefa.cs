using System.ComponentModel;

namespace API.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        Afazer ,
        [Description("Em andamento")]
        EmAndamento ,
        [Description("Concluido")]
        Concluido 
    }
}
