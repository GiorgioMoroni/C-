using Esercitazione05_27_03_2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione05_27_03_2024.DAL
{
    internal class VariazioneDAL : IDal<Variazione>
    {
        private static VariazioneDAL? istanza;

        public static VariazioneDAL getIstanza()
        {
            if (istanza == null)
                istanza = new VariazioneDAL();

            return istanza;
        }


        public bool Delete(Variazione t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {

                ctx.Variaziones.Remove(t);
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

        public Variazione? Get(int id)
        {
            Variazione vr = new Variazione();
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                try
                {
                    vr = ctx.Variaziones.Single(p => p.IdVariazione == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return vr;
        }

        public List<Variazione> GetAll()
        {
            List<Variazione> lista = new List<Variazione>();
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                lista = ctx.Variaziones.ToList();
            }
            return lista;
        }

        public bool Insert(Variazione t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                t = new Variazione()
                {
                    Colore = "Nero",
                    Taglia = "L",
                    Quantita = 15,
                    ProdottoRif = 3

                };
                ctx.Variaziones.Add(t);
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

        public bool Update(Variazione t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {

                t.Colore = "Nero";
                t.Taglia = "L";
                t.Quantita = 5;
                t.ProdottoRif = 3;

                ctx.Variaziones.Update(t);
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
