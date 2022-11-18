using System;
using System.Collections.Generic;
using TaxPayer.Entities;

namespace TaxPayer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> payers = ReceberDados();
            Mostrar(payers);
        }

        static List<Payer> ReceberDados()
        {
            List<Payer> payerslist = new List<Payer>();

            Console.Write("Tax payers: ");
            var payers = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < payers; i++)
            {
                Console.Write("Individual or company (i/c)? ");
                var type = char.Parse(Console.ReadLine());

                if (type == 'i')
                {
                    Console.Write($"Tax payer {i + 1}\nName: ");
                    var name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    var anualincome = double.Parse(Console.ReadLine());

                    Console.Write("Health Expenditures: ");
                    var health = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    payerslist.Add(new Individual(name, anualincome, health));
                }
                else
                {
                    Console.Write($"Tax payer {i + 1}\nName: ");
                    var name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    var anualincome = double.Parse(Console.ReadLine());

                    Console.Write("Number of employees: ");
                    var employees = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    payerslist.Add(new Company(name, anualincome, employees));
                }
            }
            return payerslist;
        }

        static void Mostrar(List<Payer> x)
        {
            var total = 0.0;
            foreach (Payer payer in x)
            {
                Console.WriteLine(payer.Tax());
                total += payer.Tax();
            }
            Console.WriteLine("TOTAL TAXES: " + total);
        }
    }
}