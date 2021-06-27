
namespace ProyFinal_DB_POO.View
{
    partial class frmVaccinationProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblPasarCentro = new System.Windows.Forms.Label();
            this.gboxSegundaDosis = new System.Windows.Forms.GroupBox();
            this.btnGenerarCita2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picbVaccine = new System.Windows.Forms.PictureBox();
            this.picbTime = new System.Windows.Forms.PictureBox();
            this.picbPerson = new System.Windows.Forms.PictureBox();
            this.gboxPaciente = new System.Windows.Forms.GroupBox();
            this.txtDuiProceso = new System.Windows.Forms.TextBox();
            this.lblDuiProceso = new System.Windows.Forms.Label();
            this.gboxVacunacion = new System.Windows.Forms.GroupBox();
            this.lblHoraSintomas = new System.Windows.Forms.Label();
            this.dtpSintomas = new System.Windows.Forms.DateTimePicker();
            this.clbSintomas = new System.Windows.Forms.CheckedListBox();
            this.txtSintomasDes = new System.Windows.Forms.TextBox();
            this.dtpPrimeraDosis = new System.Windows.Forms.DateTimePicker();
            this.lblSintomas = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblHoraPrimeraDosis = new System.Windows.Forms.Label();
            this.gboxArea = new System.Windows.Forms.GroupBox();
            this.dtpLlegada = new System.Windows.Forms.DateTimePicker();
            this.lblLlegada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicioProceso = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboxSegundaDosis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbVaccine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbPerson)).BeginInit();
            this.gboxPaciente.SuspendLayout();
            this.gboxVacunacion.SuspendLayout();
            this.gboxArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.Location = new System.Drawing.Point(481, 362);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(122, 25);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // lblPasarCentro
            // 
            this.lblPasarCentro.AutoSize = true;
            this.lblPasarCentro.BackColor = System.Drawing.Color.Transparent;
            this.lblPasarCentro.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasarCentro.ForeColor = System.Drawing.Color.White;
            this.lblPasarCentro.Location = new System.Drawing.Point(7, 8);
            this.lblPasarCentro.Name = "lblPasarCentro";
            this.lblPasarCentro.Size = new System.Drawing.Size(0, 19);
            this.lblPasarCentro.TabIndex = 22;
            // 
            // gboxSegundaDosis
            // 
            this.gboxSegundaDosis.BackColor = System.Drawing.Color.Transparent;
            this.gboxSegundaDosis.Controls.Add(this.btnGenerarCita2);
            this.gboxSegundaDosis.Controls.Add(this.label2);
            this.gboxSegundaDosis.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxSegundaDosis.ForeColor = System.Drawing.Color.White;
            this.gboxSegundaDosis.Location = new System.Drawing.Point(208, 765);
            this.gboxSegundaDosis.Name = "gboxSegundaDosis";
            this.gboxSegundaDosis.Size = new System.Drawing.Size(466, 101);
            this.gboxSegundaDosis.TabIndex = 21;
            this.gboxSegundaDosis.TabStop = false;
            this.gboxSegundaDosis.Text = "Segunda dosis";
            // 
            // btnGenerarCita2
            // 
            this.btnGenerarCita2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerarCita2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerarCita2.ForeColor = System.Drawing.Color.Black;
            this.btnGenerarCita2.Location = new System.Drawing.Point(264, 42);
            this.btnGenerarCita2.Name = "btnGenerarCita2";
            this.btnGenerarCita2.Size = new System.Drawing.Size(113, 28);
            this.btnGenerarCita2.TabIndex = 1;
            this.btnGenerarCita2.Text = "Generar";
            this.btnGenerarCita2.UseVisualStyleBackColor = false;
            this.btnGenerarCita2.Click += new System.EventHandler(this.btnGenerarCita2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Generar segunda cita";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyFinal_DB_POO.Properties.Resources.calendario;
            this.pictureBox2.Location = new System.Drawing.Point(65, 765);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // picbVaccine
            // 
            this.picbVaccine.Image = global::ProyFinal_DB_POO.Properties.Resources.dosis;
            this.picbVaccine.Location = new System.Drawing.Point(66, 451);
            this.picbVaccine.Name = "picbVaccine";
            this.picbVaccine.Size = new System.Drawing.Size(115, 99);
            this.picbVaccine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbVaccine.TabIndex = 19;
            this.picbVaccine.TabStop = false;
            // 
            // picbTime
            // 
            this.picbTime.Image = global::ProyFinal_DB_POO.Properties.Resources.reloj;
            this.picbTime.Location = new System.Drawing.Point(66, 243);
            this.picbTime.Name = "picbTime";
            this.picbTime.Size = new System.Drawing.Size(115, 99);
            this.picbTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbTime.TabIndex = 18;
            this.picbTime.TabStop = false;
            // 
            // picbPerson
            // 
            this.picbPerson.Image = global::ProyFinal_DB_POO.Properties.Resources.persona2;
            this.picbPerson.Location = new System.Drawing.Point(66, 106);
            this.picbPerson.Name = "picbPerson";
            this.picbPerson.Size = new System.Drawing.Size(115, 99);
            this.picbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbPerson.TabIndex = 17;
            this.picbPerson.TabStop = false;
            // 
            // gboxPaciente
            // 
            this.gboxPaciente.BackColor = System.Drawing.Color.Transparent;
            this.gboxPaciente.Controls.Add(this.txtDuiProceso);
            this.gboxPaciente.Controls.Add(this.lblDuiProceso);
            this.gboxPaciente.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxPaciente.ForeColor = System.Drawing.Color.White;
            this.gboxPaciente.Location = new System.Drawing.Point(208, 106);
            this.gboxPaciente.Name = "gboxPaciente";
            this.gboxPaciente.Size = new System.Drawing.Size(466, 99);
            this.gboxPaciente.TabIndex = 16;
            this.gboxPaciente.TabStop = false;
            this.gboxPaciente.Text = "Paciente";
            // 
            // txtDuiProceso
            // 
            this.txtDuiProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtDuiProceso.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDuiProceso.Location = new System.Drawing.Point(250, 41);
            this.txtDuiProceso.Name = "txtDuiProceso";
            this.txtDuiProceso.Size = new System.Drawing.Size(168, 28);
            this.txtDuiProceso.TabIndex = 1;
            // 
            // lblDuiProceso
            // 
            this.lblDuiProceso.AutoSize = true;
            this.lblDuiProceso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuiProceso.Location = new System.Drawing.Point(201, 42);
            this.lblDuiProceso.Name = "lblDuiProceso";
            this.lblDuiProceso.Size = new System.Drawing.Size(43, 23);
            this.lblDuiProceso.TabIndex = 0;
            this.lblDuiProceso.Text = "DUI";
            // 
            // gboxVacunacion
            // 
            this.gboxVacunacion.BackColor = System.Drawing.Color.Transparent;
            this.gboxVacunacion.Controls.Add(this.lblHoraSintomas);
            this.gboxVacunacion.Controls.Add(this.dtpSintomas);
            this.gboxVacunacion.Controls.Add(this.clbSintomas);
            this.gboxVacunacion.Controls.Add(this.txtSintomasDes);
            this.gboxVacunacion.Controls.Add(this.dtpPrimeraDosis);
            this.gboxVacunacion.Controls.Add(this.lblSintomas);
            this.gboxVacunacion.Controls.Add(this.lblObservaciones);
            this.gboxVacunacion.Controls.Add(this.lblHoraPrimeraDosis);
            this.gboxVacunacion.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxVacunacion.ForeColor = System.Drawing.Color.White;
            this.gboxVacunacion.Location = new System.Drawing.Point(208, 393);
            this.gboxVacunacion.Name = "gboxVacunacion";
            this.gboxVacunacion.Size = new System.Drawing.Size(466, 352);
            this.gboxVacunacion.TabIndex = 15;
            this.gboxVacunacion.TabStop = false;
            this.gboxVacunacion.Text = "Vacunacion";
            // 
            // lblHoraSintomas
            // 
            this.lblHoraSintomas.AutoSize = true;
            this.lblHoraSintomas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraSintomas.Location = new System.Drawing.Point(49, 184);
            this.lblHoraSintomas.Name = "lblHoraSintomas";
            this.lblHoraSintomas.Size = new System.Drawing.Size(195, 23);
            this.lblHoraSintomas.TabIndex = 8;
            this.lblHoraSintomas.Text = "Hora de los sintomas";
            // 
            // dtpSintomas
            // 
            this.dtpSintomas.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpSintomas.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpSintomas.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpSintomas.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpSintomas.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpSintomas.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpSintomas.CustomFormat = "dd/MM/yy hh:mm";
            this.dtpSintomas.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpSintomas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSintomas.Location = new System.Drawing.Point(250, 180);
            this.dtpSintomas.Name = "dtpSintomas";
            this.dtpSintomas.Size = new System.Drawing.Size(168, 28);
            this.dtpSintomas.TabIndex = 7;
            // 
            // clbSintomas
            // 
            this.clbSintomas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.clbSintomas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbSintomas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clbSintomas.FormattingEnabled = true;
            this.clbSintomas.Location = new System.Drawing.Point(250, 226);
            this.clbSintomas.Name = "clbSintomas";
            this.clbSintomas.Size = new System.Drawing.Size(168, 112);
            this.clbSintomas.TabIndex = 6;
            // 
            // txtSintomasDes
            // 
            this.txtSintomasDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSintomasDes.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSintomasDes.Location = new System.Drawing.Point(250, 86);
            this.txtSintomasDes.Multiline = true;
            this.txtSintomasDes.Name = "txtSintomasDes";
            this.txtSintomasDes.Size = new System.Drawing.Size(168, 77);
            this.txtSintomasDes.TabIndex = 5;
            // 
            // dtpPrimeraDosis
            // 
            this.dtpPrimeraDosis.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpPrimeraDosis.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpPrimeraDosis.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpPrimeraDosis.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpPrimeraDosis.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpPrimeraDosis.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpPrimeraDosis.CustomFormat = "dd/MM/yy hh:mm";
            this.dtpPrimeraDosis.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpPrimeraDosis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPrimeraDosis.Location = new System.Drawing.Point(250, 41);
            this.dtpPrimeraDosis.Name = "dtpPrimeraDosis";
            this.dtpPrimeraDosis.Size = new System.Drawing.Size(168, 28);
            this.dtpPrimeraDosis.TabIndex = 4;
            // 
            // lblSintomas
            // 
            this.lblSintomas.AutoSize = true;
            this.lblSintomas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSintomas.Location = new System.Drawing.Point(153, 262);
            this.lblSintomas.Name = "lblSintomas";
            this.lblSintomas.Size = new System.Drawing.Size(91, 23);
            this.lblSintomas.TabIndex = 2;
            this.lblSintomas.Text = "Sintomas";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblObservaciones.Location = new System.Drawing.Point(103, 108);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(141, 23);
            this.lblObservaciones.TabIndex = 1;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // lblHoraPrimeraDosis
            // 
            this.lblHoraPrimeraDosis.AutoSize = true;
            this.lblHoraPrimeraDosis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraPrimeraDosis.Location = new System.Drawing.Point(18, 46);
            this.lblHoraPrimeraDosis.Name = "lblHoraPrimeraDosis";
            this.lblHoraPrimeraDosis.Size = new System.Drawing.Size(226, 23);
            this.lblHoraPrimeraDosis.TabIndex = 0;
            this.lblHoraPrimeraDosis.Text = "Hora de la primera dosis";
            // 
            // gboxArea
            // 
            this.gboxArea.BackColor = System.Drawing.Color.Transparent;
            this.gboxArea.Controls.Add(this.dtpLlegada);
            this.gboxArea.Controls.Add(this.lblLlegada);
            this.gboxArea.Controls.Add(this.label1);
            this.gboxArea.Controls.Add(this.dtpInicioProceso);
            this.gboxArea.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxArea.ForeColor = System.Drawing.Color.White;
            this.gboxArea.Location = new System.Drawing.Point(208, 222);
            this.gboxArea.Name = "gboxArea";
            this.gboxArea.Size = new System.Drawing.Size(466, 129);
            this.gboxArea.TabIndex = 14;
            this.gboxArea.TabStop = false;
            this.gboxArea.Text = "Area de espera";
            // 
            // dtpLlegada
            // 
            this.dtpLlegada.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpLlegada.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpLlegada.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpLlegada.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpLlegada.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpLlegada.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpLlegada.CustomFormat = "dd/MM/yy hh:mm";
            this.dtpLlegada.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLlegada.Location = new System.Drawing.Point(250, 51);
            this.dtpLlegada.Name = "dtpLlegada";
            this.dtpLlegada.Size = new System.Drawing.Size(168, 28);
            this.dtpLlegada.TabIndex = 3;
            // 
            // lblLlegada
            // 
            this.lblLlegada.AutoSize = true;
            this.lblLlegada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLlegada.Location = new System.Drawing.Point(106, 55);
            this.lblLlegada.Name = "lblLlegada";
            this.lblLlegada.Size = new System.Drawing.Size(138, 23);
            this.lblLlegada.TabIndex = 2;
            this.lblLlegada.Text = "Hora de la cita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora de inicio del proceso";
            // 
            // dtpInicioProceso
            // 
            this.dtpInicioProceso.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpInicioProceso.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpInicioProceso.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpInicioProceso.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpInicioProceso.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpInicioProceso.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpInicioProceso.CustomFormat = "dd/MM/yy hh:mm";
            this.dtpInicioProceso.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpInicioProceso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicioProceso.Location = new System.Drawing.Point(250, 92);
            this.dtpInicioProceso.Name = "dtpInicioProceso";
            this.dtpInicioProceso.Size = new System.Drawing.Size(168, 28);
            this.dtpInicioProceso.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyFinal_DB_POO.Properties.Resources.logoGobierno;
            this.pictureBox1.Location = new System.Drawing.Point(208, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmVaccinationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(862, 879);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblPasarCentro);
            this.Controls.Add(this.gboxSegundaDosis);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picbVaccine);
            this.Controls.Add(this.picbTime);
            this.Controls.Add(this.picbPerson);
            this.Controls.Add(this.gboxPaciente);
            this.Controls.Add(this.gboxVacunacion);
            this.Controls.Add(this.gboxArea);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVaccinationProcess";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de vacunacion";
            this.Load += new System.EventHandler(this.frmVaccinationProcess_Load_1);
            this.gboxSegundaDosis.ResumeLayout(false);
            this.gboxSegundaDosis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbVaccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbPerson)).EndInit();
            this.gboxPaciente.ResumeLayout(false);
            this.gboxPaciente.PerformLayout();
            this.gboxVacunacion.ResumeLayout(false);
            this.gboxVacunacion.PerformLayout();
            this.gboxArea.ResumeLayout(false);
            this.gboxArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblPasarCentro;
        private System.Windows.Forms.GroupBox gboxSegundaDosis;
        private System.Windows.Forms.Button btnGenerarCita2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picbVaccine;
        private System.Windows.Forms.PictureBox picbTime;
        private System.Windows.Forms.PictureBox picbPerson;
        private System.Windows.Forms.GroupBox gboxPaciente;
        private System.Windows.Forms.TextBox txtDuiProceso;
        private System.Windows.Forms.Label lblDuiProceso;
        private System.Windows.Forms.GroupBox gboxVacunacion;
        private System.Windows.Forms.Label lblHoraSintomas;
        private System.Windows.Forms.DateTimePicker dtpSintomas;
        private System.Windows.Forms.CheckedListBox clbSintomas;
        private System.Windows.Forms.TextBox txtSintomasDes;
        private System.Windows.Forms.DateTimePicker dtpPrimeraDosis;
        private System.Windows.Forms.Label lblSintomas;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblHoraPrimeraDosis;
        private System.Windows.Forms.GroupBox gboxArea;
        private System.Windows.Forms.DateTimePicker dtpLlegada;
        private System.Windows.Forms.Label lblLlegada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicioProceso;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}