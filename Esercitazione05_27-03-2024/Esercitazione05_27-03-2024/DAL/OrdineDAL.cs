using Esercitazione05_27_03_2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione05_27_03_2024.DAL
{
    internal class OrdineDAL : IDal<Ordine>
    {
        private static OrdineDAL? istanza;

        public static OrdineDAL getIstanza()
        {
            if (istanza == null)
                istanza = new OrdineDAL();

            return istanza;
        }


        public bool Delete(Ordine t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {

                ctx.Ordines.Remove(t);
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

        public Ordine? Get(int id)
        {
            Ordine or = new Ordine();
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                try
                {
                    or = ctx.Ordines.Single(p => p.IdOrdine == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return or;
        }

        public List<Ordine> GetAll()
        {
            List<Ordine> lista = new List<Ordine>();
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                lista = ctx.Ordines.ToList();
            }
            return lista;
        }

        public bool Insert(Ordine t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                t = new Ordine()
                {
                    DataOrdine = new DateOnly(2024, 03, 07),
                    QuantitaOrdinata = 2,
                    UtenteRif = 1

                };
                ctx.Ordines.Add(t);
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

        public bool Update(Ordine t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {

                t.DataOrdine = new DateOnly(2024, 03, 10);
                t.QuantitaOrdinata = 2;
                t.UtenteRif = 1;

                ctx.Ordines.Update(t);
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
