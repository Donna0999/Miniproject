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
    public class ReserveringenDAO
    {
        protected SqlConnection conn;

        public ReserveringenDAO()
        {
            string connString = ConfigurationManager
                                .ConnectionStrings["ReserveringenConnectionStringSQL"]
                                .ConnectionString;
            conn = new SqlConnection(connString);
        }

        public Reservering ReadReservering(SqlDataReader reader)
        {
            try
            {
                int id = (int)reader["Id"];

                int boekId = (int)reader["BoekId"];
                string titel = (string)reader["Titel"];
                string auteur = (string)reader["Auteur"];

                Boek boek = new Boek(boekId, titel, auteur);

                int klantid = (int)reader["KlantId"];
                string voornaam = (string)reader["Voornaam"];
                string achternaam = (string)reader["Achternaam"];
                string emailadres = (string)reader["EmailAdres"];

                Klant klant = new Klant(klantid, voornaam, achternaam, emailadres);

                DateTime reserveerdatum = (DateTime)reader["ReserveringsDatum"];

                return new Reservering(id, klant, boek, reserveerdatum);
            }
            catch
            {
                return null;
            }
        }

        public List<Reservering> GetAll()
        {
            List<Reservering> reserveringen = new List<Reservering>();

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT DonnaReserveringen.Id, DonnaKlant.Id as KlantId, DonnaKlant.Voornaam, DonnaKlant.Achternaam, DonnaKlant.EmailAdres, donnaboek.Id as BoekId, DonnaBoek.Titel, DonnaBoek.Auteur, DonnaReserveringen.ReserveringsDatum FROM DonnaReserveringen INNER JOIN DonnaKlant ON DonnaReserveringen.KlantId=DonnaKlant.Id INNER JOIN DonnaBoek ON DonnaReserveringen.BoekId=DonnaBoek.Id", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Reservering reservering = ReadReservering(reader);
                reserveringen.Add(reservering);
            }

            reader.Close();
            conn.Close();

            return reserveringen;
        }

        public Reservering GetForId(int id)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT DonnaReserveringen.Id, DonnaKlant.Id as KlantId, DonnaKlant.Voornaam, DonnaKlant.Achternaam, DonnaKlant.EmailAdres, donnaboek.Id as BoekId, DonnaBoek.Titel, DonnaBoek.Auteur, DonnaReserveringen.ReserveringsDatum FROM DonnaReserveringen INNER JOIN DonnaKlant ON DonnaReserveringen.KlantId=DonnaKlant.Id INNER JOIN DonnaBoek ON DonnaReserveringen.BoekId=DonnaBoek.Id WHERE DonnaReserveringen.Id=" + id, conn);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            Reservering reservering = ReadReservering(reader);

            reader.Close();
            conn.Close();

            return reservering;
        }

        public List<Boek> GetAllForKlant(Klant klant)
        {
            List<Boek> boeken = new List<Boek>();

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT DonnaReserveringen.Id, DonnaKlant.Id as KlantId, DonnaKlant.Voornaam, DonnaKlant.Achternaam, DonnaKlant.EmailAdres, donnaboek.Id as BoekId, DonnaBoek.Titel, DonnaBoek.Auteur, DonnaReserveringen.ReserveringsDatum FROM DonnaReserveringen INNER JOIN DonnaKlant ON DonnaReserveringen.KlantId=DonnaKlant.Id INNER JOIN DonnaBoek ON DonnaReserveringen.BoekId=DonnaBoek.Id WHERE Voornaam ='" + klant.Voornaam + "' AND Achternaam ='" + klant.Achternaam + "' AND EmailAdres ='" + klant.EmailAdres + "'", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Reservering res = ReadReservering(reader);
                boeken.Add(res.Boek);
            }

            reader.Close();
            conn.Close();

            return boeken;
        }

        public List<Klant> GetForBoek(Boek boek)
        {
            List<Klant> klanten = new List<Klant>();

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT DonnaReserveringen.Id, DonnaKlant.Id as KlantId, DonnaKlant.Voornaam, DonnaKlant.Achternaam, DonnaKlant.EmailAdres, donnaboek.Id as BoekId, DonnaBoek.Titel, DonnaBoek.Auteur, DonnaReserveringen.ReserveringsDatum FROM DonnaReserveringen INNER JOIN DonnaKlant ON DonnaReserveringen.KlantId=DonnaKlant.Id INNER JOIN DonnaBoek ON DonnaReserveringen.BoekId=DonnaBoek.Id WHERE Titel='" + boek.Titel + "' AND auteur ='" + boek.Auteur + "'", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Reservering res = ReadReservering(reader);
                klanten.Add(res.Klant);
            }

            reader.Close();
            conn.Close();

            return klanten;
        }
    }
}
