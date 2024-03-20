using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_06_InfoHoldingIncapsulamento.Classes
{
    internal class Bicicletta
    {

        public bool HasCampanello { get; set; } = false;
        public string? Marca { get; set; }
        public string? Tipo { get; set; }

        public Bicicletta() 
        {
            Console.WriteLine("Construttore di default invocato");
        }

        //Posso creare più costruttori, basta che cambio gli elementi nella parentesi
        public Bicicletta(string? marca, string? tipo, bool HasCampnello)
        {
            Marca = marca;
            Tipo = tipo;
            HasCampanello = HasCampnello;
            Console.WriteLine("Costruttore con 3 elementi");
        }

        public Bicicletta(bool HasCampnello, string? tipo)
        {
            Tipo = tipo;
            HasCampanello = HasCampnello;
            Console.WriteLine("Costruttore con 2 elementi");
        }









    }
}
