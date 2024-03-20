using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_06_InfoHoldingIncapsulamento.Classes
{
    internal class Moto
    {
        private string modello = "N.D";
        private int cilindrata = 0;

        public void setCilindrata(int valCil)
        {
            if(valCil >= 0)
            {
                cilindrata = valCil;
            }
            else
            {
                Console.WriteLine("Errore, cilindrata non consentita");
            }
        }

        public int getCilindrata()
        {
            return cilindrata;
        }






    }
}
