namespace Lez04_04_Utilizzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Indirizzo indirizzo = new Indirizzo()
            {
                Via = "Via le mani dal naso",
                Cap = "11111",
                Citta = "Farindola",
                Provincia = "CH"
            };


            Utente gio = new Utente()
            {
                Nominativo = "Givanni Pace",
                Spedizione = indirizzo
            };

            Utente fra = new Utente()
            {
                Nominativo = "Givanni Pace",
                Spedizione = new Indirizzo()
                                {
                                    Via = "Piazza la bomba",
                                    Cap = "22222",
                                    Citta = "Farindola",
                                    Provincia = "CH"
                                },
                Fatturazione = new Indirizzo
                {
                    Via = "Piazza re di roma",
                    Cap = "33333",
                    Citta = "Roma",
                    Provincia = "RM"
                }
            };

            Console.WriteLine(fra);









        }
    }
}
