namespace Lez01_02_ControlliSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variabili

            //int eta = 15;
            //int eta;
            //eta = 15;

            //Console.WriteLine(eta);

            //string nome;
            //nome = "Giovanni";

            String? cognome = null;     //Valore nullable con il ?
            cognome = "Pace";
            Console.WriteLine(cognome);


            /*
             * if(condizione){
             * //Condice in caso positivo
                } else{
                    //Codice in caso negativo
            */


            //Espansione orizzontale
            int eta = 8500;

            if (eta <= 0) 
            {
                Console.WriteLine("Non penso sei un embrione");
            }
            else 
            {
                if (eta > 0) 
                {
                    Console.WriteLine("Te li porti davvero bene");
                }
                else 
                {
                    if (eta >= 18)
                    {
                        Console.WriteLine("Sei maggiorenne");
                    }
                    else
                    {
                        Console.WriteLine("Sei minorenne");
                    }
                }

                
            }


            if (eta <= 0 || eta >= 120)
            {
                Console.WriteLine("Errore di validazione");
            }
            else
            {
                Console.WriteLine("Procedi con l'operazione");
            }


            if (eta > 0 && eta < 120)
            {
                Console.WriteLine("Procedi con l'operazione");
            }
            else
            {
                Console.WriteLine("Errore di validazione");
            }


        }
    }
}
