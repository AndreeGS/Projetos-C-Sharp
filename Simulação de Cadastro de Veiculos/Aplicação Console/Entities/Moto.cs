using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_Console.Entities
{
    class Moto : Veiculo
    {
        protected string _tipoMoto;

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
}
