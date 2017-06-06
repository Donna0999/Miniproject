using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject.DAL;
using MiniProject.Model;

namespace MiniProject.Logica
{
    public class KlantService
    {
        private KlantDAO klantDAO = new KlantDAO();

        public List<Klant> GetAll()
        {
            return klantDAO.GetAll();
        }
    }
}
