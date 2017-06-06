using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject.Logica
{
    public partial class ReserveringenForm : Form
    {
        public ReserveringenForm()
        {
            InitializeComponent();

            ReserveringService reserveringservice = new ReserveringService();

            List<Reservering> reserveringen = reserveringservice.GetAll();

            foreach (Reservering reservering in reserveringen)
            {
                ListViewItem item = new ListViewItem(reservering.id.ToString());
                item.SubItems.Add(reservering.Klant.GetNaam());
                item.SubItems.Add(reservering.Boek.ToString());
                lstReserveringen.Items.Add(item);
            }
        }
    }
}
