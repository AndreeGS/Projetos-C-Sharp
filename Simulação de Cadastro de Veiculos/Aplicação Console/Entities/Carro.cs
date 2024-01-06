using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_Console.Entities
{
    class Carro : Veiculo
    {
        public int _numeroPortas;

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
}

