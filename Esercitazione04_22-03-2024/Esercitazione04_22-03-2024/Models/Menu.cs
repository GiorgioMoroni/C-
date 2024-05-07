using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione04_22_03_2024.Models
{
    internal class Menu
    {
        public static void UtenteConsole()
        {
            bool insAbilitato = true;
            while (insAbilitato)
            {
                using (var ctx = new AccLez28EsercitazioneEventiContext())
                {
                    Console.WriteLine("Seleziona:\nGestione eventi, gestione partecipanti o premi Q per uscire");
                    string? input = Console.ReadLine();
                    if (input != null && input.Equals("Q"))
                    {
                        insAbilitato = false;
                    }
                    else if (input != null && input.Equals("eventi"))
                    {
                        #region Gestione eventi
                        Console.WriteLine("Inserisci nuovo evento con N, aggiorna evento esistente con A o stampa tutti gli eventi con S");
                        string? inputEvento = Console.ReadLine();
                        switch (inputEvento)
                        {
                            case "N":
                                Evento e = new Evento();

                                Console.WriteLine("Inserisci nome evento");
                                string? nomeEvento = Console.ReadLine();
                                e.NomeEvento = nomeEvento;

                                Console.WriteLine("Inserisci descrizione evento");
                                string? desEvento = Console.ReadLine();
                                e.Descrizione = desEvento;

                                Console.WriteLine("Inserisci data evento");
                                string? dataEvento = Console.ReadLine();
                                e.DataEvento = Convert.ToDateTime(dataEvento);

                                Console.WriteLine("Inserisci luogo evento");
                                string? luogoEvento = Console.ReadLine();
                                e.Luogo = luogoEvento;

                                Console.WriteLine("Inserisci capacità massima");
                                string? capEvento = Console.ReadLine();
                                e.CapacitaMax = Convert.ToInt32(capEvento);

                                ctx.Eventos.Add(e);
                                ctx.SaveChanges();

                                var eventi = ctx.Eventos.ToList();
                                string path = "C:\\Users\\utente\\Desktop\\eventi.text";
                                using (StreamWriter writer = File.CreateText(path))
                                {
                                    foreach (Evento evento in eventi)
                                    {
                                        writer.WriteLine(evento.ToString());
                                    }
                                }

                                break;

                            case "A":
                                Console.WriteLine("Inserisci Id evento da modificare");
                                string? inputChange = Console.ReadLine();

                                Evento? ev = ctx.Eventos.FirstOrDefault(eve => eve.IdEvento == Convert.ToInt32(inputChange));
                                if (ev != null)
                                {
                                    Console.WriteLine("Inserisci nuovo nome evento");
                                    string? nuovoNome = Console.ReadLine();
                                    ev.NomeEvento = nuovoNome;

                                    Console.WriteLine("Inserisci nuova descrizione evento");
                                    string? nuovaDes = Console.ReadLine();
                                    ev.Descrizione = nuovaDes;

                                    Console.WriteLine("Inserisci nuova data evento");
                                    string? nuovaData = Console.ReadLine();
                                    ev.DataEvento = Convert.ToDateTime(nuovaData);

                                    Console.WriteLine("Inserisci nuovo luogo evento");
                                    string? nuovoLuogo = Console.ReadLine();
                                    ev.Luogo = nuovoLuogo;

                                    Console.WriteLine("Inserisci nuova capacità massima");
                                    string? nuovaCap = Console.ReadLine();
                                    ev.CapacitaMax = Convert.ToInt32(nuovaCap);

                                    ctx.Eventos.Update(ev);
                                    ctx.SaveChanges();
                                }
                                else
                                {
                                    Console.WriteLine("Evento non trovato");
                                }

                                break;

                            case "S":

                                List<Evento> elenco = ctx.Eventos.ToList();

                                foreach (Evento eve in elenco)
                                {
                                    Console.WriteLine(eve.ToString());
                                }

                                break;

                            default:
                                Console.WriteLine("Inserimento non valido");
                                break;

                        }
                        #endregion

                    }
                    else if (input != null && input.Equals("partecipanti"))
                    {
                        #region Gestione Partecipanti
                        Console.WriteLine("Inserisci nuovo partecipante con N, aggiorna partecipante esistente con A o stampa tutti i partecipanti con S");
                        string? inputPart = Console.ReadLine();
                        switch (inputPart)
                        {

                            case "N":
                                Partecipante p = new Partecipante();

                                Console.WriteLine("Inserisci nome partecipante");
                                string? nome = Console.ReadLine();
                                p.NomePar = nome;

                                Console.WriteLine("Inserisci cognome partecipante");
                                string? cognome = Console.ReadLine();
                                p.Cognome = cognome;

                                Console.WriteLine("Inserisci telefono partecipante");
                                string? telefono = Console.ReadLine();
                                p.Telefono = telefono;

                                Console.WriteLine("Inserisci email partecipante");
                                string? email = Console.ReadLine();
                                p.Email = email;

                                ctx.Partecipantes.Add(p);
                                ctx.SaveChanges();

                                var partecipati = ctx.Partecipantes.ToList();
                                string path = "C:\\Users\\utente\\Desktop\\partecipanti.text";
                                using (StreamWriter writer = File.CreateText(path))
                                {
                                    foreach (Partecipante pa in partecipati)
                                    {
                                        writer.WriteLine(pa.ToString());
                                    }
                                }

                                break;

                            case "A":
                                Console.WriteLine("Inserisci Id partecipante da modificare");
                                string? inputChange = Console.ReadLine();

                                Partecipante? partec = ctx.Partecipantes.FirstOrDefault(part => part.IdPartecipante == Convert.ToInt32(inputChange));
                                if (partec != null)
                                {
                                    Console.WriteLine("Inserisci nuovo nome partecipante");
                                    string? nuovoNome = Console.ReadLine();
                                    nuovoNome = partec.NomePar;

                                    Console.WriteLine("Inserisci cognome partecipante");
                                    string? nuovoCogn = Console.ReadLine();
                                    nuovoCogn = partec.Cognome;

                                    Console.WriteLine("Inserisci nuovo telefono partecipante");
                                    string? nuovoTel = Console.ReadLine();
                                    partec.Telefono = nuovoTel;

                                    Console.WriteLine("Inserisci nuova email partecipante");
                                    string? nuovaEmail = Console.ReadLine();
                                    partec.Email = nuovaEmail;

                                    ctx.Partecipantes.Update(partec);
                                    ctx.SaveChanges();
                                }
                                else
                                {
                                    Console.WriteLine("Partecipante non trovato");
                                }

                                break;

                            case "S":
                                List<Partecipante> elenco = ctx.Partecipantes.ToList();

                                foreach (Partecipante pa in elenco)
                                {
                                    Console.WriteLine(pa.ToString());
                                }

                                break;

                            default:
                                Console.WriteLine("Inserimento non valido");
                                break;

                        }

                        #endregion

                    }
                }
            }
            
        }
    }
}
