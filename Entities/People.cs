using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoMetodosAbstratos.Entities
{
    abstract class People
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public People()
        {

        }
        public People(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

    }
}
