using Esercitazione03_20_03_2024.Models;
using Esercitazione03_20_03_2024.Utilites;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione03_20_03_2024.DAL
{
    internal class LibroDAL : IDal<Libro>
    {
        private static LibroDAL? istanza;

        private LibroDAL() { }

        public static LibroDAL getIstanza()
        {
            if (istanza == null)
            {
                istanza = new LibroDAL();
            }
            return istanza;
        }


        public bool Delete(Libro t)
        {
            bool risultato = false;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand sqlCommand = con.CreateCommand();
                sqlCommand.CommandText = "DELETE FROM Libro WHERE IdLibro = @valIdLibro";
                sqlCommand.Parameters.AddWithValue("@valIdLibro", t.Id);

                try
                {
                    con.Open();
                    if (sqlCommand.ExecuteNonQuery() > 0)
                        risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            return risultato;
        }

        public Libro Get(int id)
        {
            bool risultato = false;
            Libro lib = new Libro() ;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand sqlCommand = con.CreateCommand();
                sqlCommand.CommandText = $"SELECT IdLibro, Titolo, AnnoPubblicazione, IsDisponibile FROM Libro";
                //sqlCommand.Parameters.AddWithValue("@valIdLibro", id);
                //sqlCommand.Parameters.AddWithValue("@valTitolo", lib.Titolo);
                //sqlCommand.Parameters.AddWithValue("@valAnno", lib.AnnoPubblicazione);
                //sqlCommand.Parameters.AddWithValue("@valDisp", lib.IsDisponibile);

                try
                {
                    con.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        lib =(new Libro()
                        {
                            Id = id,
                            Titolo = reader["Titolo"].ToString(),
                            AnnoPubblicazione = Convert.ToDateTime(reader["AnnoPubblicazione"]),
                            IsDisponibile = Convert.ToBoolean(reader["IsDisponibile"]),
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            return lib;
        }

        public List<Libro> GetAll()
        {
            List<Libro> lista = new List<Libro>();

            using (SqlConnection connessione = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand cmd = connessione.CreateCommand();
                cmd.CommandText = "SELECT IdLibro, Titolo, AnnoPubblicazione, IsDisponibile FROM Libro";

                try
                {
                    connessione.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lista.Add(new Libro()
                        {
                            Id = Convert.ToInt32(reader["IdLibro"]),
                            Titolo = reader["Titolo"].ToString(),
                            AnnoPubblicazione = Convert.ToDateTime(reader["AnnoPubblicazione"]),
                            IsDisponibile = Convert.ToBoolean(reader["IsDisponibile"]),
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

            return lista;
        }

        public bool Insert(Libro t)
        {
            bool risultato = false;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand sqlCommand = con.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO Libro(Titolo, AnnoPubblicazione, IsDisponibile) VALUES (@valTitolo, @valAnno, @valDisp)";
                sqlCommand.Parameters.AddWithValue("@valTitolo", t.Titolo);
                sqlCommand.Parameters.AddWithValue("@valAnno", t.AnnoPubblicazione);
                sqlCommand.Parameters.AddWithValue("@valDisp", t.IsDisponibile);

                try
                {
                    con.Open();
                    if (sqlCommand.ExecuteNonQuery() > 0)
                        risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            return risultato;
        }

        public bool Update(Libro t)
        {
            throw new NotImplementedException();
        }
    }
}
