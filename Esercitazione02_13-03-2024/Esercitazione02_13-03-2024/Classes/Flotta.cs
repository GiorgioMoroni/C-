using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione02_13_03_2024.Classes
{
    internal class Flotta
    {
        public string? Nome { get; set; }

        public List<Veicolo> elenco { get; set; } = new List<Veicolo>();

        public Flotta(string? nome)
        {
            Nome = nome;
        }


        public void Aggiungi(Veicolo veicolo)
        {
            elenco.Add(veicolo);
        }

        public void Rimuovi(Veicolo veicolo)
        {
            elenco.Remove(veicolo);
        }


        public void VisualizzaFlotta()
        {
            if (elenco.Count > 0)
            {
                foreach (Veicolo ve in elenco)
                {
                    ve.stampaDettaglio();
                }
            }
            else
            {
                Console.WriteLine("Flotta vuota");
            }
            
        }


        public void SlavaFlotta()
        {
            string path = "C:\\Users\\utente\\Desktop\\flotta.txt";

            try
            {

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        foreach(Veicolo ve in elenco)
                        {
                            sw.WriteLine(ve.stampaDettaglio());
                            
                        }
                        
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        foreach (Veicolo ve in elenco)
                        {
                            sw.WriteLine(ve.stampaDettaglio());
                            
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void LeggiFile()
        {
            string lettura = "C:\\Users\\utente\\Desktop\\flotta.txt";
            try
            {
                using (StreamReader sr = new StreamReader(lettura))
                {
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }






    }
}
