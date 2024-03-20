using Esercitazione03_20_03_2024.DAL;
using Esercitazione03_20_03_2024.Models;

namespace Esercitazione03_20_03_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Libro lib = new Libro()
            //{
            //    Id = 2,
            //    Titolo = "Il Codice Da Vinci",
            //    AnnoPubblicazione = new(2010, 01, 01),
            //    IsDisponibile = true
            //};
            //METODO INSERIMENTO LIBRO
            //Console.WriteLine(LibroDAL.getIstanza().Insert(lib));

            //METODO ELIMINAZIONE LIBRO
            //Console.WriteLine(LibroDAL.getIstanza().Delete(lib));

            //METODO GETALL
            //foreach (Libro l in LibroDAL.getIstanza().GetAll())
            //{
            //    Console.WriteLine(l);
            //}

            Console.WriteLine(LibroDAL.getIstanza().Get(2));

















        }


    }
}
