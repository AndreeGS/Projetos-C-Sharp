using System;
using System.Collections;

class Veiculo
{
    private string _modelo;
    private string _marca;
    private int _anoFabricacao;

    public Veiculo(string modelo, string marca, int anoFabricacao)
    {
        _modelo = modelo;
        _marca = marca;
        _anoFabricacao = anoFabricacao;
    }

    public void Ligar()
    {
        Console.WriteLine("O veículo está ligado!");
    }

    public void Desligar()
    {
        Console.WriteLine("O veículo está desligado!");
    }
}

class Carro : Veiculo
{
    private int _numeroPortas;

    public Carro(string modelo, string marca, int anoFabricacao, int numeroPortas)
        : base(modelo, marca, anoFabricacao)
    {
        _numeroPortas = numeroPortas;
    }

    public void AbrirPortas()
    {
        Console.WriteLine("A porta está aberta!");
    }
}

class Moto : Veiculo
{
    private string _tipoMoto;

    public Moto(string modelo, string marca, int anoFabricacao, string tipoMoto)
        : base(modelo, marca, anoFabricacao)
    {
        _tipoMoto = tipoMoto;
    }

    public void Empinar()
    {
        Console.WriteLine("A moto está empinando!");
    }
}


class Program
{
    public static void Main(string[] args)
    {
        string[,] Carro = null;
        string[,] Moto = null;
        int opcao;

        do
        {

            Console.WriteLine("\nO que você deseja fazer?");
            Console.WriteLine("0 - Adicionar um veículo");
            Console.WriteLine("1 - Ligar carro");
            Console.WriteLine("2 - Abrir portas");
            Console.WriteLine("3 - Visualizar informações do carro");
            Console.WriteLine("4 - Ligar moto");
            Console.WriteLine("5 - Empinar moto");
            Console.WriteLine("6 - Visualizar informações da moto");
            Console.WriteLine("7 - Sair");

            opcao = Convert.ToInt32(Console.ReadLine());


            switch (opcao)
            {
                case 0:
                    Console.WriteLine("\nÉ uma moto (1) ou um carro (2)? ");
                    int tipoVeiculo = Convert.ToInt32(Console.ReadLine());

                    if (tipoVeiculo == 1)
                    {
                        Console.WriteLine("\nQuantas motos você quer adicionar? ");
                        int qtdMoto = Convert.ToInt32(Console.ReadLine());

                        Moto = new string[qtdMoto, 4];

                        for (int i = 0; i < qtdMoto; i++)
                        {

                            Console.WriteLine($"\nInsira as informações da moto {i + 1}:");
                            Console.Write("Modelo: ");
                            string modeloMoto = Console.ReadLine();

                            Console.Write("\nMarca: ");
                            string marcaMoto = Console.ReadLine();

                            Console.Write("\nAno de Fabricação: ");
                            int anoFabricacaoMoto = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nTipo de moto: ");
                            string tipoMoto = Console.ReadLine();

                            Moto[i, 0] = modeloMoto;
                            Moto[i, 1] = marcaMoto;
                            Moto[i, 2] = Convert.ToString(anoFabricacaoMoto);
                            Moto[i, 3] = tipoMoto;

                            Moto novaMoto = new Moto(modeloMoto, marcaMoto, anoFabricacaoMoto, tipoMoto);
                        }
                    }

                    else if (tipoVeiculo == 2)
                    {
                        Console.WriteLine("\nQuantos carros você quer adicionar? ");
                        int qtdCarro = Convert.ToInt32(Console.ReadLine());

                        Carro = new string[qtdCarro, 4];

                        for (int i = 0; i < qtdCarro; i++)
                        {


                            Console.WriteLine("\nInsira as informações do carro:");
                            Console.Write("Modelo: ");
                            string modeloCarro = Console.ReadLine();

                            Console.Write("Marca: ");
                            string marcaCarro = Console.ReadLine();

                            Console.Write("Ano de Fabricação: ");
                            int anoFabricacaoCarro = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Numero de portas: ");
                            int numeroPortas = Convert.ToInt32(Console.ReadLine());

                            Carro[i, 0] = modeloCarro;
                            Carro[i, 1] = marcaCarro;
                            Carro[i, 2] = Convert.ToString(anoFabricacaoCarro);
                            Carro[i, 3] = Convert.ToString(numeroPortas);

                            Carro novoCarro = new Carro(modeloCarro, marcaCarro, anoFabricacaoCarro, numeroPortas);
                        }
                    }

                    else
                    {
                        Console.WriteLine("\nOpção inválida!");
                    }
                    break;

                case 1:

                    if (Carro != null && Carro.GetLength(0) > 0)
                    {
                        Console.WriteLine($"\nQual carro você quer ligar?\n Quantidade de carros disponíveis: {Carro.GetLength(0)} ");

                        int selecaoCarro = Convert.ToInt32(Console.ReadLine());

                        if (selecaoCarro > Carro.GetLength(0))
                        {
                            Console.WriteLine("\nNão existe esse carro!");
                        }

                        else
                        {
                            Console.WriteLine("\nLigando carro {0}...", selecaoCarro);


                            Carro car = new Carro(Carro[selecaoCarro, 0], Carro[selecaoCarro, 1], Convert.ToInt32(Carro[selecaoCarro, 2]), Convert.ToInt32(Carro[selecaoCarro, 3]));
                            car.Ligar();
                        }
                    }

                    else
                    {
                        Console.WriteLine("\nNenhum carro adicionado ainda.");
                    }

                    break;

                case 2:

                    if (Carro != null && Carro.GetLength(0) > 0)
                    {
                        Console.WriteLine($"\nQual carro você quer abrir portas?\n Quantidade de carros disponíveis: {Carro.GetLength(0)} ");
                        int selecaoCarro = Convert.ToInt32(Console.ReadLine());

                        if (selecaoCarro > Carro.GetLength(0))
                        {
                            Console.WriteLine("\nNão existe esse carro! ");
                        }

                        else
                        {
                            Console.WriteLine("\nAbrindo portas do carro...");


                            Carro car = new Carro(Carro[selecaoCarro, 0], Carro[selecaoCarro, 1], Convert.ToInt32(Carro[selecaoCarro, 2]), Convert.ToInt32(Carro[selecaoCarro, 3]));
                            car.AbrirPortas();
                        }
                    }

                    else
                    {
                        Console.WriteLine("\nNenhum carro adicionado ainda.");
                    }
                    break;

                case 3:
                    if (Carro != null && Carro.GetLength(0) > 0)
                    {
                        Console.WriteLine($"\nQual carro você quer visualizar?\n Quantidade de carros disponíveis: {Carro.GetLength(0)} ");
                        int selecaoCarro = Convert.ToInt32(Console.ReadLine());

                        if (selecaoCarro > Carro.GetLength(0))
                        {
                            Console.WriteLine("\nNão existe esse carro! ");

                        }
                        else
                        {

                            Console.WriteLine("\nVisualizando informações do carro {0}: ", selecaoCarro);

                            for (int i = 0; i < Carro.GetLength(0); i++)
                            {
                                Console.WriteLine($"Modelo carro {i + 1}:");
                                Console.WriteLine($"Modelo: {Carro[selecaoCarro, 0]}");
                                Console.WriteLine($"Marca: {Carro[selecaoCarro, 1]}");
                                Console.WriteLine($"Ano de Fabricação: {Carro[selecaoCarro, 2]}");
                                Console.WriteLine($"Tipo de Moto: {Carro[selecaoCarro, 3]}\n");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNenhum carro adicionado ainda.");
                    }

                    break;

                case 4:
                    if (Moto != null && Moto.GetLength(0) > 0)
                    {
                        Console.WriteLine($"\nQual mmoto você quer ligar?\n Quantidade de carros disponíveis: {Moto.GetLength(0)} ");
                        int selecaoMoto = Convert.ToInt32(Console.ReadLine());

                        if (selecaoMoto > Moto.GetLength(0))
                        {
                            Console.WriteLine("\nNão existe essa Moto! ");
                        }
                        else
                        {
                            Console.WriteLine("\nLigando moto...");

                            Moto mot = new Moto(Moto[selecaoMoto, 0], Moto[selecaoMoto, 1], Convert.ToInt32(Moto[selecaoMoto, 2]), Moto[selecaoMoto, 3]);
                            mot.Ligar();
                        }
                    }

                    else
                    {
                        Console.WriteLine("\nNenhuma moto adicionada ainda.");
                    }


                    break;

                case 5:
                    if (Moto != null && Moto.GetLength(0) > 0)
                    {
                        Console.WriteLine($"\nQual mmoto você quer empinar?\n Quantidade de carros disponíveis: {Moto.GetLength(0)} ");
                        int selecaoMoto = Convert.ToInt32(Console.ReadLine());

                        if (selecaoMoto > Moto.GetLength(0))
                        {
                            Console.WriteLine("\nNão existe essa Moto! ");
                        }

                        else
                        {
                            Console.WriteLine("\nEnpinando moto...");


                            Moto mot = new Moto(Moto[selecaoMoto, 0], Moto[selecaoMoto, 1], Convert.ToInt32(Moto[selecaoMoto, 2]), Moto[selecaoMoto, 3]);
                            mot.Empinar();
                        }
                    }

                    else
                    {
                        Console.WriteLine("\nNenhuma moto adicionada ainda.");
                    }

                    break;

                case 6:
                    if (Moto != null && Moto.GetLength(0) > 0)
                    {
                        Console.WriteLine($"\nQual moto você quer visualizar?\n Quantidade de motos disponíveis: {Moto.GetLength(0)} ");
                        int selecaoMoto = Convert.ToInt32(Console.ReadLine());

                        if (selecaoMoto > Moto.GetLength(0))
                        {
                            Console.WriteLine("\nNão existe essa moto! ");

                        }
                        else
                        {
                            Console.WriteLine("\nVisualizando informações da moto: ");

                           
                                Console.WriteLine($"Modelo moto {selecaoMoto + 1}:");
                                Console.WriteLine($"Modelo: {Moto[selecaoMoto, 0]}");
                                Console.WriteLine($"Marca: {Moto[selecaoMoto, 1]}");
                                Console.WriteLine($"Ano de Fabricação: {Moto[selecaoMoto, 2]}");
                                Console.WriteLine($"Tipo de Moto: {Moto[selecaoMoto, 3]}\n");
                            
                        }
                    }

                    else
                    {
                        Console.WriteLine("\nNenhuma moto adicionada ainda.");
                    }

                    break;

                default:
                    if (opcao != 7)
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                    break;
            }
        } while (opcao != 7);
    }
}
