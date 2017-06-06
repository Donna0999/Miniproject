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
    public partial class KlantenForm : Form
    {
        // comboBox1 is waar de klanten in geselecteerd worden
        private KlantService klantService = new KlantService();
        private ReserveringService reserveringService = new ReserveringService();

        public KlantenForm()
        {
            InitializeComponent();
            List<Klant> klanten = klantService.GetAll();

            foreach (Klant klant in klanten)
            {
                comboBox1.Items.Add(klant.GetNaam());
            }
            comboBox1.SelectedIndex = 0;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Reserveringen.Items.Clear();

            int selecteditemID = comboBox1.SelectedIndex;

            List<Klant> all = klantService.GetAll();
            Klant klant = all[selecteditemID];

            List<Boek> res = reserveringService.GetAllForKlant(klant);

            if (res.Count > 0)
            {
                foreach (Boek boek in res)
                {
                    lb_Reserveringen.Items.Add(boek.Titel + " - " + boek.Auteur);
                }
            }
            else {
                lb_Reserveringen.Items.Add("Geen reserveringen."); }
        }
    }
}
