using Lez04_07_ContenitoriComplessi.Classes;
using System.ComponentModel;

namespace Lez04_07_ContenitoriComplessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elenco = new List<string>();
            elenco.Add("Maserati");
            elenco.Add("Lamborghini");
            elenco.Add("BMW");
            elenco.Add("FIAT");

            foreach (string s in elenco) 
            {
                Console.WriteLine(s);
                
            }


            List<Contatto> rubrica = new List<Contatto>();
            
            rubrica.Add(new Contatto()
            {
                Nome = "Giovanni",
                Cognome = "Pace",
                Telefono = "1234",
                Email = "gio.pace@blablabla.com"

            }); 
            
            rubrica.Add(new Contatto()
            {
                Nome = "Valeria",
                Cognome = "Verdi",
                Telefono = "5678",
                Email = "val.ver@blablabla.com"

            });

            rubrica.Add(new Contatto()
            {
                Nome = "Mario",
                Cognome = "Rossi",
                Telefono = "9101112",
                Email = "mar.ross@blablabla.com"

            });

            foreach (Contatto contatto in rubrica)
            {
                Console.Write(contatto);
            }





        }
    }
}
