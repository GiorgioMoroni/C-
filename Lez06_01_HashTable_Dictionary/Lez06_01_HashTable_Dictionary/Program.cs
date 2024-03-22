using System.Collections;

namespace Lez06_01_HashTable_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hashtable ht = new Hashtable();     //Si comporta esattamente come una lista ma ha un identificatore univoco

            //ht.Add(0, "Giovanni Pace");
            //ht.Add(1, "Valeria Verdi");
            //ht.Add(2, "Mario Rossi");

            //Console.WriteLine(ht[0]);
            //Console.WriteLine(ht[1]);
            //Console.WriteLine(ht[2]);

            //if (ht.ContainsKey(1))
            //{
            //    ht.Remove(1);
            //}

            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine($"Chiave: {item.Key} Valore: {item.Value}");
            //}

            //---------------------------------------------------------------------------

            Dictionary<String, String> dictionary = new Dictionary<String, String>();

            dictionary.Add("AB1234", "Giovanni Pace");
            dictionary.Add("AB1235", "Valeria Verdi");
            dictionary.Add("AB1236", "Mario Rossi");

            foreach (KeyValuePair<String, String> item in dictionary)
            {
                Console.WriteLine($"Chiave: {item.Key} Valore: {item.Value}");
            }



        }
    }
}
