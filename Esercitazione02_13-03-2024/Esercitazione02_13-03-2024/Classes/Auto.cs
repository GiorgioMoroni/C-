using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione02_13_03_2024.Classes
{
    internal class Auto : Veicolo
    {
        public int Porte {  get; set; }


        public Auto() { }

        public Auto(string? marca, string? modello, string? immatricolazione, int porte) 
        {
            Marca = marca;
            Modello = modello;
            Immatricolazione = immatricolazione;
            Porte = porte;

        }


        public override void Accellera()
        {
            Console.WriteLine("L'auto sta accelerando");
        }

        public override void Accensione()
        {
            Console.WriteLine("L'auto si è messa in moto");
        }

        public override void Frena()
        {
            Console.WriteLine("L'auto sta frenando");
        }

        public override void Spegnimento()
        {
            Console.WriteLine("L'auto si è spenta");
        }

        public override string stampaDettaglio()
        {
            string dettaglio = ($"[AUTO] Marca: {Marca} Modello: {Modello} Immatrivolazione: {Immatricolazione} Numero porte: {Porte}");
            return dettaglio;
            //Console.WriteLine($"[AUTO] Marca: {Marca} Modello: {Modello} Immatrivolazione: {Immatricolazione} Numero porte: {Porte}");
        }
    }
}
