using Lez04_09_PolimorfismoUniversita.Classes;

namespace Lez04_09_PolimorfismoUniversita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona studUno = new Studente("Giovanni", "Pace", "AB1234");
            Persona studDue = new Studente("Valeria", "Verdi", "AB1235");

            Persona docUno = new Docente("Mario", "Rossi", "Fisica", "Fisica");
            Persona docDue = new Docente("Maria", "Bianchi", "Ingegneria", "Matematica");

            Universita universita = new Universita()
            {
                Nome = "Dei Ciccioli"
            };

            universita.aggiungi(studUno);
            universita.aggiungi(studDue);
            universita.aggiungi(docUno);
            universita.aggiungi(docUno);

            universita.elencoStudenti();


        }
    }
}
