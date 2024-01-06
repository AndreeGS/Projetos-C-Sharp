using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_Console.Entities
{
    class Veiculo
    {
        public string _modelo;
        public string _marca;
        public int _anoFabricacao;

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
}

