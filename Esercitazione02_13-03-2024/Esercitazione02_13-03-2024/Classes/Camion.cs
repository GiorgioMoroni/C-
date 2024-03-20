using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Esercitazione02_13_03_2024.Classes
{
    internal class Camion : Veicolo
    {
        public int Carico { get; set; }

        public Camion() { }

        public Camion(string? marca, string? modello, string? immatricolazione, int carico)
        {
            Marca = marca;
            Modello = modello;
            Immatricolazione = immatricolazione;
            Carico = carico;

        }


        public override void Accellera()
        {
            Console.WriteLine("Il camion sta accelerando");
        }

        public override void Accensione()
        {
            Console.WriteLine("Il camion si è messa in moto");
        }

        public override void Frena()
        {
            Console.WriteLine("Il camion sta frenando");
        }

        public override void Spegnimento()
        {
            Console.WriteLine("Il camion si è spenta");
        }

        public override string stampaDettaglio()
        {
            string dettaglio = ($"[CAMION] Marca: {Marca} Modello: {Modello} Immatrivolazione: {Immatricolazione} Capacità di carico: {Carico}");
            return dettaglio;
            //Console.WriteLine($"[CAMION] Marca: {Marca} Modello: {Modello} Immatrivolazione: {Immatricolazione} Portata di carico: {Carico}KG");
        }



    }
}
