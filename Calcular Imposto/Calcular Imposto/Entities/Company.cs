using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Imposto.Entities
{
    internal class Company : Person
    {
        public int numberEmployee { get; set; }

        public Company(string name, double income, int numberEmployee) : base(name, income)
        {
            this.numberEmployee = numberEmployee;
        }

        public override double taxCalculation()
        {           
            if (numberEmployee > 10)
            {
                return 0.14 * Income;
            }
            else
            {
                return 0.16 * Income;
            }       
        }       
    }
}
