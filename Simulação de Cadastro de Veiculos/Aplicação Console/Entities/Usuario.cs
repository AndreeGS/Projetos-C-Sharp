using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_Console.Entities
{
    internal class Usuario
    {
        public string email {  get; set; }
        public string nome { get; set; }
        public string senha { get; set; }

        public Usuario() { }

        public Usuario(string email, string nome, string senha)
        {
            this.email = email;
            this.nome = nome;
            this.senha = senha;
        }

    }
}
