using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Model
{
    public class Klant
    {
        public int id { get; private set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string EmailAdres { get; set; }

        public Klant(int id, string voornaam, string achternaam, string emailAdres)
        {
            this.id = id;
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.EmailAdres = emailAdres;
        }

        public string GetNaam()
        {
            string naam = Voornaam + " " + Achternaam;

            return naam;
        }
    }
}
