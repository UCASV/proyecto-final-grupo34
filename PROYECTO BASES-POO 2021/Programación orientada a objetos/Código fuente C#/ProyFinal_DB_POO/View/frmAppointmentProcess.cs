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
    public partial class frmAppointmentProcess : Form
    {
        public frmAppointmentProcess()
        {
            InitializeComponent();
        }

        private void frmAppointmentProcess_Load(object sender, EventArgs e)
        {
            var db = new ProyectContext();
            var dataSet = db.Diseases.ToList();
            ((ListBox)checkedListBox1).DataSource = dataSet;
            ((ListBox)checkedListBox1).DisplayMember = "Disease1";
            ((ListBox)checkedListBox1).ValueMember = "DiseaseId";
        }

        private int CalcularEdad()
        {
            DateTime fecha_nacimiento = dateTimePicker1.Value;
            DateTime hoy = DateTime.Now;
            int edad = hoy.Year - fecha_nacimiento.Year;
            if (hoy.DayOfYear < fecha_nacimiento.DayOfYear) edad--;
            return edad;
        }

        private List<Disease> getSelectedValues()
        {
            List<Disease> values = new List<Disease>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    Disease d = (Disease)checkedListBox1.Items[i];
                    values.Add(d);
                }
            }
            return values;
        }

        private DateTime getFechaCita()
        {
            Random r = new Random();
            DateTime hoy = DateTime.Now;
            DateTime final = new DateTime(2022, 1, 1);
            int rango = (final - hoy).Days;
            return hoy.AddDays(r.Next(rango)).AddHours(r.Next(9, 16)).AddMinutes(r.Next(0, 60)).AddSeconds(r.Next(0, 60));
        }

        private void AgendarCita_Click(object sender, EventArgs e)
        {
            var db = new ProyectContext();
            Random r = new Random();

            var datosVacios = (string.IsNullOrEmpty(textBoxDui.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxNombre.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxDomicilio.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxTelefono.Text.Trim()));

            if (!datosVacios)
            {
                List<Disease> enfermedades = getSelectedValues();
                int edad = CalcularEdad();
                if (!string.IsNullOrEmpty(textBoxid.Text.Trim()) || edad > 60 || (edad > 18 && enfermedades.Count > 0))
                {
                    List<Appointment> citas = db.Appointments.ToList();
                    int dui_ciudadano = Convert.ToInt32(textBoxDui.Text);
                    var citas_encontradas = citas
                        .Where(c => c.Dui == dui_ciudadano)
                        .ToList();

                    if (citas_encontradas.Count > 0)
                    {
                        MessageBox.Show("Ya ha iniciado un proceso de cita anteriormente.", "Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Citizen nuevo = new Citizen();
                        nuevo.Dui = dui_ciudadano;
                        nuevo.Name = textBoxNombre.Text;
                        nuevo.Address = textBoxDomicilio.Text;
                        nuevo.Phone = textBoxTelefono.Text;
                        nuevo.Email = textBoxCorreo.Text;

                        if (!string.IsNullOrEmpty(textBoxid.Text.Trim()))
                        {
                            nuevo.EssentialJob = Convert.ToInt32(textBoxid.Text);
                        }

                        db.Add(nuevo);
                        db.SaveChanges();

                        for (int i = 0; i < enfermedades.Count; i++)
                        {
                            Diseasexcitizen dc = new Diseasexcitizen();
                            dc.DiseaseId = enfermedades[i].DiseaseId;
                            dc.CitizenId = dui_ciudadano;
                            db.Add(dc);
                            db.SaveChanges();
                        }

                        List<VaccinationCenter> vc = db.VaccinationCenters.ToList();
                        int posicion = r.Next(vc.Count);
                        VaccinationCenter vc_elegida = vc[posicion];

                        Citizen cdbb = db.Set<Citizen>()
                            .SingleOrDefault(c => c.Dui == dui_ciudadano);

                        VaccinationCenter vcdbb = db.Set<VaccinationCenter>()
                            .SingleOrDefault(v => v.CenterId == vc_elegida.CenterId);

                        Appointment nueva_cita = new Appointment();
                        nueva_cita.DateTime = getFechaCita();
                        nueva_cita.CenterId = vc_elegida.CenterId;
                        nueva_cita.Dui = dui_ciudadano;
                        nueva_cita.QueueStart = nueva_cita.DateTime;
                        nueva_cita.VaccinationTime = nueva_cita.DateTime;
                        nueva_cita.DuiNavigation = cdbb;
                        nueva_cita.Center = vcdbb;


                        db.Add(nueva_cita);
                        db.SaveChanges();

                        MessageBox.Show("Cita creada exitosamente", "Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();

                        frmAppointmentDetail ventana = new frmAppointmentDetail(nueva_cita.DateTime, vc_elegida.VaccinationCenter1, dui_ciudadano, nuevo.Name);
                        ventana.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Aún no es tiempo para que reserves tu cita", "Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
