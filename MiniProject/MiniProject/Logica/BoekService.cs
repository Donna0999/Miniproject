using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject.Model;
using MiniProject.DAL;

namespace MiniProject.Logica
{
    public class BoekService
    {
        BoekDAO boekdao = new BoekDAO();

        public List<Boek> GetAll()
        {
            return boekdao.GetAll();
        }
    }
}
