﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_07_Ereditarieta.Classes
{
    internal class Studente : Persona
    {
        public string? Matricola { get; set; }

        public Studente(string? nome, string? cognome, string? matricola) 
        {
            Nome = nome;
            Cognome = cognome;
            Matricola = matricola;
        }

        public override void stampaDettaglio() 
        {
            Console.WriteLine($"{Nome} {Cognome} {Matricola}"); 
        }








    }
}
