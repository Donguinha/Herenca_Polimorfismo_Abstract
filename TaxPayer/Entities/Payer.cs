using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayer.Entities
{
    abstract class Payer
    {
        public string name { get; set; }
        public double anualIncome { get; set; }

        protected Payer(string name, double anualIncome)
        {
            this.name = name;
            this.anualIncome = anualIncome;
        }

        public abstract Double Tax();
    }
}



