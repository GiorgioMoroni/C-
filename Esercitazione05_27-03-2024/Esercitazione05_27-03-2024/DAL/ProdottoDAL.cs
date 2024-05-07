using Esercitazione05_27_03_2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione05_27_03_2024.DAL
{
    internal class ProdottoDAL : IDal<Prodotto>
    {
        private static ProdottoDAL? istanza;

        public static ProdottoDAL getIstanza()
        {
            if (istanza == null)
                istanza = new ProdottoDAL();

            return istanza;
        }


        public bool Delete(Prodotto t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {

                ctx.Prodottos.Remove(t);
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

        public Prodotto? Get(int id)
        {
            Prodotto pt = new Prodotto();
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                try
                {
                    pt = ctx.Prodottos.Single(p => p.IdProdotto == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return pt;
        }

        public List<Prodotto> GetAll()
        {
            List<Prodotto> lista = new List<Prodotto>();
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                lista = ctx.Prodottos.ToList();
            }
            return lista;
        }

        public bool Insert(Prodotto t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                t = new Prodotto()
                {
                    Marca = "NorthFace",
                    Modello = "Bomberino",
                    CategoriaRif = 3

                };
                ctx.Prodottos.Add(t);
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

        public bool Update(Prodotto t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {

                t.Marca = "Wulrich";
                t.Modello = "Giubbino";

                ctx.Prodottos.Update(t);
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
