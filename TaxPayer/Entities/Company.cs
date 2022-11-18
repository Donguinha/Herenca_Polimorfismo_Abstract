using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayer.Entities
{
    internal class Company : Payer
    {
        public int numberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            this.numberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (numberOfEmployees <= 10)
            {
                return anualIncome * 0.16;
            }
            else
            {
                return anualIncome * 0.14;
            }
        }
    }
}
