using MiniProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    public class Reservering
    {
        public int id { get; private set; }
        public Boek Boek { get; set; }
        public Klant Klant { get; set; }
        public DateTime ReserveerDatumTijd { get; set; }

        public Reservering(int id, Klant klant, Boek boek, DateTime resd)
        {
            this.id = id;
            this.Klant = klant;
            this.Boek = boek;
            this.ReserveerDatumTijd = resd;
        }
    }
}
