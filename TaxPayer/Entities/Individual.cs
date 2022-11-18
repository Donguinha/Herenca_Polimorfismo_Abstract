using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayer.Entities
{
    internal class Individual : Payer
    {
        public double healthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            :base(name, anualIncome)
        {
            this.healthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(anualIncome < 20000)
            {
                return (anualIncome * 0.15) - (healthExpenditures * 0.5);
            }
            else
            {
                return (anualIncome * 0.25) - (healthExpenditures * 0.5);
            }
        }
    }
}
