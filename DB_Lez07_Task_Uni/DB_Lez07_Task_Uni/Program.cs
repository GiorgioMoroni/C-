using DB_Lez07_Task_Uni.Models;
using Microsoft.EntityFrameworkCore;

namespace DB_Lez07_Task_Uni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dato l'esempio: mtm_universita, voglio l'elenco di tutti gli esami a cui è iscritto uno specifico studente
            //e l' elenco di tutti gli studenti iscritti ad un esame


            using (var ctx = new AccLez09MtmUniversitaContext())
            {
                try
                {
                    Studente stu = ctx.Studentes.Include(stu => stu.EsameRifs).Single(stu => stu.StudenteId == 1);

                    Esame esa = ctx.Esames.Include(esa => esa.StudenteRifs).Single(esa => esa.EsameId == 3);

                    foreach (Esame e in stu.EsameRifs)
                    {
                        Console.WriteLine(e.Titolo);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                


            }
        }
    }
}
