using LINQ_Lez05_Task_Prodotti.Classes;

namespace LINQ_Lez05_Task_Prodotti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare una lista di prodotti caratterizzati da:
             * - Nome
             * - Descrizione
             * - Prezzo
             * _ Categoria
             * - Quantità
             * 
             * Inserire un numero n di prodotti e:
             * - Mandare in output tutti i prodotti di una certa categoria
             * - Calcolare il prezzo medio dei prodotti
             * - Riepilogre le quantità numeriche per categoria di prodotto
             * - Creare un report del valore del negozio calcolato come "quantità x prezzo" di ogni prodotto
             */

            List<Prodotto> elenco = new List<Prodotto>()
            {
                new Prodotto ("Mozzarella", "Bufala", 5.9f, "Alimentari", 10),
                new Prodotto("Formaggio", "Parma", 7.9f, "Alimentari", 12),
                new Prodotto("Penna", "Blu", 1.9f, "Cartoleria", 5),
                new Prodotto("Fogli", "Risma", 3.9f, "Cartoleria", 50),
                new Prodotto("Pane", "Rosetta", 54.9f, "Alimentari", 7),
                new Prodotto("Lavatrice", "Dyson", 50.9f, "Elettrodomestico", 3)
            };

            Console.WriteLine("----------------Primo Punto----------------");

            var risultato = from prod in elenco
                            where prod.Categoria.Equals("Alimentari")
                            group prod by prod.Categoria into categorie
                            select categorie;

            foreach(var item in risultato)
            {
                Console.WriteLine(item.Key);
                foreach(Prodotto p in item)
                {
                    Console.WriteLine(p.stampaProdotto());
                }
            }
            Console.WriteLine("----------------Primo Punto Compatto----------------");

            var risultato2 = elenco
                .Where(p => p.Categoria == "Alimentari")
                .Select(p => new {p.Nome, p.Prezzo});

            foreach(var item in risultato2)
            {
                Console.WriteLine($"{item.Nome} {item.Prezzo}");
            }
            Console.WriteLine();


            //------------------------------------------------------------------------------------
            Console.WriteLine($"Prezzo medio di: {elenco.Average(p => p.Prezzo)} euro");

            //------------------------------------------------------------------------------------

            var ris = from prod in elenco
                    group prod by prod.Categoria into categorie
                    select categorie;
            
            foreach(var item in ris)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Sum(p => p.Quantita));
            }

            //-----------------------------------------------------------------------------------

            var r = from prod in elenco
                    where prod.Quantita > 0
                    select new { q = prod.Quantita, p = prod.Prezzo };

            Console.WriteLine(r.Sum(t => t.q * t.p));








        }
    }
            









}