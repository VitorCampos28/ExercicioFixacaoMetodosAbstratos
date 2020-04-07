using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoMetodosAbstratos.Entities
{
    class LegalPeople : People
    {
        public int NumberOfEmployee { get; set; }
        public LegalPeople()
        {

        }

        public LegalPeople(string name, double anualIncome , int numberOfEmployee) : base(name , anualIncome)
        {
            NumberOfEmployee = numberOfEmployee;
        }


        public override double Tax()
        {
            if (NumberOfEmployee > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
