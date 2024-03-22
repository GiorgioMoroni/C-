using DB_Lez05_Correzione_Esercitazione03.Utilities;

namespace DB_Lez05_Correzione_Esercitazione03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Config.getInstance().getConnectionString());
        }
    }
}
