namespace Lez02_02_Stringhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int? a = null;
            //Console.WriteLine(a);

            //string nominativo = "Giovanni Pace";
            //Console.WriteLine(nominativo);

            //int a = 2;
            //int b = 5;

            //Console.WriteLine("La somma dei numeri è: " + a + b);       //... è 25
            //Console.WriteLine(a + b + " la somma dei numeri è");
            //Console.WriteLine("La somma dei numeri è: " + (a + b));

            //-------------------------------------------------------------------------

            //Operazione semplici tra stringhe
            /* Scrivere un programma che mandi in output le seguenti due stringhe:
             * 
             * Giovanni Pace è 37 anni vecchio ed ha una temperatura corporea di 36.5°C.
             * Giovanni Pace è 23 anni vecchio ed ha una temperatura corporea di 38.5°C.
             */

            string nominativo = "Giovanni Pace";
            float temp = 36.5f;
            int eta = 37;
            Console.WriteLine($"{nominativo} è {eta} anni vecchio ed ha una temperatura corporea di {temp}°C");

            nominativo = "Mario Rossi";
            temp = 38.5f;
            eta = 23;
            Console.WriteLine($"{nominativo} è {eta} anni vecchio ed ha una temperatura corporea di {temp}°C");

            //-------------------------------------------------------------------------

            Console.WriteLine($"Il risultato è: {5 + 6}");      //Permette di fare operazioni

            string nomin = "Giovanni Pace";
            Console.WriteLine($"{nomin} ha una lunghezza di {nomin.Length} caratteri");

            int lunghezza = nomin.Length;
            Console.WriteLine($"{nomin} ha una lunghezza di {lunghezza} caratteri");

            //-------------------------------------------------------------------------

            string? frase = "Mi piace tanto \"Programmare\"";       //Carattere di escape per disattivare il Parse
            Console.WriteLine(frase);

            //-------------------------------------------------------------------------

            string f = "Sono Giovanni Pace e mi piace programmare";
            Console.WriteLine(f.IndexOf("Pace"));

            if (f.IndexOf("Pappagallo") != -1)
                Console.WriteLine("Non trovato");
            else
                Console.WriteLine("Trovato!");










        }
    }
}
