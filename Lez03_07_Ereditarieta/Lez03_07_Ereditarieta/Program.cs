using Lez03_07_Ereditarieta.Classes;

namespace Lez03_07_Ereditarieta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Giovanni", "Pace");
            persona.stampaDettaglio();

            Studente studente = new Studente("Valeria", "Verdi", "AB1234");
            studente.stampaDettaglio();

            Docente docente = new Docente()
            {
                Nome = "Emmete",
                Cognome = "Brown",
                Dipartimento = "Fisica applicata",
                Materia = "Fisica"
            };
            docente.stampaDettaglio();






        }
    }
}
