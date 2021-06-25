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
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            using(var db = new ProyectContext())
            {
                var database = (from x in db.Logs select x).ToList();
                dgvLogTable.DataSource = database;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Employee user = new Employee();
            this.Hide();
            frmMain form = new frmMain();
            form.Show();
        }
    }
}
