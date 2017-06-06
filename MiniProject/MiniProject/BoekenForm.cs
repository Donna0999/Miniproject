using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProject.Model;

namespace MiniProject.Logica
{
    public partial class BoekenForm : Form
    {
        BoekService boekservice = new BoekService();
        ReserveringService reserveringservice = new ReserveringService();
     
        public BoekenForm()
        {
            InitializeComponent();

            List<Boek> boeken = boekservice.GetAll();

            foreach (Boek boek in boeken)
            {
                cmbBoeken.Items.Add(boek.ToString());
            }

            cmbBoeken.SelectedIndex = 0;
        }

        private void cmbBoeken_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstReserveringen.Items.Clear();
            int selectedIndex = cmbBoeken.SelectedIndex;

            List<Boek> all = boekservice.GetAll();
            Boek boek = all[selectedIndex];

            List<Klant> reserveringen = reserveringservice.GetForBoek(boek);

            foreach (Klant klant in reserveringen)
            {
                lstReserveringen.Items.Add(klant.GetNaam());
            }
        }
    }
}
