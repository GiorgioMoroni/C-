using Lez05_04_ProvaCSV.Classes;

namespace Lez05_04_ProvaCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona gio = new Persona("Giovanni", "Pace", "PCAGNN");
            Persona val = new Persona("Valeria", "Verdi", "VLRVRD");
            Persona mar = new Persona("Mario", "Rossi", "MRKMRK");

            string? path = "C:\\Users\\utente\\Desktop\\text.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(gio.esportaCsv());
                    sw.WriteLine(val.esportaCsv());
                    sw.WriteLine(mar.esportaCsv());

                    Console.WriteLine("Eseguito");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);   
            }
            








        }
    }
}
