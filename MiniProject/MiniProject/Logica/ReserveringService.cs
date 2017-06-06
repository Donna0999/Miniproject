using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject.Model;
using MiniProject.DAL;

namespace MiniProject.Logica
{
    public class ReserveringService
    {
        private ReserveringenDAO reserveringDAO = new ReserveringenDAO();

        public List<Reservering> GetAll()
        {
            return reserveringDAO.GetAll();
        }

        public List<Boek> GetAllForKlant(Klant klant)
        {
            return reserveringDAO.GetAllForKlant(klant);
        }

        public List<Klant> GetForBoek(Boek boek)
        {
            return reserveringDAO.GetForBoek(boek);
        }
    }
}
