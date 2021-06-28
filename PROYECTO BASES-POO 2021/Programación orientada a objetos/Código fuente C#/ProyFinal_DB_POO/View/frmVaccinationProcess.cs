using Microsoft.EntityFrameworkCore;
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
    public partial class frmVaccinationProcess : Form
    {
        public frmVaccinationProcess()
        {
            InitializeComponent();
        }

        private List<SideEffect> getSelectedValues()
        {
            List<SideEffect> values = new List<SideEffect>();
            for (int i = 0; i < clbSintomas.Items.Count; i++)
            {
                if (clbSintomas.GetItemChecked(i))
                {
                    SideEffect s = (SideEffect)clbSintomas.Items[i];
                    values.Add(s);
                }
            }
            return values;
        }

        private void frmVaccinationProcess_Load_1(object sender, EventArgs e)
        {
            var db = new ProyectContext();
            var SideEffects = db.SideEffects
                .ToList();
            clbSintomas.DataSource = SideEffects;
            clbSintomas.DisplayMember = "SideEffect1";
            clbSintomas.ValueMember = "EffectId";
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            var db = new ProyectContext();

            List<Appointment> appointments = db.Appointments
                .ToList();

            int AppointmentId = Convert.ToInt32((txtDuiProceso.Text));

            //VERIFICAR SI EXISTE EL PACIENTE EN LA BD
            List<Appointment> resultado = appointments
                .Where(r => r.Dui == AppointmentId)
                .ToList();

            if (resultado.Count() > 0)
            {
                Appointment adbb = db.Set<Appointment>()
                    .SingleOrDefault(a => a.Dui == AppointmentId);

                adbb.QueueStart = dtpInicioProceso.Value;
                adbb.VaccinationTime = dtpPrimeraDosis.Value;

                db.Update(adbb);
                db.SaveChanges();
                MessageBox.Show("horas actualizadas", "Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("horas no actualizadas", "Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerarCita2_Click_1(object sender, EventArgs e)
        {
            var db = new ProyectContext();

            List<AppointmentxSideEffect> appointxside = db.AppointmentxSideEffects
                .ToList();
            List<Appointment> appointments = db.Appointments
                .ToList();
            List<SideEffect> sintomas = getSelectedValues();

            int AppointmentId = Convert.ToInt32((txtDuiProceso.Text));

            //VERIFICAR SI EXISTE EL PASIENTE EN LA BD
            List<Appointment> resultado = appointments
                .Where(r => r.Dui == AppointmentId)
                .ToList();

            if (resultado.Count() > 0)
            {
                for (int i = 0; i < sintomas.Count; i++)
                {
                    AppointmentxSideEffect axs = new AppointmentxSideEffect();
                    axs.EffectId = sintomas[i].EffectId;
                    axs.AppointmentId = resultado[0].AppointmentId;
                    axs.Description = txtSintomasDes.Text;
                    axs.Time = dtpSintomas.Value;
                    db.Add(axs);
                    db.SaveChanges();
                    MessageBox.Show("Segunda cita realizada", "Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Appointment cita2 = new Appointment();
                cita2.Dui = AppointmentId;
                DateTime cita1 = resultado[0].DateTime;
                cita2.DateTime = cita1.AddDays(6 * 7);
                cita2.Center = db.Set<VaccinationCenter>()
                    .SingleOrDefault(v => v.CenterId == resultado[0].CenterId);

                frmAppointmentDetail2 ventana = new frmAppointmentDetail2(cita2);
                ventana.Show();
                this.Hide();
                MessageBox.Show("base actualizada", "Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("base no actualizada", "Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Employee user = new Employee();

            this.Hide();
            frmMain form = new frmMain(user.EmployeeId);
            form.Show();
        }
    }
}
