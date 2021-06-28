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
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace ProyFinal_DB_POO
{
    public partial class frmAppointmentDetail2 : Form
    {
        public Appointment cita2 { get; set; }
        
        public frmAppointmentDetail2(Appointment cita2)
        {
            InitializeComponent();
            this.cita2 = cita2;
        }

        private void frmAppointmentDetail2_Load(object sender, EventArgs e)
        {
            txtDUI2.Text = cita2.Dui.ToString();
            txtFechaHora2.Text = cita2.DateTime.ToString();
            txtLugarVacunacion2.Text = cita2.Center.VaccinationCenter1;
        }

        private void btnPDF2_Click(object sender, EventArgs e)
        {
            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream($"../../../../DetalleSegundaDosis-{cita2.Dui}.pdf", FileMode.Create, FileAccess.Write)));
            Document document = new Document(pdfDocument);

            String titulo = "Detalle de segunda dosis";
            String duiCiu = $"DUI: {cita2.Dui}";
            String fechaHora = $"Fecha y hora: {cita2.DateTime}";
            String lugarVacu = $"Lugar de vacunacion: {cita2.Center.VaccinationCenter1}";
            document.Add(new Paragraph(titulo));
            document.Add(new Paragraph(duiCiu));
            document.Add(new Paragraph(fechaHora));
            document.Add(new Paragraph(lugarVacu));
            document.Close();
            MessageBox.Show("PDF creado.", "Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Employee user = new Employee();

            this.Hide();
            frmMain form = new frmMain(user.EmployeeId);
            form.Show();
        }
    }
}
