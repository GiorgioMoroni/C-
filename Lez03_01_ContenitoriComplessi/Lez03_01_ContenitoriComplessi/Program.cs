namespace Lez03_01_ContenitoriComplessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studUno = { "Giovanni Pace", "12345", "PCAGNN" };
            string[] studDue = { "Valeria Verdi", "12346", "VLRVRD" };
            string[] studTre = { "Mario Rossi", "12347", "MRRRSS" };

            string[][] elenco = {studUno, studDue, studTre};

            //RIchiede codice fiscale da trovare

            Console.WriteLine("Scrivi codice fiscale:");
            string? inputUtente = Console.ReadLine();

            for (int i = 0; i < elenco.Length; i++)
            {
                if (inputUtente is not null && elenco[i][2].ToUpper().Equals(inputUtente.ToUpper().Trim()))
                {
                    Console.WriteLine($"Nome: {elenco[i][0]}\nMatricola: {elenco[i][1]}");
                }
            }







        }
    }
}
