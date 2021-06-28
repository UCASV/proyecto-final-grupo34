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
        int idEmployee;
        int idCenter;

        public frmLog(int id, int id2)
        {
            InitializeComponent();
            idEmployee = id;
            idCenter = id2;

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
            this.Hide();
            frmMain form = new frmMain(idEmployee, idCenter);
            form.Show();
        }
    }
}
