using System;
using System.Collections.Generic;
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

        public void CompanyTaxes()
        {
            if (NumberOfEmployee > 10)
            {
                Taxes = AnualIncome * 0.14;
            }
            else
            {
                Taxes = AnualIncome * 0.16;
            }

        }


    }
}
