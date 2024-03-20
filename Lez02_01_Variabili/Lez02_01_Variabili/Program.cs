namespace Lez02_01_Variabili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipo di dato primitivo
            int eta;        //Dichiarazione
            eta = 15;       //Assegnazione

            float b = 15.7f;
            Console.WriteLine(b);

            double c = 14.6d;
            Console.WriteLine(c);

            double d = b;
            Console.WriteLine(d);

            Console.WriteLine(d == b);      //TRUE

            //----------------------------------------------------------------- 

            //Più efficente in termini spaziali (occupa meno memoria)
            int valoreUno = 8;
            int valoreDue = 5;

            Console.WriteLine(valoreUno + valoreDue);
            Console.WriteLine(valoreUno + valoreDue);
            Console.WriteLine(valoreUno + valoreDue);
            Console.WriteLine(valoreUno + valoreDue);

            //---------------------------------------------------------------

            //Più efficente in termini temporali (Meno tempo delle operazioni)
            int somma = valoreUno + valoreDue;

            Console.WriteLine(somma);
            Console.WriteLine(somma);
            Console.WriteLine(somma);
            Console.WriteLine(somma);

            //---------------------------------------------------------------

            //Operazione complessa
            Console.WriteLine(15 + 16.9f + 23.5d);      //Il tipo sarà double perchè prende il tipo più grande

            //---------------------------------------------------------------

            int numero = 5;
            //numero = numero + 1;
            //numero = numero + 4;

            //Console.WriteLine(numero);

            numero += 1;
            numero += 4;
            numero -= 2;

            Console.WriteLine(numero);

            //---------------------------------------------------------------

            int num = 0;

            num++;
            num++;

            Console.WriteLine(num);

            //---------------------------------------------------------------

            int valUno = 15;
            float valDue = 78.0f;

            float rapporto = valUno / valDue;

            Console.WriteLine(rapporto);
            Console.WriteLine((int)rapporto);

            //---------------------------------------------------------------

            int ciccio = 2;
            int n = 2147483647 + ciccio;
            Console.WriteLine(n);

        }
    }
}
