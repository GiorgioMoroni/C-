using DB_Lez05_Correzione_Esercitazione03.Models;
using DB_Lez05_Correzione_Esercitazione03.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lez05_Correzione_Esercitazione03.DAL
{
    internal class UtenteDAL : IDal<Utente>
    {
        private static UtenteDAL? instance;

        private UtenteDAL() { }

        public static UtenteDAL getInstance()
        {
            if (instance == null)
            {
                instance = new UtenteDAL();
            }
            return instance;
        }



        public bool Delete(Utente t)
        {
            throw new NotImplementedException();
        }

        public Utente? Get(int id)
        {
            Utente? ute = null;

            using(SqlConnection con = new SqlConnection(Config.getInstance().getConnectionString()))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT utenteId, nome, cognome, email, codice FROM Utente WHERE utenteID = id";
                cmd.Parameters.AddWithValue("id", id);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    ute = new Utente(
                            Id = id,
                            Nome = reader[1].ToString(),
                            Cognome = Convert.ToDateTime(reader[2]),
                            Email = Convert.ToBoolean(reader[3]),
                            Codice = reader[4].ToString()
                        );

                    ;
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
            return ute;
        }

        public List<Utente> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Utente t)
        {
            throw new NotImplementedException();
        }

        public bool Update(Utente t)
        {
            throw new NotImplementedException();
        }
    }
}
