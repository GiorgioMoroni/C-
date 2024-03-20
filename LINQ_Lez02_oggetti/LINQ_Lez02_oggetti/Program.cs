using LINQ_Lez02_oggetti.Classes;

namespace LINQ_Lez02_oggetti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Studente> elenco = new List<Studente>()
            {
                new Studente() {Nominativo = "Giovanni Pace", Eta = 37, Matricola = "AB1234"},
                new Studente() {Nominativo = "Valeria Verdi", Eta = 35, Matricola = "AB1235"},
                new Studente() {Nominativo = "Marika Mariko", Eta = 34, Matricola = "AB1236"},

            };

            var risultato = from stud in elenco
                          where stud.Eta > 35
                          orderby stud.Eta
                          select stud;

            foreach(var stud in risultato)
            {
                Console.WriteLine($"{stud.Nominativo} {stud.Matricola} {stud.Eta}");
            }

            Console.WriteLine($"Età media: {elenco.Average(s => s.Eta)}");      // => Filtraggio Arrow

            //Se voglio ricercare un singolo elemento

            var studenteRicercato = elenco.FirstOrDefault(s => (s.Matricola is not null && s.Matricola.Equals("AB1235")));

            Console.WriteLine($"{studenteRicercato}");












        }
    }
}
