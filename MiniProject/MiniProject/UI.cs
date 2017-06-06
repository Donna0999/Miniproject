using MiniProject.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProject.StyleGuide;

namespace MiniProject
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void reserveringenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReserveringenForm form = new ReserveringenForm();
            form.ShowDialog();
        }

        private void klantenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KlantenForm form = new KlantenForm();
            form.ShowDialog();
        }

        private void boekenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoekenForm form = new BoekenForm();
            form.ShowDialog();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseForm form = new BaseForm();
            form.ShowDialog();
        }
    }
}
