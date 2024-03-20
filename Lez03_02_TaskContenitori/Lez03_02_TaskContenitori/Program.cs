namespace Lez03_02_TaskContenitori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] libro_1 = { "Il signore degli anelli", "JRRT", "123456-1225", "Casa ed 1" };
            string[] libro_2 = { "Il ritorno del re", "JRRT", "123456-1225", "Casa ed 1" };
            string[] libro_3 = { "Il visconte dimezzato", "I.Calvino", "987456-1225", "Casone editrice" };
            string[] libro_4 = { "Storia del buongiorno", "A.Christie", "456466-1225", "Casone editrice" };
            string[] libro_5 = { "Le due torri", "JRRT", "456463-1225", "Casa ed 1" };

            string[][] store = {libro_1, libro_2, libro_3, libro_4, libro_5 };
            int contatore = 0;

            Console.WriteLine("Ricerca un autore:");
            string? inputUtente = Console.ReadLine();

            for (int i = 0; i < store.Length; i++)
            {
                if (inputUtente is not null && store[i][1].ToUpper().Equals(inputUtente.ToUpper().Trim()))
                {
                    contatore++;
                    Console.WriteLine($"Nome: {store[i][0]}\nISBN: {store[i][2]}\nCasa Editrice: {store[i][3]}");
                    Console.WriteLine();

                }
            }
            Console.WriteLine($"Il numero di libri dell' autore: {inputUtente} sono: {contatore}");












        }
    }
}
