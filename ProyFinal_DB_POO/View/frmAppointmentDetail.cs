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
        String lugar_vacunacion, nombre_ciudadano;
        int DUI;

        public frmAppointmentDetail(DateTime dt, String lv, int dui, String nc)
        {
            InitializeComponent();
            fecha_hora = dt;
            lugar_vacunacion = lv;
            DUI = dui;
            nombre_ciudadano = nc;
        }

        private void frmAppointmentDetail_Load(object sender, EventArgs e)
        {
            txtFechaHora.Text = fecha_hora.ToString();
            txtLugarVacunacion.Text = lugar_vacunacion;
            txtDUI.Text = DUI.ToString();
            txtNombre.Text = nombre_ciudadano;
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream($"../../../../DetalleCita-{DUI}.pdf", FileMode.Create, FileAccess.Write)));
            Document document = new Document(pdfDocument);

            String titulo = "Detalle de la cita";
            String nombreCiu = $"Nombre del ciudadano: {nombre_ciudadano}";
            String duiCiu = $"DUI: {DUI}";
            String fechaHora = $"Fecha y hora: {fecha_hora}";
            String lugarVacu = $"Lugar de vacunacion: {lugar_vacunacion}";
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