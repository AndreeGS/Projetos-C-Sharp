
public class Aluno {
    public int id {get; set;}
    public string Nome {get; set;}
    public int idade {get; set;}
    public int serie {get; set;}
    public string escola {get; set;}

    public Aluno(int id, string nome, int idade, int serie, string escola){
        this.id = id;
        Nome = nome;
        this.idade = idade;
        this.serie = serie;
        this.escola = escola;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Aluno other = (Aluno)obj;

        return id == other.id && Nome == other.Nome && idade == other.idade;
    }

    public override int GetHashCode(){
        return HashCode.Combine(id, Nome, idade, escola);
    }
}