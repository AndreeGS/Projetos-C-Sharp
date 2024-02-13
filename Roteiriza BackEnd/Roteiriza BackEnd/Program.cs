using Microsoft.VisualBasic;
using Roteiriza_BackEnd.Model;
using System.ComponentModel.Design;
using System.Xml.Linq;

class Program
{
    public static void Main(string[] args)
    {
        int selecao;
        List<UserModel> users = new List<UserModel>();

        Console.WriteLine("Cadastrar usuarío ");

        do
        {

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Cadastrar Usuário");
            Console.WriteLine("2 - Visualizar Usuarios");
            selecao = int.Parse(Console.ReadLine());

            switch (selecao)
            {
                case 1:

                    Console.Write("\nInforme o id do Usuário: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("\nInforme o nome: ");
                    string name = Console.ReadLine();

                    Console.Write("\nInforme o password: ");
                    string password = Console.ReadLine();

                    Console.Write("\nInforme o email: ");
                    string email = Console.ReadLine();

                    Console.WriteLine("Deseja Cadastrar uma (1)Viagem, um (2)Card ou (3)Nenhum?");
                    int selecaoDoCadastro = int.Parse(Console.ReadLine());

                    if (selecaoDoCadastro == 1)
                    {
                        Console.Write("\nInforme o Id Da Viagem: ");
                        int idTravel = int.Parse(Console.ReadLine());

                        Console.Write("\n Informe o Nome da Viagem: ");
                        string nameTravel = Console.ReadLine();

                        Console.Write("\n Informe o Descrição da Viagem: ");
                        string descriptionTravel = Console.ReadLine();

                        Console.Write("\n Informe o Data inical da viagem: (DD/MM/YYYY) ");
                        DateTime dateInitial = DateTime.Parse(Console.ReadLine());

                        Console.Write("\n Informe o Data Final da viagem: (DD/MM/YYYY) ");
                        DateTime dateFinal = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("\n Deseja adicioanr um valor? 1-Sim 2-Não");
                        int valorSimNao = int.Parse(Console.ReadLine());
                        if (valorSimNao == 1)
                        {
                            Console.Write("Informe o id desse Valor: ");
                            int idValor = int.Parse(Console.ReadLine());

                            Console.Write("Informe o Titulo da despesa: ");
                            string nameValor = Console.ReadLine();

                            Console.Write("\n Informe o valor da viagem: ");
                            double valueTravel = double.Parse(Console.ReadLine());

                            users.Add(new UserModel(id, name, email, password, new TravelModel(idTravel, nameTravel, descriptionTravel, dateInitial, dateFinal, new Valor(idValor, valueTravel, nameValor))));
                            Console.WriteLine("\nUsuario Adicionado!");
                        }
                        else if (valorSimNao == 2)
                        {
                            users.Add(new UserModel(id, name, email, password, new TravelModel(idTravel, nameTravel, descriptionTravel, dateInitial, dateFinal)));
                            Console.WriteLine("\nUsuario Adicionado!");
                        }
                        else
                        {
                            Console.WriteLine("Seleção incorreta!");
                        }
                    }
                    else if (selecaoDoCadastro == 2)
                    {
                        users.Add(new UserModel(id, name, email, password));

                    }

                    else
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                    break;

                case 2:
                    foreach (UserModel user in users)
                    {
                        Console.WriteLine(user);
                    }
                    break;
            }
        } while (selecao != 3);
    }
}