using System;
using System.Collections;
using System.Collections.Generic;

public enum ClassificacaoIMC
{
    AbaixoDoPeso,
    PesoNormal,
    Sobrepeso,
    ObesidadeGrau1,
    ObesidadeGrau2,
    ObesidadeGrau3
}

public struct IMC
{
    private double peso;
    private double altura;

    public IMC(double peso, double altura)
    {
        this.peso = peso;
        this.altura = altura;
    }

    public double CalcularIMC()
    {
        return peso / (altura * altura);
    }

    public ClassificacaoIMC ObterClassificacao()
    {
        double imc = CalcularIMC();

        if (imc < 18.5)
            return ClassificacaoIMC.AbaixoDoPeso;
        else if (imc < 24.9)
            return ClassificacaoIMC.PesoNormal;
        else if (imc < 29.9)
            return ClassificacaoIMC.Sobrepeso;
        else if (imc < 34.9)
            return ClassificacaoIMC.ObesidadeGrau1;
        else if (imc < 39.9)
            return ClassificacaoIMC.ObesidadeGrau2;
        else
            return ClassificacaoIMC.ObesidadeGrau3;
    }
}

public class Program
{
    private Hashtable historico = new Hashtable();

    public static void Main(string[] args)
    {
        Program programa = new Program();
        programa.ExecutarMenu();
    }

    public void ExecutarMenu()
    {
        int escolha;

        do
        {
            MostrarMenu();

            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    CalcularIMC();
                    break;

                case 2:
                    VisualizarHistorico();
                    break;
            }

        } while (escolha != 3);
    }

    private void MostrarMenu()
    {
        Console.WriteLine("\nO que você deseja fazer?");
        Console.WriteLine("1-Calcular IMC.");
        Console.WriteLine("2-Visualizar histórico.");
        Console.WriteLine("3-Sair.");
    }

    private void CalcularIMC()
    {
        Console.WriteLine("\nInforme sua altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nInforme seu Peso: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        IMC valor = new IMC(peso, altura);

        Console.WriteLine("\nSeu IMC é:");

        ClassificacaoIMC classificacao = valor.ObterClassificacao();
        Console.WriteLine($"\nIMC: {valor.CalcularIMC()}, Classificação: {classificacao}");

        int id = GerarID();
        AdicionarHistorico(id, valor);
    }

    private void AdicionarHistorico(int id, IMC valor)
    {
        historico.Add(id, valor);
    }

    private void VisualizarHistorico()
    {
        Console.WriteLine("\nSeu histórico: ");

        foreach (DictionaryEntry item in historico)
        {
            IMC value = (IMC)item.Value;
            ClassificacaoIMC classificacao = value.ObterClassificacao();

            Console.WriteLine($"\nID: {item.Key}, IMC: {value.CalcularIMC()}, Classificação: {classificacao}");
        }
    }

    private int GerarID()
    {
        Random n = new Random();
        return n.Next(10, 100);
    }
}
