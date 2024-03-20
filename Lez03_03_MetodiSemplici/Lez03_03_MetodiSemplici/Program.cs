namespace Lez03_03_MetodiSemplici
{
    internal class Program
    {
        static void saluta()
        {
            Console.WriteLine("Ciao");
        }

        static void salutaPersonalizzato(string nominativo)
        {
            Console.WriteLine($"Ciao {nominativo}, come stai?");
        }

        static void dettaglioStudente(string nome, string cognome, string? matricola)
        {
            if (matricola is null)
            {
                matricola = "Non definita";
            }
            Console.WriteLine($"Nome: {nome}\nCognome: {cognome}\nMatricola: {matricola}");
        }

        static int somma(int a, int b, int c)
        {
            int risultato = a + b + c;
            return risultato;
        }

        static void stampaArray(string[] array) 
        { 
            foreach(string s in array) 
            {
                Console.WriteLine(s);
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Ciao, Giovanni Pace, come stai?");
            //Console.WriteLine("Ciao, Mario Rossi, come stai?");
            //Console.WriteLine("Ciao, Valeria Verdi, come stai?");

            //saluta();
            //saluta();
            //saluta();

            //salutaPersonalizzato("Giovanni Pace");
            //salutaPersonalizzato("Mario Rossi");
            //salutaPersonalizzato("Valeria Verdi");

            dettaglioStudente("Giovanni", "Pace", "AB1234");
            dettaglioStudente("Valeria", "Verdi", null);

            int sommaDiNumeri = somma(43, 56, 12);
            Console.WriteLine(sommaDiNumeri);

            string[] parco = { "BMW", "Lamborghini", "Maserati", "FIAT" };
            stampaArray(parco);

            string[] invitati = { "Giovanni", "mario", "valeria", "Giorgio"};
            stampaArray(invitati); 

            










        }
    }
}
