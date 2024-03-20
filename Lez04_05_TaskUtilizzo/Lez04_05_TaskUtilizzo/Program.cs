using Lez04_05_TaskUtilizzo.Classes;

namespace Lez04_05_TaskUtilizzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema in grado di immagazzinare i dati relativi ad una persona.
             * Inoltre, sarà necessario immagazzinare, all'interno di una persona, i dati relativi a:
             * -Codice fiscale
             * |-Codice
             * |-Data d scadenza
             * 
             * -Carta di identita
             * |-Codice
             * |-Data di emissione
             * |-Data di scadenza
             * |-Emissione
             */

            Utente utente = new Utente()
            {
                Nome = "Giovanni",
                Cognome = "Pace",
                Identita = new CartaIdentita()
                            {
                                CodiceFisc = "PCAGNN",
                                DataScadenzaFisc = new DateTime(2027, 12, 01),
                                
                                DataEmissione = new DateTime(2024, 03, 24),
                                
                                Emissione = "Comune"
                            }
                //Fiscale = new CodiceFiscale()
                //{
                //    Codice = "PCAGNN",
                //    DataScadenza = "25/07/2027"
                //}
            };

            Console.WriteLine(utente);







        }
    }
}
