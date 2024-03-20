using System.Runtime.CompilerServices;

namespace Lez05_03_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SCRITTURA
            string path = "C:\\Users\\utente\\Desktop\\text.txt";
            //string path = Path.GetDirectoryName(typeof(Program).Assembly.Location);

            string contenuto = "Ciao, Valeria Verdi";
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(contenuto);
                    sw.WriteLine("Ciao");
                    sw.WriteLine("Ciccio");

                }

                Console.WriteLine("Tutto ok");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string lettura = "C:\\Users\\utente\\Desktop\\text.txt";
            try
            {
                using (StreamReader sr = new StreamReader(lettura))
                {
                    string? line;
                    while((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            





        }
    }
}
