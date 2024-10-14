
public class Materia{
    public int id {get; set;}
    public string nome {get; set;}
    public List<Aluno>? alunosMatriculados {get; set;}

    //Chave: Id do aluno, Valor: Nota do aluno
    public Dictionary<int, double>? notasAlunos {get; set;}

    public Materia(int id, string nome){
        this.id = id;
        this.nome = nome;
    }

    public double adicionaNota(int idAluno, double notaAluno){

        if(notasAlunos.ContainsKey(idAluno)){

            double notaAtual = notasAlunos[idAluno];
            notaAtual += notaAluno;

            return notaAtual;

        } else if (!notasAlunos.ContainsKey(idAluno)){
            notasAlunos.Add(idAluno, notaAluno);

            return notaAluno;
            
        } else{
            throw new Exception("Ocorreu um erro ao adicionar nota!");
        }    
    }

    public void adicionarAluno(Aluno novoAluno){

        if(alunosMatriculados == null){
            alunosMatriculados = new List<Aluno>(); 
        }
        
        try{
            alunosMatriculados.Add(novoAluno);
            Console.WriteLine($"\nAluno: {novoAluno.Nome} , id: {novoAluno.id} Adicionado com sucesso!");
        
        } catch(Exception ex){
            throw new Exception("O Aluno já está cadastrado!", ex);
        }   
    }
}