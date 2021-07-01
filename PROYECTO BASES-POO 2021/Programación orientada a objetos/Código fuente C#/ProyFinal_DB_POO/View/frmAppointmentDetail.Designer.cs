
namespace ProyFinal_DB_POO
{
    partial class frmAppointmentDetail
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
            this.btnPDF = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblChequearDatos = new System.Windows.Forms.Label();
            this.lbldui = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtFechaHora = new System.Windows.Forms.Label();
            this.txtLugarVacunacion = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPDF
            // 
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.Image = global::ProyFinal_DB_POO.Properties.Resources.botonPDF;
            this.btnPDF.Location = new System.Drawing.Point(136, 337);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(160, 59);
            this.btnPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPDF.TabIndex = 11;
            this.btnPDF.TabStop = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyFinal_DB_POO.Properties.Resources.logo_covid;
            this.pictureBox1.Location = new System.Drawing.Point(79, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblChequearDatos
            // 
            this.lblChequearDatos.AutoSize = true;
            this.lblChequearDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChequearDatos.ForeColor = System.Drawing.Color.White;
            this.lblChequearDatos.Location = new System.Drawing.Point(145, 105);
            this.lblChequearDatos.Name = "lblChequearDatos";
            this.lblChequearDatos.Size = new System.Drawing.Size(127, 19);
            this.lblChequearDatos.TabIndex = 13;
            this.lblChequearDatos.Text = "Detalle de Citas";
            // 
            // lbldui
            // 
            this.lbldui.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbldui.AutoSize = true;
            this.lbldui.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldui.ForeColor = System.Drawing.Color.White;
            this.lbldui.Location = new System.Drawing.Point(58, 164);
            this.lbldui.Name = "lbldui";
            this.lbldui.Size = new System.Drawing.Size(32, 17);
            this.lbldui.TabIndex = 14;
            this.lbldui.Text = "DUI";
            this.lbldui.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nombre
            // 
            this.Nombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nombre.ForeColor = System.Drawing.Color.White;
            this.Nombre.Location = new System.Drawing.Point(58, 202);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(60, 17);
            this.Nombre.TabIndex = 15;
            this.Nombre.Text = "Nombre";
            this.Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha y Hora";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lugar de Vacunación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDUI
            // 
            this.txtDUI.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDUI.AutoSize = true;
            this.txtDUI.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDUI.ForeColor = System.Drawing.Color.White;
            this.txtDUI.Location = new System.Drawing.Point(262, 164);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(46, 17);
            this.txtDUI.TabIndex = 18;
            this.txtDUI.Text = "label3";
            this.txtDUI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(262, 202);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(46, 17);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.Text = "label4";
            this.txtNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFechaHora
            // 
            this.txtFechaHora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtFechaHora.AutoSize = true;
            this.txtFechaHora.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFechaHora.ForeColor = System.Drawing.Color.White;
            this.txtFechaHora.Location = new System.Drawing.Point(262, 246);
            this.txtFechaHora.Name = "txtFechaHora";
            this.txtFechaHora.Size = new System.Drawing.Size(46, 17);
            this.txtFechaHora.TabIndex = 20;
            this.txtFechaHora.Text = "label5";
            this.txtFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLugarVacunacion
            // 
            this.txtLugarVacunacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtLugarVacunacion.AutoSize = true;
            this.txtLugarVacunacion.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLugarVacunacion.ForeColor = System.Drawing.Color.White;
            this.txtLugarVacunacion.Location = new System.Drawing.Point(262, 290);
            this.txtLugarVacunacion.Name = "txtLugarVacunacion";
            this.txtLugarVacunacion.Size = new System.Drawing.Size(46, 17);
            this.txtLugarVacunacion.TabIndex = 21;
            this.txtLugarVacunacion.Text = "label6";
            this.txtLugarVacunacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.Location = new System.Drawing.Point(14, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(59, 26);
            this.btnMenu.TabIndex = 22;
            this.btnMenu.Text = "Menú";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmAppointmentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(429, 422);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtLugarVacunacion);
            this.Controls.Add(this.txtFechaHora);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.lbldui);
            this.Controls.Add(this.lblChequearDatos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPDF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmAppointmentDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de citas - COVID 19";
            this.Load += new System.EventHandler(this.frmAppointmentDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnPDF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblChequearDatos;
        private System.Windows.Forms.Label lbldui;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtDUI;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtFechaHora;
        private System.Windows.Forms.Label txtLugarVacunacion;
        private System.Windows.Forms.Button btnMenu;
    }
}