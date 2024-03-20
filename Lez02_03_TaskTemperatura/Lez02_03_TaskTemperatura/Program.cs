namespace Lez02_03_TaskTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema di controllo accessi al ristorante, in input (sotto forma di variabile) ci sarà la temperatura.
             * 
             * Se la temperatura è maggiore o uguale a 37.5 allora non permette l'ingresso al ristorante.
             * 
             * Attenzione <35° problema e > 42 problema
             */
            Console.WriteLine("Iserisci temperatura");
            string? temperatura = Console.ReadLine();

            try
            {
                double tempConvertita = Convert.ToDouble(temperatura);
                if (tempConvertita >= 35.0 && tempConvertita <= 42.0)
                {
                    if (tempConvertita < 37.5)
                    {
                        Console.WriteLine($"La temperatura è di: {tempConvertita}°C. Accesso consentito");
                    }
                    else
                    {
                        Console.WriteLine("Non puoi entrare");
                    }
                }
                else
                {
                    Console.WriteLine("Errore di validazione");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore: {ex.Message}");
            }
            









        }
    }
}
