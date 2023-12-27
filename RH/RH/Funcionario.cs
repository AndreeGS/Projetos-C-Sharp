using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    internal class Funcionario : IComparable<Funcionario>
    {
        public string _nome;
        public double _salario;
        public int _id;

        public List<Funcionario> _lista = new List<Funcionario>();
        public Funcionario() { }
        public Funcionario(string nome, double salario, int id)
        {
            _id = id;
            _nome = nome;
            _salario = salario;
        }

      
        public void aumentarSalario(double valorAumento)
        {
            _salario += valorAumento;
        }

        public void reduzirSalario(double valorReducao)
        {
            _salario -= valorReducao;   
        }

        public void CalcularImpostoDeRenda(double Salario)
        {
            double imposto;

            if (Salario <= 1903.98)
            {
                imposto = 0;
            }
            else if (Salario <= 2826.65)
            {
                imposto = (Salario - 1903.98) * 0.075;
            }
            else if (Salario <= 3751.05)
            {
                imposto = (Salario - 2826.65) * 0.15;
            }
            else if (Salario <= 4664.68)
            {
                imposto = (Salario - 3751.05) * 0.225;
            }
            else
            {
                imposto = (Salario - 4664.68) * 0.275;
            }

            Console.WriteLine($"R$ {imposto}");
        }

        public int CompareTo(Funcionario funcionario1)
        {
            if (funcionario1 == null)
                return 1;

            return string.Compare(_nome, funcionario1._nome, StringComparison.Ordinal);
        }    
    }
}




