using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static Random random = new Random(); 
    public static void Main(string[] args)
    {
        int selecao;
        List<User> usuarios = new List<User>();
        Console.WriteLine("Calculadora de IMC");
        do
        {
            selecao = ExibirMenu();
            try
            {
                switch (selecao)
                {
                    case 1:
                        CadastrarUsuario(usuarios);
                        break;

                    case 2:
                        CalcularIMC(usuarios);
                        break;

                    case 3:
                        AtualizarUsuario(usuarios);
                        break;

                    case 4:
                        DeletarUsuario(usuarios);
                        break;

                    case 5:
                        VisualizarUsuarios(usuarios);
                        break;

                    case 6:
                        Console.WriteLine("Saindo da Aplicação.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

        } while (selecao != 6);
    }

    private static int ExibirMenu()
    {
        Console.WriteLine("\nO que você deseja fazer? ");
        Console.WriteLine("1 - Cadastrar um novo Usuário");
        Console.WriteLine("2 - Calcular o IMC de um Usuário");
        Console.WriteLine("3 - Atualizar Informações de um Usuário");
        Console.WriteLine("4 - Deletar um Usuário");
        Console.WriteLine("5 - Visualizar usuários cadastrados");
        Console.WriteLine("6 - Sair");

        return int.Parse(Console.ReadLine() ?? "0");
    }

    private static void CadastrarUsuario(List<User> usuarios)
    {
        int id = gerarId();
        Console.Write("\n- Informe o nome do usuário: ");
        string nome = Console.ReadLine();
        Console.Write("\n- Informe a altura do usuário (em metros): ");
        double altura = double.Parse(Console.ReadLine());
        Console.Write("\n- Informe o peso do usuário (em kg): ");
        double peso = double.Parse(Console.ReadLine());

        usuarios.Add(new User(id, nome, altura, peso));
        Console.WriteLine($"\n- ID atribuído: {id}");
        Console.WriteLine("\n- Usuário Inserido com Sucesso!");
    }

    private static void CalcularIMC(List<User> usuarios)
    {
        Console.WriteLine("Informe o ID do Usuário: ");
        int idUsuario = int.Parse(Console.ReadLine() ?? "0");

        var usuario = usuarios.FirstOrDefault(u => u.Id == idUsuario);
        if (usuario != null)
        {
            double imc = usuario.CalcularIMC();
            Console.WriteLine($"O IMC para o ID {idUsuario} é: {imc:f2}");
        }
        else
        {
            Console.WriteLine("Usuário não encontrado.");
        }
    }

    private static void AtualizarUsuario(List<User> usuarios)
    {
        Console.WriteLine("Informe o ID do Usuário: ");
        int idUsuario = int.Parse(Console.ReadLine() ?? "0");

        var usuario = usuarios.FirstOrDefault(u => u.Id == idUsuario);
        if (usuario != null)
        {
            
        }
        else
        {
            Console.WriteLine("Usuário não encontrado.");
        }
    }

    private static void DeletarUsuario(List<User> usuarios)
    {
        Console.WriteLine("Informe o ID do Usuário: ");
        int idUsuario = int.Parse(Console.ReadLine() ?? "0");

        var usuario = usuarios.FirstOrDefault(u => u.Id == idUsuario);
        if (usuario != null)
        {
            usuarios.Remove(usuario);
            Console.WriteLine("Usuário deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Usuário não encontrado para remoção.");
        }
    }

    private static void VisualizarUsuarios(List<User> usuarios)
    {
        if (!usuarios.Any())
        {
            Console.WriteLine("Nenhum usuário na lista.");
            return;
        }

        for (int i = 0; i < usuarios.Count; i++)
        {
            User user = usuarios[i];
            Console.WriteLine($"Usuário #{i + 1}:");
            Console.WriteLine($"  ID: {user.Id}");
            Console.WriteLine($"  Nome: {user.Nome}");
            Console.WriteLine($"  Altura: {user.Altura:F2} metros");
            Console.WriteLine($"  Peso: {user.Peso:F2} kg");
            Console.WriteLine();
        }
    }

    private static int gerarId()
    {
        return random.Next(0, 500);
    }
}
