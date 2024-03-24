using Esercitazione04_22_03_2024.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Esercitazione04_22_03_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aggiunta Partecipanti
            //METODO AGGIUNTA PARTECIPANTI
            //using (var ctx = new AccLez28EsercitazioneEventiContext())
            //{
            //    Partecipante p1 = new Partecipante()
            //    {
            //        NomePar = "Tiziano",
            //        Cognome = "Titone",
            //        Telefono = "1093854",
            //        Email = "tiz@titone.com"

            //    };
            //    ctx.Partecipantes.Add(p1);
            //    ctx.SaveChanges();
            //}
            #endregion

            #region Aggiunta Eventi
            //METODO AGGIUNTA EVENTI
            //using (var ctx = new AccLez28EsercitazioneEventiContext())
            //{
            //    Evento e1 = new Evento()
            //    {
            //        NomeEvento = "Concerto Trap",
            //        Descrizione = "Festival di musica Trap",
            //        DataEvento = new DateTime(2024, 10, 01),
            //        Luogo = "Roma",
            //        CapacitaMax = 1250
            //    };
            //    ctx.Eventos.Add(e1);
            //    ctx.SaveChanges();
            //}
            #endregion

            #region Aggiunta Risorse
            //METODO AGGIUNTA RISORSE
            //using (var ctx = new AccLez28EsercitazioneEventiContext())
            //{
            //    Risorse r1 = new Risorse()
            //    {
            //        Tipologia = "cibo",
            //        Quantita = 2000,
            //        Costo = 12.9M,
            //        Fornitore = "Mc Donald",
            //        Codice = "PH1234"
            //    };
            //    ctx.Risorses.Add(r1);
            //    ctx.SaveChanges();
            //}
            #endregion

            #region Update
            //METODO UPDATE EVENTI
            //using (var ctx = new AccLez28EsercitazioneEventiContext())
            //{
            //    Evento? evento = ctx.Eventos.FirstOrDefault(e => e.IdEvento == 2);
            //    if (evento != null)
            //    {
            //        evento.NomeEvento = "Festa in spiaggia";
            //        evento.Descrizione = "Festa Privata";
            //        evento.DataEvento = evento.DataEvento;
            //        evento.Luogo = "Fregene";
            //        evento.CapacitaMax = 200;

            //        ctx.Eventos.Update(evento);
            //        ctx.SaveChanges();

            //        Console.WriteLine("Evento aggiornato");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Evento non trovato.");
            //    }
            //}
            #endregion

            #region Ricerca eventi a cui partecipa una persona
            //METODO RICRCA EVENTI A CUI PARTECIPA UNA PERSONA
            //using (var ctx = new AccLez28EsercitazioneEventiContext())
            //{
            //    try
            //    {
            //        Partecipante par = ctx.Partecipantes.Include(par => par.EventoRifs).Single(par => par.IdPartecipante == 3);

            //        Console.WriteLine(par.NomePar + " " + par.Cognome);
            //        foreach (Evento e in par.EventoRifs)
            //        {
            //            Console.WriteLine(e.NomeEvento);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //}
            #endregion

            #region Ricerca Partecipanti di un evento
            //METODO RICERCA PERSONE CHE PARTECIPANO AD UN EVENTO
            //using (var ctx = new AccLez28EsercitazioneEventiContext())
            //{
            //    try
            //    {
            //        Evento eve = ctx.Eventos.Include(eve => eve.PartecipanteRifs).Single(eve => eve.IdEvento == 1);

            //        Console.WriteLine(eve.NomeEvento + " " + eve.DataEvento);
            //        foreach (Partecipante p in eve.PartecipanteRifs)
            //        {
            //            Console.WriteLine(p.NomePar + " " + p.Cognome);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //}
            #endregion

            #region Stampa tutti i Partecipanti
            //using (var ctx = new AccLez28EsercitazioneEventiContext())
            //{
            //    List<Partecipante> elenco = ctx.Partecipantes.ToList();

            //    foreach(Partecipante c in elenco)
            //    {
            //        Console.WriteLine(c.ToString());
            //    }
            //}
            #endregion

            #region Ricera Partecipante per id e relativa stampa
            //using (var ctx = new AccLez28EsercitazioneEventiContext())
            //{
            //    Partecipante? p = ctx.Partecipantes.FirstOrDefault(p => p.IdPartecipante == 2);

            //    if( p is not null)
            //    {
            //        Console.WriteLine(p);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Partecipante non trovato");
            //    }

            //}
            #endregion

            #region Scrittura eventi su file
            //using (var ctx = new AccLez28EsercitazioneEventiContext())
            //{
            //    var eventi = ctx.Eventos.ToList();

            //    string path = "C:\\Users\\utente\\Desktop\\eventi.text";
            //    using (StreamWriter writer = File.CreateText(path))
            //    {
            //        foreach (Evento e in eventi)
            //        {
            //            writer.WriteLine(e.ToString());
            //        }
            //    }

            //    Console.WriteLine($"Scrittura effettuata con successo");
            //}
            #endregion

            #region Scrittura partecipanti su file
            //using (var ctx = new AccLez28EsercitazioneEventiContext())
            //{
            //    var partecipanti = ctx.Partecipantes.ToList();

            //    string path = "C:\\Users\\utente\\Desktop\\partecipanti.text";

            //    using (StreamWriter writer = File.CreateText(path))
            //    {
            //        foreach (Partecipante p in partecipanti)
            //        {
            //            writer.WriteLine(p.ToString());
            //        }
            //    }
            //    Console.WriteLine($"Scrittura effettuata con successo");
            //}
            #endregion

            Menu.UtenteConsole();
        }
    }
}
