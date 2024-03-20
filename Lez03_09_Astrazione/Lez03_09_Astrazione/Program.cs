using Lez03_09_Astrazione.Classes;

namespace Lez03_09_Astrazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animale animale = new Animale();      Di una classe astratta non posso istanziare un oggetto
            Gatto gatto = new Gatto();
            Coccodrillo drillo = new Coccodrillo();
        }
    }
}
