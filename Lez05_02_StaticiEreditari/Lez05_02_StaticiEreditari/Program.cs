using Lez05_02_StaticiEreditari.Classes;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Lez05_02_StaticiEreditari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Giocattolo autoUno = new Automobile();
            Giocattolo autoDue = new Automobile();
            Giocattolo trenino = new Trenino();

            Console.WriteLine(Giocattolo.Contatore);

            List<Giocattolo> elenco =  new List<Giocattolo>();
            elenco.Add(autoUno);
            elenco.Add(autoDue);
            elenco.Add(trenino);

            foreach(Giocattolo item in elenco)
            {
                if(item.GetType() == typeof(Trenino))
                {
                    Trenino temp = (Trenino)item;
                    temp.rumoreTrenino();
                }
                
            }



        }
    }
}
