using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Imposto.Entities
{
    internal class Individual : Person
    {
        public double expenseHealth { get; set; }

        public Individual(string name, double income, double expense) : base (name, income)
        {
            expenseHealth = expense;
        }

        public override double taxCalculation()
        {
            if (Income < 20000.00)
            {
                return 0.15 * Income - expenseHealth * 0.5;
            }

            else
            {
                return 0.25 * Income - expenseHealth * 0.5;
            }
        }
    }
}
