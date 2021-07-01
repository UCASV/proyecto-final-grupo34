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
    public partial class frmAppointmentDetail : Form
    {
        DateTime fecha_hora;
        string lugar_vacunacion, nombre_ciudadano;
        int DUI, idEmployee, idCenter;

        public frmAppointmentDetail(DateTime dt, string lv, int dui, string nc, int id, int id2)
        {
            InitializeComponent();
            fecha_hora = dt;
            lugar_vacunacion = lv;
            DUI = dui;
            nombre_ciudadano = nc;
            idEmployee = id;
            idCenter = id2;
        }

        private void frmAppointmentDetail_Load(object sender, EventArgs e)
        {
            txtFechaHora.Text = fecha_hora.ToString();
            txtLugarVacunacion.Text = lugar_vacunacion;
            txtDUI.Text = DUI.ToString();
            txtNombre.Text = nombre_ciudadano;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain form = new frmMain(idEmployee, idCenter);
            form.Show();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream($"../../../../DetalleCita-{DUI}.pdf", FileMode.Create, FileAccess.Write)));
            Document document = new Document(pdfDocument);

            string titulo = "Detalle de la cita";
            string nombreCiu = $"Nombre del ciudadano: {nombre_ciudadano}";
            string duiCiu = $"DUI: {DUI}";
            string fechaHora = $"Fecha y hora: {fecha_hora}";
            string lugarVacu = $"Lugar de vacunacion: {lugar_vacunacion}";
            document.Add(new Paragraph(titulo));
            document.Add(new Paragraph(nombreCiu));
            document.Add(new Paragraph(duiCiu));
            document.Add(new Paragraph(fechaHora));
            document.Add(new Paragraph(lugarVacu));
            document.Close();
            MessageBox.Show("PDF creado.", "Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
