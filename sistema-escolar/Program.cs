
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.Arm;

public class Program {
    public static void Main (string [] args){

        int selecao, selecaoAux = 0;

        List<Professor> professores = new List<Professor>();
       
        Console.WriteLine("Bem vindo ao Sistema Escolar");

        do{
            Menu mn = new Menu();
            mn.execMenu();

            selecao = int.Parse(Console.ReadLine());

            switch(selecao){
                
                case 1:
                    mn.cadastroGeral();
                    selecaoAux = int.Parse(Console.ReadLine());

                    if(selecaoAux == 2){
                        
                        Console.Write("\n Informe o Id do professor: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("\n Informe o nome do Professor: ");
                        string nome = Console.ReadLine();
                        Console.Write("\n Informe o nome da Escola: ");
                        string escola = Console.ReadLine();

                        professores.Add(new Professor(id, nome, escola));
                    }

                break;
                case 2:
                    mn.visualizarCad();
                    selecaoAux = int.Parse(Console.ReadLine());

                    if(selecaoAux == 2){
                       Console.WriteLine("Qual o Id do Professor você quer visualizar?"); 
                       int id = int.Parse(Console.ReadLine());

                       Professor professorEncontrado = null;
                       foreach(Professor prof in professores){
                            if (prof.id == id){
                                professorEncontrado = prof;
                                break;
                            }
                       }
                       if(professorEncontrado != null){
                            Console.WriteLine($"Nome: {professorEncontrado.nome}, Escola: {professorEncontrado.escola}");
                       }
                       else{
                            Console.WriteLine($"Id: {id} não encontrado!");
                       }
                    }

                break;
                case 3:
                    mn.atualizarCad();
                    selecaoAux = int.Parse(Console.ReadLine());
                break;
                case 4:
                    mn.apagarCad();
                    selecaoAux = int.Parse(Console.ReadLine());                
                break;
                case 5:
                    Console.WriteLine("Saindo do sistema...");
                break;
            }
        } while(selecao != 5);
    }
}