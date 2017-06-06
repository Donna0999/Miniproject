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
    public class BoekDAO
    {
        protected SqlConnection conn;

        public BoekDAO()
        {
            string connString = ConfigurationManager
                .ConnectionStrings["ReserveringenConnectionStringSQL"]
                .ConnectionString;
            conn = new SqlConnection(connString);
        }

        public Boek ReadBoek(SqlDataReader reader)
        {
            try
            {
                int id = (int)reader["Id"];
                string titel = (string)reader["Titel"];
                string auteur = (string)reader["Auteur"];

                return new Boek(id, titel, auteur);
            }
            catch
            {
                return null;
            }
        }

        public List<Boek> GetAll()
        {
            List<Boek> boeken = new List<Boek>();

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM DonnaBoek", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Boek boek = ReadBoek(reader);
                boeken.Add(boek);
            }

            reader.Close();
            conn.Close();

            return boeken;
        }

        public Boek GetForId(int id)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM DonnaBoek WHERE id=" + id, conn);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            Boek boek = ReadBoek(reader);

            reader.Close();
            conn.Close();

            return boek;
        }
    }
}
