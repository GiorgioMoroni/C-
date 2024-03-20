namespace Lez02_05_ControlliCompessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input utente inserisci i dati della tua provincia per conoscere a cosa corrisponde la sigla
            string provincia = "BO";

            if (provincia.Equals("AQ"))
            {
                Console.WriteLine("L'aquila");
            }
            else
            {
                if (provincia.Equals("PE"))
                {
                    Console.WriteLine("Pescara");
                }
                else
                {
                    if (provincia.Equals("BO"))
                    {
                        Console.WriteLine("Bologna");
                    }
                    else
                    {
                        Console.WriteLine("Non trovato");
                    }
                }
            }

            //--------------------------------------------------------------

            //Switch
            switch (provincia)
            {
                case "AQ":
                    Console.WriteLine("L'aquila");
                    break;

                case "PE":
                    Console.WriteLine("Pescara");
                    break;

                case "BO":
                    Console.WriteLine("Bologna");
                    break;

                default:
                    Console.WriteLine("Non trovato");
                    break;
            }











        }
    }
}
