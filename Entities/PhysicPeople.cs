using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoMetodosAbstratos.Entities
{
    class PhysicPeople : People
    {
        public double HealthExpenses { get; set; }

        public PhysicPeople()
        {

        }

        public PhysicPeople(string name, double anualIncome , double healthexpenses) : base(name , anualIncome)
        {
            HealthExpenses = healthexpenses;
        }

        public void PeopleTaxes()
        {
            if (AnualIncome < 20000.00)
            {
                Taxes += AnualIncome * 0.15;
            }
            else
            {
                Taxes += AnualIncome * 0.2;
            }
            
        }

        public double healthCost()
        {
            return Taxes -= HealthExpenses * 0.5;
        }
    }
}
