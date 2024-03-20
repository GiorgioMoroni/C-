using Lez04_02_TaskVeicoli.Classes;

namespace Lez04_02_TaskVeicoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema di gestione veicoli
             * 1. Auto
             * 2. Moto
             * 
             * Alla fine dell'inserimento delle caratteristiche del veicolo, stampare i dettagli.
             * 
             * Libera scelta degli attributi
             * 
             */

            Auto peugeot = new Auto("Peugeot", "106", "AB123CD", 10);
            Auto bmw = new Auto("BMW", "X5", "EF456GH", 15);
            Auto mercedes = new Auto("Mercedes", "Classe A", "IL789JK", 15);

            Moto yamaha = new Moto("Yamaha", "MT07", "MN123OP", 12);
            Moto honda = new Moto("Honda", "CBR", "QR456ST", 13);
            Moto ducati = new Moto("Ducati", "Multistrada", "UV789WZ", 14);

            Console.WriteLine("Seleziona tipo veicolo:");
            string? inputUtente = Console.ReadLine();
            

            try
            {
                int valoreConvertito = Convert.ToInt32(inputUtente);

                if (valoreConvertito == 1)
                {
                    Console.WriteLine("Hai scelto Auto, seleziona marca");
                    string? inputUtente2 = Console.ReadLine();
                    switch (inputUtente2)
                    {
                        case "peugeot":
                            peugeot.stampaDettaglio();
                            break;

                        case "bmw":
                            bmw.stampaDettaglio();
                            break;

                        case "mercedes":
                            mercedes.stampaDettaglio();
                            break;

                        default:
                            Console.WriteLine("Inserimento non valido");
                            break;


                    }
                }

                else if (valoreConvertito == 2)
                {
                    Console.WriteLine("Hai scelto Moto, seleziona marca");
                    string? inputUtente2 = Console.ReadLine();
                    switch (inputUtente2)
                    {
                        case "yamaha":
                            yamaha.stampaDettaglio();
                            break;

                        case "honda":
                            honda.stampaDettaglio();
                            break;

                        case "ducati":
                            ducati.stampaDettaglio();
                            break;

                        default:
                            Console.WriteLine("Inserimento non valido");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore: {ex.Message}");
            }

            
            












        }
    }
}
