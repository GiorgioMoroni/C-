namespace Lez02_06_CicliSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///*
            // * while(condizione)
            // * {
            // * corpo da eseguire
            // * }
            // */

            //int indice = 0;

            //while (indice < 5)
            //{
            //    Console.WriteLine("Ciao");
            //    indice++;
            //}

            ////--------------------------------------------------------------------

            //while (indice < 5)
            //{
            //    Console.WriteLine($"Sono all' indice {indice +1}");
            //    indice++;
            //}

            ////--------------------------------------------------------------------
            ////Do While

            //int i = 0;

            //do
            //{
            //    Console.WriteLine($"Sono all' indice {i + 1}");
            //    i++;
            //}
            //while (i < 5);

            ////--------------------------------------------------------------------

            //bool insAbilitato = true;

            //while (insAbilitato ) 
            //{
            //    Console.WriteLine("Inserisci il tuo nome o digita Q per uscire");
            //    string? inputUtente = Console.ReadLine();

            //if (inputUtente != null && inputUtente.Equals("Q"))
            //{
            //    insAbilitato = false;
            //}
            //else
            //{
            //    Console.WriteLine($"Ciao {inputUtente}");
            //}


            //--------------------------------------------------------------------

            /*
             * Step uno: un sistema di gestione invitati alla propria festa
             * L'inserimento avviene tramite console che prende in input (in due tempi diversi) nome e cognome
             * 
             * All'uscita del programma verrà stampato l'elenco delle persone precedentemente inserita, separate dalla virgola
             */

            bool insAbilitato = true;
            string risultato = "";

            while(insAbilitato)
            {
                Console.WriteLine("Cosa vuoi fare?\n" +
                    "Premi invio per nuovo utente o dgita Q per uscire");
                string? input = Console.ReadLine();
                if (input != null && input.Equals("Q"))
                {
                    insAbilitato = false;
                }
                else
                {
                    Console.WriteLine("Inserisci nome:");
                    string? nome = Console.ReadLine();

                    Console.WriteLine("Inserisci cognome");
                    string? cognome = Console.ReadLine();

                    risultato += nome + " " + cognome + ",";
                    Console.WriteLine("Operazione effettuata con successo\n" +
                        "------------------------------------------");
                }
                
            }
            Console.WriteLine(risultato);
                

            
                










        }
    }
}
