using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoMetodosAbstratos.Entities
{
    class PhysicPeople : People
    {
        public double HealthExpenses { get; set; }
        public double TaxesP { get; set; }
        public PhysicPeople()
        {

        }

        public PhysicPeople(string name, double anualIncome , double healthexpenses) : base(name , anualIncome)
        {
            HealthExpenses = healthexpenses;
        }


        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return AnualIncome * 0.15 - HealthExpenses * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenses * 0.5;
            }
        }
    }
}
