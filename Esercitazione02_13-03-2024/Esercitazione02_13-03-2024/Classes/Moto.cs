using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione02_13_03_2024.Classes
{
    internal class Moto : Veicolo
    {
        public int Cilindrata { get; set; }


        public Moto() { }

        public Moto(string? marca, string? modello, string? immatricolazione, int cilindrata)
        {
            Marca = marca;
            Modello = modello;
            Immatricolazione = immatricolazione;
            Cilindrata = cilindrata;

        }

        public override void Accellera()
        {
            Console.WriteLine("La moto sta accelerando");
        }

        public override void Accensione()
        {
            Console.WriteLine("La moto si è messa in moto");
        }

        public override void Frena()
        {
            Console.WriteLine("La moto sta frenando");
        }

        public override void Spegnimento()
        {
            Console.WriteLine("La moto si è spenta");
        }

        public override string stampaDettaglio()
        {
            string dettaglio = ($"[MOTO] Marca: {Marca} Modello: {Modello} Immatrivolazione: {Immatricolazione} Cilindrata: {Cilindrata}");
            return dettaglio;
            //Console.WriteLine($"[MOTO] Marca: {Marca} Modello: {Modello} Immatrivolazione: {Immatricolazione} Cilindrata: {Cilindrata}");
        }







    }
}
