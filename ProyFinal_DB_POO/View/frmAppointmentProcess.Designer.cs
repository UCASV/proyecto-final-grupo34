
namespace ProyFinal_DB_POO
{
    partial class frmAppointmentProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointmentProcess));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblChequearDatos = new System.Windows.Forms.Label();
            this.DUI = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.FechaNacimiento = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.Label();
            this.NumIdentificador = new System.Windows.Forms.Label();
            this.Enfermedades = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDui = new System.Windows.Forms.TextBox();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.AgendarCita = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgendarCita)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyFinal_DB_POO.Properties.Resources.logo_covid;
            this.pictureBox1.Location = new System.Drawing.Point(145, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblChequearDatos
            // 
            this.lblChequearDatos.AutoSize = true;
            this.lblChequearDatos.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChequearDatos.ForeColor = System.Drawing.Color.White;
            this.lblChequearDatos.Location = new System.Drawing.Point(246, 161);
            this.lblChequearDatos.Name = "lblChequearDatos";
            this.lblChequearDatos.Size = new System.Drawing.Size(200, 27);
            this.lblChequearDatos.TabIndex = 2;
            this.lblChequearDatos.Text = "Proceso de Citas";
            // 
            // DUI
            // 
            this.DUI.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DUI.AutoSize = true;
            this.DUI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DUI.ForeColor = System.Drawing.Color.White;
            this.DUI.Location = new System.Drawing.Point(45, 219);
            this.DUI.Name = "DUI";
            this.DUI.Size = new System.Drawing.Size(43, 23);
            this.DUI.TabIndex = 3;
            this.DUI.Text = "DUI";
            this.DUI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nombre
            // 
            this.Nombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nombre.ForeColor = System.Drawing.Color.White;
            this.Nombre.Location = new System.Drawing.Point(45, 256);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(79, 23);
            this.Nombre.TabIndex = 4;
            this.Nombre.Text = "Nombre";
            this.Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FechaNacimiento.AutoSize = true;
            this.FechaNacimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.FechaNacimiento.Location = new System.Drawing.Point(45, 297);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(191, 23);
            this.FechaNacimiento.TabIndex = 5;
            this.FechaNacimiento.Text = "Fecha de nacimiento";
            this.FechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Direccion
            // 
            this.Direccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Direccion.ForeColor = System.Drawing.Color.White;
            this.Direccion.Location = new System.Drawing.Point(45, 331);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(258, 23);
            this.Direccion.TabIndex = 6;
            this.Direccion.Text = "Direccion de domicilio actual";
            this.Direccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Telefono
            // 
            this.Telefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Telefono.ForeColor = System.Drawing.Color.White;
            this.Telefono.Location = new System.Drawing.Point(45, 373);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(193, 23);
            this.Telefono.TabIndex = 7;
            this.Telefono.Text = "Telefono de contacto";
            this.Telefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Correo
            // 
            this.Correo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Correo.AutoSize = true;
            this.Correo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Correo.ForeColor = System.Drawing.Color.White;
            this.Correo.Location = new System.Drawing.Point(45, 411);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(264, 23);
            this.Correo.TabIndex = 8;
            this.Correo.Text = "Correo electronico (opcional)";
            this.Correo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumIdentificador
            // 
            this.NumIdentificador.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumIdentificador.AutoSize = true;
            this.NumIdentificador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumIdentificador.ForeColor = System.Drawing.Color.White;
            this.NumIdentificador.Location = new System.Drawing.Point(45, 449);
            this.NumIdentificador.Name = "NumIdentificador";
            this.NumIdentificador.Size = new System.Drawing.Size(282, 23);
            this.NumIdentificador.TabIndex = 9;
            this.NumIdentificador.Text = "Numero identificador (opcional)";
            this.NumIdentificador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Enfermedades
            // 
            this.Enfermedades.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Enfermedades.AutoSize = true;
            this.Enfermedades.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Enfermedades.ForeColor = System.Drawing.Color.White;
            this.Enfermedades.Location = new System.Drawing.Point(45, 490);
            this.Enfermedades.Name = "Enfermedades";
            this.Enfermedades.Size = new System.Drawing.Size(291, 23);
            this.Enfermedades.TabIndex = 10;
            this.Enfermedades.Text = "Lista de enfermedades cronicas";
            this.Enfermedades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(409, 490);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(183, 136);
            this.checkedListBox1.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dateTimePicker1.CustomFormat = "dd/MM/yy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(409, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 27);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // textBoxDui
            // 
            this.textBoxDui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxDui.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDui.Location = new System.Drawing.Point(409, 219);
            this.textBoxDui.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDui.MaxLength = 9;
            this.textBoxDui.Name = "textBoxDui";
            this.textBoxDui.Size = new System.Drawing.Size(183, 30);
            this.textBoxDui.TabIndex = 21;
            this.textBoxDui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxDomicilio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDomicilio.Location = new System.Drawing.Point(409, 328);
            this.textBoxDomicilio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDomicilio.MaxLength = 9;
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(183, 30);
            this.textBoxDomicilio.TabIndex = 22;
            this.textBoxDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxCorreo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCorreo.Location = new System.Drawing.Point(409, 404);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCorreo.MaxLength = 9;
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(183, 30);
            this.textBoxCorreo.TabIndex = 23;
            this.textBoxCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTelefono.Location = new System.Drawing.Point(409, 366);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTelefono.MaxLength = 9;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(183, 30);
            this.textBoxTelefono.TabIndex = 24;
            this.textBoxTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxid
            // 
            this.textBoxid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxid.Location = new System.Drawing.Point(409, 442);
            this.textBoxid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxid.MaxLength = 9;
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(183, 30);
            this.textBoxid.TabIndex = 25;
            this.textBoxid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombre.Location = new System.Drawing.Point(409, 256);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.MaxLength = 9;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(183, 30);
            this.textBoxNombre.TabIndex = 26;
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AgendarCita
            // 
            this.AgendarCita.Image = global::ProyFinal_DB_POO.Properties.Resources.WhatsApp_Image_2021_06_25_at_6_47_05_PM__1_;
            this.AgendarCita.Location = new System.Drawing.Point(90, 563);
            this.AgendarCita.Name = "AgendarCita";
            this.AgendarCita.Size = new System.Drawing.Size(202, 81);
            this.AgendarCita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AgendarCita.TabIndex = 27;
            this.AgendarCita.TabStop = false;
            this.AgendarCita.Click += new System.EventHandler(this.AgendarCita_Click);
            // 
            // frmAppointmentProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(668, 690);
            this.Controls.Add(this.AgendarCita);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxDomicilio);
            this.Controls.Add(this.textBoxDui);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Enfermedades);
            this.Controls.Add(this.NumIdentificador);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.FechaNacimiento);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.DUI);
            this.Controls.Add(this.lblChequearDatos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAppointmentProcess";
            this.Text = "Proceso de citas - COVID 19";
            this.Load += new System.EventHandler(this.frmAppointmentProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgendarCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblChequearDatos;
        private System.Windows.Forms.Label DUI;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label FechaNacimiento;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.Label NumIdentificador;
        private System.Windows.Forms.Label Enfermedades;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxDui;
        private System.Windows.Forms.TextBox textBoxDomicilio;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.PictureBox AgendarCita;
    }
}