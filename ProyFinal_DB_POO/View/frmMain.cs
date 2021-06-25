using ProyFinal_DB_POO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyFinal_DB_POO
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void picVerificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAppointmentTracking form = new frmAppointmentTracking();
            form.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin form = new frmLogin();
            form.Show();
        }

        private void picLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLog form = new frmLog();
            form.Show();
        }
    }
}
