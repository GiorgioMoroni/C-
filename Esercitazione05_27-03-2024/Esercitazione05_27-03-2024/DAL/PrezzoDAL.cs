using Esercitazione05_27_03_2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione05_27_03_2024.DAL
{
    internal class PrezzoDAL : IDal<Prezzo>
    {
        private static PrezzoDAL? istanza;

        public static PrezzoDAL getIstanza()
        {
            if (istanza == null)
                istanza = new PrezzoDAL();

            return istanza;
        }


        public bool Delete(Prezzo t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {

                ctx.Prezzos.Remove(t);
                ctx.SaveChanges();
                if (ctx.SaveChanges() == 0)
                {
                    inserimento = false;
                }
                else
                {
                    inserimento = true;
                }
            }

            return inserimento;
        }

        public Prezzo? Get(int id)
        {
            Prezzo pr = new Prezzo();
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                try
                {
                    pr = ctx.Prezzos.Single(p => p.IdPrezzo == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return pr;
        }

        public List<Prezzo> GetAll()
        {
            List<Prezzo> lista = new List<Prezzo>();
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                lista = ctx.Prezzos.ToList();
            }
            return lista;
        }

        public bool Insert(Prezzo t)
        {
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                bool inserimento;

                t = new Prezzo()
                {
                    Prezzo1 = 59.9M,
                    PrezzoSconto = 39.9M,
                    DataInizio = new DateOnly(2024, 04, 04),
                    DataFine = new DateOnly(2024, 04, 11),
                    VariazioneRif = 9

                };
                ctx.Prezzos.Add(t);
                ctx.SaveChanges();
                if (ctx.SaveChanges() == 0)
                {
                    inserimento = false;
                }
                else
                {
                    inserimento = true;
                }
                return inserimento;
            }
        }

        public bool Update(Prezzo t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {

                t.Prezzo1 = 59.5M;
                t.PrezzoSconto = 30.9M;
                t.DataInizio = new DateOnly(2024, 03, 10);
                t.DataFine = new DateOnly(2024, 03, 10);
                t.VariazioneRif = 9;


                ctx.Prezzos.Update(t);
                ctx.SaveChanges();

                if (ctx.SaveChanges() == 0)
                {
                    inserimento = false;
                }
                else
                {
                    inserimento = true;
                }


            }
            return inserimento;
        }
    }
}
