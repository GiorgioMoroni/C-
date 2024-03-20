namespace Lez02_07_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numeri = { 6, 67, 23, 54, 2, 6 };
            //Console.WriteLine(numeri[2]);

            //numeri[2] = 111;
            //Console.WriteLine(numeri);

            int[] numeri = new int[6];
            //Console.WriteLine(numeri[2]);

            numeri[0] = 6;
            numeri[1] = 67;
            numeri[2] = 23;
            numeri[3] = 54;
            numeri[4] = 2;
            numeri[5] = 6;

            int i = 0;

            while(i < numeri.Length) 
            {
                Console.WriteLine(numeri[i]);
                i++;
            }

            //------------------------------------------------------
            //FOR

            string[] parco = { "Maserati", "Lamborghini", "BMW", "FIAT" };
            for (int j =  0; j < parco.Length; j++)
            {
                Console.WriteLine(parco[j]);
            }

            string ricerca = "BMW";
            bool trovato = false;
            for (int j = 0; j < ricerca.Length; j++)
            {
                if (parco[j].Equals(ricerca))
                {
                    trovato = true;
                }

            }

            if (trovato)
            {
                Console.WriteLine("Trovato");
            }
            else
            {
                Console.WriteLine("Non trovato");
            }

            //------------------------------------------------------
            //FOREACH

            string[] elenco = { "Maserati", "Lamborghini", "BMW", "FIAT" };
            foreach (string auto in elenco)
            {
                Console.WriteLine(auto);
            }

            /*
             * Presa stringa comprosta in questo modo: "Giovanni, Valeria, Marika, Mario, Valeria
             * Trasformarla in un array evitando le ripetizioni
             */

            string s = "Giovanni, Valeria, Marika, Mario, Valeria";
            string[] nomi = s.Split(", ");
            string[] nomi2 = [];
            bool b = false;

            //for (int k = 0; k < nomi.Length; k++)
            //{
            //    for (int h = k + 1; h < nomi.Length; h++)
            //    {
            //        if (nomi[h] != (nomi[k]))
            //        {
            //            nomi2 = nomi2.Append(nomi[k]).ToArray();
            //            break;
            //        }
            //    }
                
            //}

            for (int k = 0; k < nomi.Length; k++)
            {
                for (int h = 1; h < nomi.Length;)
                {

                    if (nomi[h] != nomi[k])
                    {
                        h++;
                    }
                    else
                    {
                        b = true;
                    }

                    if (b = true && h == (nomi.Length - 1))
                    {
                        nomi2 = nomi2.Append(nomi[k]).ToArray();
                    }
                    

                }

            }

            foreach (string nom in nomi2)
            {
                Console.Write(nom + " ");
            }





















        }
    }
}
