using LINQ_Lez03_group_by.Classes;

namespace LINQ_Lez03_group_by
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region GESTIONE new {}
            var stud = new { Nome = "Giovanni", Cognome = "Pace" };
            Console.WriteLine($"Nome = {stud.Nome} Cognome = {stud.Cognome}");
            Console.WriteLine(stud);
            //Console.WriteLine(typeof(stud));          //Non posso chiedere il suo tipo, non esiste essendo dichiarato var
            #endregion

            List<Libro> elenco = new List<Libro>()
            {
                new Libro("Libro A", "Autore 1", "Fantasy"),
                new Libro("Libro B", "Autore 2", "Sci-Fi"),
                new Libro("Libro C", "Autore 1", "Horror"),
                new Libro("Libro D", "Autore 3", "Fantasy"),
                new Libro("Libro E", "Autore 2", "Horror"),
            };

            #region GROUP BY, raggruppamento
            var risultato = from libro in elenco
                            //where libro.Genere.Equals("Fanstay")
                            group libro by libro.Genere into contenitoreGeneri
                            select contenitoreGeneri;


            foreach(var genere in risultato)
            {
                Console.WriteLine(genere.Key);

                foreach(Libro lib in genere)
                {
                    Console.WriteLine(lib.StampaLibro());
                }
            }
            #endregion

            #region SELEZIONE PARZIALE
            var ris = from libro in elenco
                            where libro.Autore.Equals("Autore 1")
                            select new {Titolo = libro.Titolo, Genere = libro.Genere};

            foreach(var item in ris)
            {
                Console.WriteLine($"{item.Titolo} {item.Genere}");
            }
            #endregion

            #region SELEZIONE CONDIZIONALE
            //var ris = condizione ? esito positivo : esito negativo
            //Esulta se è fantasy, altrimenti rimani deluso...
            var r = from libro in elenco
                    select libro.Genere.Equals("Fantasy") ? "Yuhuuuu è fantasy " + 
                    libro.Titolo : "Non è fantasy " + libro.Titolo;

            foreach( var item in r)
            {
                Console.WriteLine(item);
            }
            #endregion







        }
    }
}
