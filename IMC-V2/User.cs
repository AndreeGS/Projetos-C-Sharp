public class User
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }

    public User(int id, string nome, double altura, double peso)
    {
        Id = id;
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }

    public double CalcularIMC()
    {
        if (Altura <= 0)
        {
            throw new ArgumentException("Altura deve ser maior que zero.");
        }
        
        double altAux = Altura * Altura;
        return Peso / altAux;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode(); 
    }

    public override bool Equals(object? obj)
    {
        if (obj is User userInsert)
        {
            return this.Id == userInsert.Id &&
                   this.Nome == userInsert.Nome &&
                   Math.Abs(this.Altura - userInsert.Altura) < 0.01 &&
                   Math.Abs(this.Peso - userInsert.Peso) < 0.01;
        }
        return false;
    }
}
