using Lez03_06_InfoHoldingIncapsulamento.Classes;

namespace Lez03_06_InfoHoldingIncapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Automobile peugeot = new Automobile();
            peugeot.marca = "Peugeot";

            Automobile bmw = new Automobile();
            bmw.marca = "BMW";
            bmw.cilindrata = 2400;

            Moto honda = new Moto();
            honda.setCilindrata(750);
            //Console.WriteLine(honda.cilindrata);

            Console.WriteLine(honda.getCilindrata());

            Monopattino xiao = new Monopattino();
            xiao.Marca = "Xiaomi";
            //xiao.VelMax = 60.0f;      //No, implementato sotto metodo get
            xiao.NumPersone = 3;

            Console.WriteLine(xiao.Marca);
            Console.WriteLine(xiao.VelMax);
            Console.WriteLine(xiao.NumPersone);

            //Se voglio invocare il costruttore di default devo implementarlo nella classe
            Bicicletta nukeproof = new Bicicletta();
            nukeproof.HasCampanello = true;

            Bicicletta commencal = new Bicicletta("Commencal", "Allmountain", true);
            



        }
    }
}
