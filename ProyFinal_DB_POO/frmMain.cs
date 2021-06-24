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
        public frmMain(Employee user)
        {
            InitializeComponent();
        }

        private void picVerificar_Click(object sender, EventArgs e)
        {
            using (frmAppointmentTracking newForm = new frmAppointmentTracking())
            {
                DialogResult result = newForm.ShowDialog();
            }
        }
    }
}
