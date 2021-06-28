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
        int idEmployee, idCenter;

        public frmMain(int id, int id2)
        {
            InitializeComponent();
            idEmployee = id;
            idCenter = id2;
        }

        private void picVerificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAppointmentTracking form = new frmAppointmentTracking(idEmployee, idCenter);
            form.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            using(var db = new ProyectContext())
            {
                Log log = db.Set<Log>().OrderBy(l => l.LogId).LastOrDefault(u => u.EmployeeId == idEmployee);
                log.LogOut = DateTime.Now;
                db.Update(log);
                db.SaveChanges();
            }

            this.Hide();
            frmLogin form = new frmLogin();
            form.Show();
        }

        private void picLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLog form = new frmLog(idEmployee, idCenter);
            form.Show();
        }

        private void picReservar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAppointmentProcess form = new frmAppointmentProcess(idEmployee, idCenter);
            form.Show();
        }
    }
}
