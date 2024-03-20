using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lez02_Paninoteca.Models
{
    internal class GestisciPaninoteca
    {
        public string? NomePaninoteca { get; set; }

        public string credenziali = "Server=DESKTOP-A9U90PK\\SQLEXPRESS;Database=acc_lez25_Es_paninoteca;" +
                                 "User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false";

        List<Panino> elenco = new List<Panino>();

        public GestisciPaninoteca(string? nomePaninoteca)
        {
            NomePaninoteca = nomePaninoteca;
        }


        public void ElencoPanini()
        {
            using (SqlConnection connessione = new SqlConnection(credenziali))
            {
                string query = "SELECT idPanino, Nome, Descrizione, Prezzo, Vegan FROM Panino";
                SqlCommand comando = new SqlCommand(query, connessione);

                connessione.Open();

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Panino panino = new Panino()
                    {
                        Id = Convert.ToInt32(reader[0]),
                        Nome = reader[1].ToString(),
                        Descrizione = reader[2].ToString(),
                        Prezzo = Convert.ToDecimal(reader[3]),
                        IsVegan = Convert.ToBoolean(reader[4]),
                    };
                    elenco.Add(panino);
                }
                connessione.Close();

            }

            foreach (Panino p in elenco)
            {
                Console.WriteLine($"{p.Id} {p.Nome} {p.Descrizione} {p.Prezzo} {p.IsVegan}");
            }
        }


        public void PaniniVegan()
        {

            foreach (Panino p in elenco)
            {
                if (p.IsVegan == true)
                {
                    Console.WriteLine($"{p.Id} {p.Nome} {p.Descrizione} {p.Prezzo} {p.IsVegan}");
                }

            }
        }


        public void NumeroPanini()
        {
            int contatore = 0;

            foreach (Panino p in elenco)
            {
                contatore++;

            }
            Console.WriteLine($"Nel menu ci sono {contatore} panini");
        }

        public void PrezzoMedio()
        {
            decimal prezzoMedio = elenco.Average(p => p.Prezzo);
            Console.WriteLine($"Il prezzo medio è di {prezzoMedio}");
        }


        public bool Insert(Panino pan)
        {
            bool risultato = false;

            using (SqlConnection connessione = new SqlConnection(credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connessione;
                cmd.CommandText = "INSERT INTO Panino (Nome, Descrizione, Prezzo, Vegan) VALUES (@nome, @descrizione, @prezzo, @vegan)";
                cmd.Parameters.AddWithValue("nome", pan.Nome);
                cmd.Parameters.AddWithValue("descrizione", pan.Descrizione);
                cmd.Parameters.AddWithValue("prezzo", pan.Prezzo);
                cmd.Parameters.AddWithValue("vegan", pan.IsVegan);

                try
                {
                    connessione.Open();
                    if(cmd.ExecuteNonQuery() > 0)
                    {
                        risultato = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connessione.Close();    
                }
            }
                return risultato;
        }


        public List<Panino>? FindAll()
        {
            List<Panino> panini = new List<Panino>();

            using (SqlConnection connessione = new SqlConnection(credenziali))
            {
                SqlCommand cmd = connessione.CreateCommand();
                cmd.CommandText = "SELECT idPanino, Nome, Descrizione, Prezzo, Vegan FROM Panino";

                try
                {
                    connessione.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        panini.Add(new Panino()
                        {
                            Id = Convert.ToInt32(reader["idPanino"]),
                            Nome = reader["Nome"].ToString(),
                            Descrizione = reader["Descrizione"].ToString(),
                            Prezzo = Convert.ToDecimal(reader["Prezzo"]),
                            IsVegan = Convert.ToBoolean(reader["Vegan"]),
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connessione.Close();
                }
            }

            return panini;
        }







    }
}
