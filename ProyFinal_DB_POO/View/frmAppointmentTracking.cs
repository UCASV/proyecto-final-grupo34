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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;

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
                        MessageBox.Show("Esta persona no se encuentra registrada, por favor llenar formulario correspondiente.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Esta persona no se encuentra registrada, por favor llenar formulario correspondiente.");
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
                    MessageBox.Show("Verificar si la persona ya fue registrada o si ha aceptado ser vacunada.");
                }
            }
        }

        private void picPDF_Click(object sender, EventArgs e)
        {
            var db = new ProyectContext();

            Int32.TryParse(txtDUI.Text, out int dui);
            List<Citizen> citizens = db.Citizens.ToList();

            try
            {
                List<Citizen> result = citizens.Where(q => q.Dui == dui).ToList();

                if (result.Count > 0)
                {
                    var database = (from q in db.Citizens where q.Dui == dui select q).First();

                    PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream($"../../../../DetalleCita-{txtDUI.Text}.pdf", FileMode.Create, FileAccess.Write)));
                    Document document = new Document(pdfDocument);

                    string title = "DETALLE DE CITA PARA VACUNACIÓN - COVID 19";
                    string name = $"Nombre: {database.Name}";
                    string duiPDF = $"DUI: {txtDUI.Text}";
                    //string datetime = $"Fecha y hora de primera cita: {fecha_hora}";
                    //string place = $"Lugar de vacunación: {lugar_vacunacion}";

                    document.Add(new Paragraph(title));
                    document.Add(new Paragraph(name));
                    document.Add(new Paragraph(duiPDF));
                    //document.Add(new Paragraph(datetime));
                    //document.Add(new Paragraph(place));
                    document.Close();
                    MessageBox.Show("PDF creado y guardado.", "Cita para vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Esta persona no se encuentra registrada, por favor llenar formulario correspondiente.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Esta persona no se encuentra registrada, por favor llenar formulario correspondiente.");
            }
        }
    }
}
