using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_06_InfoHoldingIncapsulamento.Classes
{
    internal class Monopattino
    {
        public string? Marca { get; set; }
        public float VelMax { get; } = 24.0f;

        private int numPersone;

        public int NumPersone
        {
            get { return numPersone; }
            set
            {
                if (value >= 0)
                {
                    numPersone = value;
                }
                else
                {
                    Console.WriteLine("Errore");
                }
            }
        }





    }
}
