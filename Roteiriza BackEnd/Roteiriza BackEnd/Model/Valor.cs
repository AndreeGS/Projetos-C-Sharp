]using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiriza_BackEnd.Model
{
    public class Valor
    {
        public int id {  get; set; }
        public double valor { get; set; }
        public string name {  get; set; }

        public Valor(int id, double valor, string name)
        {
            this.id = id;
            this.valor = valor;
            this.name = name;
        }
    }
}
