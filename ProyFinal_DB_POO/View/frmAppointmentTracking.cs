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
    public partial class frmAppointmentTracking : Form
    {
        public frmAppointmentTracking()
        {
            InitializeComponent();
        }

        private void btnIngresarDUI_Click(object sender, EventArgs e)
        {
            using(var db = new ProyectContext())
            {
                List<Citizen> citizens = db.Citizens.ToList();
                Int32.TryParse(txtDUI.Text, out int dui);
                
                try
                {
                    List<Citizen> result = citizens.Where(q => q.Dui == dui).ToList();
                    
                    if (result.Count > 0)
                    {
                        var database = (from q in db.Citizens where q.Dui == dui select q).First();
                        lblCitizenInfo.Text = "DUI: " + txtDUI.Text + "\r\n"
                                            + "Nombre: " + database.Name + "\r\n"
                                            + "Dirección: " + database.Address + "\r\n"
                                            + "Teléfono: " + database.Phone + "\r\n"
                                            + "Email: " + database.Email + "\r\n";
                    }
                    else
                    {
                        MessageBox.Show("Esta persona no se encuentra registrada, por favor llenar formulario correspondiente");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Esta persona no se encuentra registrada, por favor llenar formulario correspondiente");
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain form = new frmMain();
            form.Show();
        }

        private void picVacunacion_Click(object sender, EventArgs e)
        {
            using (var db = new ProyectContext())
            {
                Int32.TryParse(txtDUI.Text, out int dui);
                List<Citizen> citizens = db.Citizens.ToList();
                List<Citizen> result = citizens.Where(q => q.Dui == dui).ToList();
                
                if (result.Count > 0 && chkCondiciones.Checked)
                {
                    //Se abre form de proceso de vacunacion
                }
                else
                {
                    MessageBox.Show("Verificar si la persona ya fue registrada y si ha aceptado ser vacunada");
                }
            }
        }
    }
}
