using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Imposto.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Person(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double taxCalculation();

       
    }
}
