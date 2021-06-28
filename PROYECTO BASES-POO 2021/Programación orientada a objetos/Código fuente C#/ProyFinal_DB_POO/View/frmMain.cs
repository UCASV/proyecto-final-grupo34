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
        int idEmployee;

        public frmMain(int id)
        {
            InitializeComponent();
            idEmployee = id;
        }

        private void picVerificar_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            VaccinationCenter vaccCenter = new VaccinationCenter();

            this.Hide();
            frmAppointmentTracking form = new frmAppointmentTracking(appointment.DateTime, vaccCenter.VaccinationCenter1);
            form.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            using (var db = new ProyectContext())
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
            frmLog form = new frmLog();
            form.Show();
        }

        private void picReservar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAppointmentProcess form = new frmAppointmentProcess();
            form.Show();
        }
    }
}
