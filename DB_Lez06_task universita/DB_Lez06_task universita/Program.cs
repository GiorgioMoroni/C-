using DB_Lez06_task_universita.Models;
using Microsoft.EntityFrameworkCore;

namespace DB_Lez06_task_universita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dato l'esempio: mtm_universita, voglio l'elenco di tutti gli esami a cui è iscritto uno specifico studente
            //e l' elenco di tutti gli studenti iscritti ad un esame

            ICollection<Studente> prova = new List<Studente>();

            using (var ctx = new AccLez09MtmUniversitaContext())
            {
                Studente s = ctx.Studentes.Include(s => s.EsameRifs)
                
                foreach(Studente s in studente)
                {
                    ctx.Entry(s).Collection(p => p.Matricola);
                    foreach(Esame e in s.Nominativo)
                    {
                        prova.Add(s.Nominativo + e.Titolo);
                    }
                }


            }


            //Esame esa = ctx.StudenteEsames.Include(e => e.EsameRifNavigation)

            //ICollection<Esame> ricercaEsame = ctx.Esames.Where(se => se.EsameId == 4).ToList();
            //foreach (Esame se in ricercaEsame)
            //{
            //    Console.WriteLine(se.StudenteRifNavigation.Matricola);
            //}






        }
    }
}
