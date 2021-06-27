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

namespace ProyFinal_DB_POO.View
{
    public partial class frmVaccinationProcess : Form
    {
        public frmVaccinationProcess()
        {
            InitializeComponent();
        }

        private void frmVaccinationProcess_Load(object sender, EventArgs e)
        {
            
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

        private void btnGenerarCita2_Click(object sender, EventArgs e)
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
                .Where(r => r.AppointmentId == AppointmentId)
                .ToList();

            if (resultado.Count() > 0)
            {
                for (int i = 0; i < sintomas.Count; i++)
                {
                    AppointmentxSideEffect axs = new AppointmentxSideEffect();
                    axs.EffectId = sintomas[i].EffectId;
                    axs.Description = txtSintomasDes.Text;
                    db.Add(axs);
                    db.SaveChanges();
                    MessageBox.Show("Actualizado", "Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var db = new ProyectContext();

            List<Appointment> appointments = db.Appointments
                .ToList();

            int AppointmentId = Convert.ToInt32((txtDuiProceso.Text));

            //VERIFICAR SI EXISTE EL PASIENTE EN LA BD
            List<Appointment> resultado = appointments
                .Where(r => r.AppointmentId == AppointmentId)
                .ToList();

            if (resultado.Count() > 0)
            {
                Appointment adbb = db.Set<Appointment>()
                    .SingleOrDefault(a => a.AppointmentId == AppointmentId);

                adbb.QueueStart = dtpInicioProceso.Value;
                adbb.VaccinationTime = dtpPrimeraDosis.Value;

                db.Update(adbb);
                db.SaveChanges();
                MessageBox.Show("horas actualizadas", "Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}