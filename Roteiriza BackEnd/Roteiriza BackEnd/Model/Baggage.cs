using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiriza_BackEnd.Model
{
    internal class Baggage
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string[] itens { get; set; }

        public override string ToString()
        {
            return "Titulo do checklist: "
                + Name
                + "Itens: "
                + itens;
        }
    }
}
