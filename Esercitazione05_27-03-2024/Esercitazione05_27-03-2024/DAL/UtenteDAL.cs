using Esercitazione05_27_03_2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Esercitazione05_27_03_2024.DAL
{
    internal class UtenteDAL : IDal<Utente>
    {
        private static UtenteDAL? istanza;

        public static UtenteDAL getIstanza()
        {
            if (istanza == null)
                istanza = new UtenteDAL();

            return istanza;
        }


        public bool Delete(Utente t)
        {
            bool inserimento;

            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                
                ctx.Utentes.Remove(t);
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

        public Utente? Get(int id)
        {
            Utente ut = new Utente();
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                try
                {
                    ut = ctx.Utentes.Single(p => p.IdUtente == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return ut;

        }

        public List<Utente> GetAll()
        {
            List<Utente> lista = new List<Utente>();
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                lista = ctx.Utentes.ToList();
            }
            return lista;
        }

        public bool Insert(Utente t)
        {
            bool inserimento;
            
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {
                t = new Utente()
                {
                    Nome = "Giorgio",
                    Cognome = "Moroni",
                    Email = "gio@mor.com",
                    Telefono = "938322",

                };
                ctx.Utentes.Add(t);
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

        public bool Update(Utente t)
        {
            bool inserimento;
            
            using (var ctx = new AccLez30EsercitazioneGestioneAbitiContext())
            {

                t.Nome = "Giorgio";
                t.Cognome = "Moroni";
                t.Email = "gio@mor.com";
                t.Telefono = "938322";

                ctx.Utentes.Update(t);
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
