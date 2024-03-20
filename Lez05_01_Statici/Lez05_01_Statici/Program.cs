using Lez05_01_Statici.Classes;

namespace Lez05_01_Statici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Automobile.Contatore);
            Automobile.stampaContatore();

            Automobile auto1 = new Automobile("Blu");
            Automobile auto2 = new Automobile("Giallo");

            //Console.WriteLine(Automobile.Contatore);
            Automobile.stampaContatore();










        }
    }
}
