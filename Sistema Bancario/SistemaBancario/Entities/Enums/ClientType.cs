using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Entities.Enums
{
    public enum ClientType
    {
        [Description("Conta empresárial")]
        Companny,
        [Description("Conta Individual")]
        Individual
    }
}
