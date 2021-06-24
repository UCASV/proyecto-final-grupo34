
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyFinal_DB_POO.Properties.Resources.logo_covid;
            this.pictureBox1.Location = new System.Drawing.Point(161, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblChequearDatos
            // 
            this.lblChequearDatos.AutoSize = true;
            this.lblChequearDatos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChequearDatos.ForeColor = System.Drawing.Color.White;
            this.lblChequearDatos.Location = new System.Drawing.Point(250, 213);
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
            this.lblDUI.Location = new System.Drawing.Point(206, 256);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(38, 18);
            this.lblDUI.TabIndex = 2;
            this.lblDUI.Text = "DUI:";
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtDUI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDUI.Location = new System.Drawing.Point(250, 251);
            this.txtDUI.MaxLength = 9;
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(256, 26);
            this.txtDUI.TabIndex = 3;
            this.txtDUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIngresarDUI
            // 
            this.btnIngresarDUI.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarDUI.Location = new System.Drawing.Point(290, 300);
            this.btnIngresarDUI.Name = "btnIngresarDUI";
            this.btnIngresarDUI.Size = new System.Drawing.Size(132, 31);
            this.btnIngresarDUI.TabIndex = 4;
            this.btnIngresarDUI.Text = "Verificar";
            this.btnIngresarDUI.UseVisualStyleBackColor = true;
            this.btnIngresarDUI.Click += new System.EventHandler(this.btnIngresarDUI_Click);
            // 
            // frmAppointmentTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(716, 532);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblChequearDatos;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btnIngresarDUI;
    }
}