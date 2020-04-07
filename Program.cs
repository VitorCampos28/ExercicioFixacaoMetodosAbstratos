using ExercicioFixacaoMetodosAbstratos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
         {
            List<People> list = new List<People>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (c == 'i')
                {
                    Console.Write("Health cost: ");
                    double healthCost = double.Parse(Console.ReadLine());
                    list.Add(new PhysicPeople(name, anualIncome, healthCost));
                    
                }

                else
                {
                    Console.Write("Number od employees; ");
                    int numberImployee = int.Parse(Console.ReadLine());
                    list.Add(new LegalPeople(name, anualIncome, numberImployee));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double Ttaxes = 0;
            foreach(People obj in list)
            {
                double tax = obj.Tax();
                Ttaxes += tax;
                Console.WriteLine(obj.Name + ": $ " + tax.ToString("F2",CultureInfo.InvariantCulture));
            }

            Console.Write("Total taxes: ");
            Console.WriteLine(Ttaxes.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
