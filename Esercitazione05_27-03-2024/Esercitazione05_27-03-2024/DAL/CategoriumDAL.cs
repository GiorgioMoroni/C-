using Esercitazione05_27_03_2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione05_27_03_2024.DAL
{
    internal class CategoriumDAL : IDal<Categorium>
    {
        private static CategoriumDAL? istanza;

        public static CategoriumDAL getIstanza()
        {
            if (istanza == null)
                istanza = new CategoriumDAL();

            return istanza;
        }


        public bool Delete(Categorium t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {

                ctx.Categoria.Remove(t);
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

        public Categorium? Get(int id)
        {
            Categorium ct = new Categorium();
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                try
                {
                    ct = ctx.Categoria.Single(p => p.IdCategoria == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return ct;
        }

        public List<Categorium> GetAll()
        {
            List<Categorium> lista = new List<Categorium>();
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                lista = ctx.Categoria.ToList();
            }
            return lista;
        }

        public bool Insert(Categorium t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                t = new Categorium()
                {
                    Tipo = "Cappotto"

                };
                ctx.Categoria.Add(t);
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

        public bool Update(Categorium t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {

                t.Tipo = "Cappotto";
               
                ctx.Categoria.Update(t);
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
