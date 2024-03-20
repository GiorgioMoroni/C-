﻿using LINQ_Lez04_join.Classes;

namespace LINQ_Lez04_join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dipartimento> elencoDip = new List<Dipartimento>()
            {
                new Dipartimento() {Id = 1, Nome = "Matematica" },
                new Dipartimento() {Id = 2, Nome = "Fisica" } ,
                new Dipartimento() {Id = 3, Nome = "Ingegneria" }
            };

            List<Docente> elencoDoc = new List<Docente>()
            {
                new Docente() {Id = 1, Nome = "Giovanni", Cognome = "Pace", DipartimentoRIF = 3 },
                new Docente() {Id = 2, Nome = "Valeria", Cognome = "Verdi", DipartimentoRIF = 2 } ,
                new Docente() {Id = 3, Nome = "Marika", Cognome = "Mariko", DipartimentoRIF = 3}
            };

            var risultato = from docente in elencoDoc
                            join dipartimento in elencoDip on docente.DipartimentoRIF equals dipartimento.Id
                            select new { Doc = docente, Dip = dipartimento};

            foreach(var item in risultato)
            {
                Console.WriteLine($"{item.Doc.Nome} {item.Doc.Cognome} in dipartimento {item.Dip.Nome}");
            }







        }
    }
}
