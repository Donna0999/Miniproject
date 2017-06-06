using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Model
{
    public class Boek
    {
        public int id { get; private set; }
        public string Titel { get; set; }
        public string Auteur { get; set; }
        

        public Boek(int id, string titel, string auteur)
        {
            this.id = id;
            this.Titel = titel;
            this.Auteur = auteur;
        }

        public override string ToString()
        {
            string boek = Titel + " - " + Auteur;

            return boek;
        }
    }
}
