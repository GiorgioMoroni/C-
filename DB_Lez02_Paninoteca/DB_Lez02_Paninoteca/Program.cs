using DB_Lez02_Paninoteca.Models;

namespace DB_Lez02_Paninoteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un piccolo sistema di gestione paninoteca.
 
                Ogni panino è caratterizzato da:
                - Nome
                - Descrizione
                - Prezzo
                - Vegan (SI/NO)
 
                Creare una classe dedicata alla sola interazione con il Database.
 
                Al recupero di tutto il menu:
                - Lista di tutti i panini con relativi dettagli.
                - Visualizzare tutti i panini Vegan.
                - Contare tutti gli elementi presenti in menu.
                - Calcolare il prezzo medio dei panini.
             */


            GestisciPaninoteca gp = new GestisciPaninoteca("Mc Donald's");

            //gp.ElencoPanini();
            //Console.WriteLine();

            //gp.PaniniVegan();
            //Console.WriteLine();

            //gp.NumeroPanini();
            //Console.WriteLine();

            //gp.PrezzoMedio();

            bool risultato = gp.Insert(new Panino()
            {
                Nome = "DoubleCheesburger",
                Descrizione = "Doppio cheddar",
                Prezzo = 15.9M,
                IsVegan = false
            });

            List<Panino> panins = gp.FindAll();

            foreach(Panino p in panins)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            var paniniVegani = panins.Where(p => p.IsVegan == true);

            foreach(Panino p in paniniVegani)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(panins.Average(p => p.Prezzo));
            




        }
    }
}
