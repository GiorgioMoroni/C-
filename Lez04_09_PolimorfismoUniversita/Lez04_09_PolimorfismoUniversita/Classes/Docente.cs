using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_09_PolimorfismoUniversita.Classes
{
    internal class Docente : Persona
    {
        public string? Materia { get; set; }
        public string? Dipartimento { get; set; }

        public Docente(string? nome, string? cognome, string? dipartimento, string? materia)
        {
            Nome = nome;
            Cognome = cognome;
            Materia = materia;
            Dipartimento = dipartimento;
        }


        public override void stampaDettaglio()
        {
            Console.WriteLine($"[DOCENTE] {Nome} {Cognome} {Materia} {Dipartimento}");
        }



    }
}
