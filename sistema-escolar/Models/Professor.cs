
public class Professor{
    public int id {get; set;}
    public string nome {get; set;}
    public string escola {get; set;}

    public List<Materia>? Materias{get; set;}

    public Professor(int id, string nome, string escola){
        this.id = id;
        this.nome = nome;
        this.escola = escola;
    }

    public void adicionarMateria(Materia novaMateria){
        
        if(Materias == null){
            Materias = new List<Materia>();
        }
        try{
            Materias.Add(novaMateria);
            Console.WriteLine($"\nMatéria: {novaMateria.nome}, cadastrada!");
        
        } catch(Exception ex){
            throw new Exception("Erro ao adicionar matéria!", ex);
        }
    }
}