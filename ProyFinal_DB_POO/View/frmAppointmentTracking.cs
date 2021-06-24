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
    public partial class frmAppointmentTracking : Form
    {
        public frmAppointmentTracking()
        {
            InitializeComponent();
        }

        private void btnIngresarDUI_Click(object sender, EventArgs e)
        {
            using (frmShowingInfo newForm = new frmShowingInfo())
            {
                DialogResult result = newForm.ShowDialog();
            }
        }
    }
}
