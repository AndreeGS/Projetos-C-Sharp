
public class Menu {

    public Menu(){}
    public void execMenu(){
        Console.WriteLine( "\nQual ação você quer realizar: " +
                            "\n1 - Cadastrar" +
                            "\n2 - Visualizar" +
                            "\n3 - Atualizar" +
                            "\n4 - Apagar"+
                            "\n5 - Sair");
    }
    public void cadastroGeral(){
        Console.WriteLine("\nO que você quer cadastrar?" +
                            "\n1 - Aluno" +
                            "\n2 - Professor" +
                            "\n3 - Materia");
    }

    public void visualizarCad(){
        Console.WriteLine("\nO que você quer visualizar?" +
                            "\n1 - Aluno" +
                            "\n2 - Professor" +
                            "\n3 - Materia");
    }

    public void atualizarCad(){
        Console.WriteLine("\nO que você quer atualizar?" +
                            "\n1 - Aluno" +
                            "\n2 - Professor" +
                            "\n3 - Materia");
    }

    public void apagarCad(){
        Console.WriteLine("\nO que você quer apagar?" +
                            "\n1 - Aluno" +
                            "\n2 - Professor" +
                            "\n3 - Materia");
    }
}