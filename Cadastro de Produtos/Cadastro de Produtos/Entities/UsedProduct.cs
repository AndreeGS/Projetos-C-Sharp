using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cadastro_de_Produtos.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime manufacture {  get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufacture) : base (name, price)
        {
            this.manufacture = manufacture;
        }

        public override string priceTag()
        {
            return name
                 + " (used) $ "
                 + price.ToString("F2", CultureInfo.InvariantCulture)
                 + " (Manufacture date: "
                 + manufacture.ToString("dd/MM/yyyy")
                 + ")";
        }
    }
}
