
namespace ProyFinal_DB_POO
{
    partial class frmAppointmentTracking
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblChequearDatos = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.btnIngresarDUI = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCitizenInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkCondiciones = new System.Windows.Forms.CheckBox();
            this.picVacunacion = new System.Windows.Forms.PictureBox();
            this.picPDF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVacunacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyFinal_DB_POO.Properties.Resources.logo_covid;
            this.pictureBox1.Location = new System.Drawing.Point(204, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblChequearDatos
            // 
            this.lblChequearDatos.AutoSize = true;
            this.lblChequearDatos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChequearDatos.ForeColor = System.Drawing.Color.White;
            this.lblChequearDatos.Location = new System.Drawing.Point(250, 135);
            this.lblChequearDatos.Name = "lblChequearDatos";
            this.lblChequearDatos.Size = new System.Drawing.Size(206, 22);
            this.lblChequearDatos.TabIndex = 1;
            this.lblChequearDatos.Text = "Seguimiento de Citas";
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDUI.ForeColor = System.Drawing.Color.White;
            this.lblDUI.Location = new System.Drawing.Point(225, 178);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(38, 18);
            this.lblDUI.TabIndex = 2;
            this.lblDUI.Text = "DUI:";
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtDUI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDUI.Location = new System.Drawing.Point(269, 173);
            this.txtDUI.MaxLength = 9;
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(206, 26);
            this.txtDUI.TabIndex = 3;
            this.txtDUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIngresarDUI
            // 
            this.btnIngresarDUI.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarDUI.Location = new System.Drawing.Point(293, 215);
            this.btnIngresarDUI.Name = "btnIngresarDUI";
            this.btnIngresarDUI.Size = new System.Drawing.Size(127, 31);
            this.btnIngresarDUI.TabIndex = 4;
            this.btnIngresarDUI.Text = "Verificar";
            this.btnIngresarDUI.UseVisualStyleBackColor = true;
            this.btnIngresarDUI.Click += new System.EventHandler(this.btnIngresarDUI_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(40, 21);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(93, 33);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCitizenInfo
            // 
            this.lblCitizenInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCitizenInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCitizenInfo.Location = new System.Drawing.Point(67, 299);
            this.lblCitizenInfo.Multiline = true;
            this.lblCitizenInfo.Name = "lblCitizenInfo";
            this.lblCitizenInfo.ReadOnly = true;
            this.lblCitizenInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblCitizenInfo.Size = new System.Drawing.Size(287, 153);
            this.lblCitizenInfo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Información del ciudadano:";
            // 
            // chkCondiciones
            // 
            this.chkCondiciones.AutoSize = true;
            this.chkCondiciones.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkCondiciones.ForeColor = System.Drawing.Color.White;
            this.chkCondiciones.Location = new System.Drawing.Point(76, 482);
            this.chkCondiciones.Name = "chkCondiciones";
            this.chkCondiciones.Size = new System.Drawing.Size(567, 18);
            this.chkCondiciones.TabIndex = 8;
            this.chkCondiciones.Text = "He leído de los posibles efectos secundarios y aceptado los términos para comenza" +
    "r el proceso de vacunación.";
            this.chkCondiciones.UseVisualStyleBackColor = true;
            // 
            // picVacunacion
            // 
            this.picVacunacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVacunacion.Image = global::ProyFinal_DB_POO.Properties.Resources.botonVacunacion;
            this.picVacunacion.Location = new System.Drawing.Point(422, 299);
            this.picVacunacion.Name = "picVacunacion";
            this.picVacunacion.Size = new System.Drawing.Size(258, 64);
            this.picVacunacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVacunacion.TabIndex = 9;
            this.picVacunacion.TabStop = false;
            this.picVacunacion.Click += new System.EventHandler(this.picVacunacion_Click);
            // 
            // picPDF
            // 
            this.picPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPDF.Image = global::ProyFinal_DB_POO.Properties.Resources.botonPDF;
            this.picPDF.Location = new System.Drawing.Point(422, 388);
            this.picPDF.Name = "picPDF";
            this.picPDF.Size = new System.Drawing.Size(259, 64);
            this.picPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPDF.TabIndex = 10;
            this.picPDF.TabStop = false;
            this.picPDF.Click += new System.EventHandler(this.picPDF_Click);
            // 
            // frmAppointmentTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(716, 532);
            this.Controls.Add(this.picPDF);
            this.Controls.Add(this.picVacunacion);
            this.Controls.Add(this.chkCondiciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCitizenInfo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnIngresarDUI);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.lblChequearDatos);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAppointmentTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguimiento de citas - COVID 19";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVacunacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblChequearDatos;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btnIngresarDUI;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox lblCitizenInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCondiciones;
        private System.Windows.Forms.PictureBox picVacunacion;
        private System.Windows.Forms.PictureBox picPDF;
    }
}