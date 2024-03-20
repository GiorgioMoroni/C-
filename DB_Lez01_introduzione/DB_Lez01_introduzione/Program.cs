using DB_Lez01_introduzione.Models;
using System.Data.SqlClient;

namespace DB_Lez01_introduzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string credenziali = "Server=DESKTOP-A9U90PK\\SQLEXPRESS;Database=acc_lez24_citta;" +
                                 "User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false";

            #region ELENCO CITTA
            List<Citta> list = new List<Citta>();

            using (SqlConnection connessione = new SqlConnection(credenziali))
            {
                string query = "SELECT cittaID, nome, prov FROM Citta";
                SqlCommand comando = new SqlCommand(query, connessione);

                connessione.Open();

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]}");     //POSIZIONALE PER COLONNA (IN QUESTO CASO MI SI POSIZIONA SU cittaId
                    Citta citta = new Citta()
                    {
                        Id = Convert.ToInt32(reader[0]),
                        Nome = reader[1].ToString(),
                        Provincia = reader[2].ToString()
                    };
                    list.Add(citta);
                }
                connessione.Close();

            }

            foreach(Citta citta in list)
            {
                Console.WriteLine($"{citta.Nome} {citta.Provincia} {citta.Id}");
            }
            #endregion

            #region INSERISCI CITTA
            //string nome = "Pineto";
            //string prov = "PE";
            //using (SqlConnection con = new SqlConnection(credenziali))
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandText = "INSERT INTO Citta(nome, prov) VALUES (@nomeCitta, @provCitta)";
            //    cmd.Parameters.AddWithValue("@nomeCitta", nome);
            //    cmd.Parameters.AddWithValue("@provCitta", prov);

            //    try
            //    {
            //        con.Open();

            //        int affRows = cmd.ExecuteNonQuery();        //Mi ritorna un intero con il numero di righe interessate
            //        if (affRows > 0)                            //Se il numero di righe è > 0...
            //        {
            //            Console.WriteLine("Stappoooo, inserimento ok");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Errore");
            //        }

            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Connessione chiusa");
            //        con.Close();                                //In questo modo sia se è andato a buon fine oppure no chiude la connessione
            //    }



            //}
            #endregion

            #region ELIMINA CITTA

            //int idDaEliminare = 3;

            //using (SqlConnection conn = new SqlConnection(credenziali))
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = conn;
            //    cmd.CommandText = "DELETE FROM Citta WHERE cittaId = 3";
            //    cmd.Parameters.AddWithValue("@idValue", idDaEliminare);

            //    try
            //    {
            //        conn.Open();

            //        int affRows = cmd.ExecuteNonQuery();
            //        if(affRows > 0)
            //        {
            //            Console.WriteLine("STAPPO");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Errore");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message );
            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }

            //}

            #endregion

            #region MODIFICA CITTA

            Citta cit = new Citta()
            {
                Id = 2,
                Provincia = "AQU"
            };

            using (SqlConnection conn = new SqlConnection(credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE Citta SET prov = @provValue WHERE cittaId = @idValue";
                cmd.Parameters.AddWithValue("@provValue", cit.Provincia);
                cmd.Parameters.AddWithValue("@idValue", cit.Id);

                try
                {
                    conn.Open();

                    //int affRows = cmd.ExecuteNonQuery();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("STAPPO");
                    }
                    else
                    {
                        Console.WriteLine("Errore");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }



            }

            #endregion

        }
    }
}
