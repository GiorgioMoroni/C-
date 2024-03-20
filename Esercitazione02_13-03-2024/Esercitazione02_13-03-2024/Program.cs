using Esercitazione02_13_03_2024.Classes;

namespace Esercitazione02_13_03_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veicolo veicolo1 = new Auto("Ford", "Mustang", "1970", 3);
            //Veicolo veicolo2 = new Auto("Hyundai", "i10", "2010", 5);
            //Veicolo veicolo3 = new Moto("Ducati", "CBR", "2020", 250);
            //Veicolo veicolo4 = new Moto("Yamaha", "V46", "2015", 500);
            //Veicolo veicolo5 = new Camion("FIAT", "Fiorino", "2009", 50);

            Flotta flotta1 = new Flotta("Indianapolis");

            //flotta1.Aggiungi(veicolo1);
            //flotta1.Aggiungi(veicolo2);
            //flotta1.Aggiungi(veicolo3);
            //flotta1.Aggiungi(veicolo4);
            //flotta1.Aggiungi(veicolo5);

            //flotta1.ScriviFile();

            //flotta1.LeggiFile();

            bool insAbilitato = true;

            while (insAbilitato)
            {
                
                Console.WriteLine("Cosa vuoi fare?\nInserisci veicolo, lista veicoli o premi Q per uscire");
                string? input = Console.ReadLine();

                if (input != null && input.Equals("Q"))
                {
                    insAbilitato = false;
                }
                else if (input != null && input.Equals("inserisci"))
                {
                    
                    Console.WriteLine("Inserisci tipo veicolo:");
                    string? inputVeicolo = Console.ReadLine();

                    if (inputVeicolo != null && inputVeicolo.Equals("auto"))
                    {
                        Auto au = new Auto();
                        Console.WriteLine("Inserisci marca:");
                        string? inputMarca = Console.ReadLine();

                        au.Marca = inputMarca;

                        Console.WriteLine("Inserisci modello");
                        string? inputModello = Console.ReadLine();

                        au.Modello = inputModello;

                        Console.WriteLine("Inserisci immatricolazione");
                        string? inputImmatricolazione = Console.ReadLine();

                        au.Immatricolazione = inputImmatricolazione;

                        Console.WriteLine("Inserisci numero porte");
                        string? dato = Console.ReadLine();

                        au.Porte = Int32.Parse(dato);
                        flotta1.Aggiungi(au);
                        flotta1.SlavaFlotta();

                    }
                    else if (inputVeicolo != null && inputVeicolo.Equals("moto"))
                    {
                        Moto mo = new Moto();
                        Console.WriteLine("Inserisci marca:");
                        string? inputMarca = Console.ReadLine();

                        mo.Marca = inputMarca;

                        Console.WriteLine("Inserisci modello");
                        string? inputModello = Console.ReadLine();

                        mo.Modello = inputModello;

                        Console.WriteLine("Inserisci immatricolazione");
                        string? inputImmatricolazione = Console.ReadLine();

                        mo.Immatricolazione = inputImmatricolazione;

                        Console.WriteLine("Inserisci cilindrata");
                        string? dato = Console.ReadLine();

                        mo.Cilindrata = Int32.Parse(dato);
                        flotta1.Aggiungi(mo);
                        flotta1.SlavaFlotta();
                    }
                    else if (inputVeicolo != null && inputVeicolo.Equals("camion"))
                    {
                        Camion ca = new Camion();
                        Console.WriteLine("Inserisci marca:");
                        string? inputMarca = Console.ReadLine();

                        ca.Marca = inputMarca;

                        Console.WriteLine("Inserisci modello");
                        string? inputModello = Console.ReadLine();

                        ca.Modello = inputModello;

                        Console.WriteLine("Inserisci immatricolazione");
                        string? inputImmatricolazione = Console.ReadLine();

                        ca.Immatricolazione = inputImmatricolazione;

                        Console.WriteLine("Inserisci portata carico");
                        string? dato = Console.ReadLine();

                        ca.Carico = Int32.Parse(dato);
                        flotta1.Aggiungi(ca);
                        flotta1.SlavaFlotta();
                    }

                }
                else if (input != null && input.Equals("lista"))
                {
                    flotta1.LeggiFile();
                }


















            }

            










        }
    }
}
