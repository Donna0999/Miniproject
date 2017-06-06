using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject.Model;
using System.Data.SqlClient;
using System.Configuration;

namespace MiniProject.DAL
{
    public class KlantDAO
    {
        protected SqlConnection conn;

        public KlantDAO()
        {
            string connString = ConfigurationManager
                    .ConnectionStrings["ReserveringenConnectionStringSQL"]
                    .ConnectionString;
            conn = new SqlConnection(connString);
        }

        public Klant ReadKlant(SqlDataReader reader)
        {
            try
            {
                int id = (int)reader["Id"];
                string voornaam = (string)reader["Voornaam"];
                string achternaam = (string)reader["Achternaam"];
                string email = (string)reader["EmailAdres"];

                return new Klant(id, voornaam, achternaam, email);
            }
            catch
            {
                return null;
            }

        }

        public List<Klant> GetAll()
        {
            List<Klant> klanten = new List<Klant>();

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM DonnaKlant", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Klant klant = ReadKlant(reader);
                klanten.Add(klant);
            }

            reader.Close();
            conn.Close();
            return klanten;
        }

        public Klant GetForId(int id)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM DonnaKlant WHERE Id=" + id, conn);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            Klant klant = ReadKlant(reader);

            reader.Close();
            conn.Close();

            return klant;
        }
    }
}
