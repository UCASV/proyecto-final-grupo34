﻿
namespace ProyFinal_DB_POO
{
    partial class frmMain
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
            this.picReservar = new System.Windows.Forms.PictureBox();
            this.picVerificar = new System.Windows.Forms.PictureBox();
            this.picVacunacion = new System.Windows.Forms.PictureBox();
            this.picLog = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picReservar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVacunacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).BeginInit();
            this.SuspendLayout();
            // 
            // picReservar
            // 
            this.picReservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReservar.Image = global::ProyFinal_DB_POO.Properties.Resources.botonHacerCita;
            this.picReservar.Location = new System.Drawing.Point(62, 75);
            this.picReservar.Name = "picReservar";
            this.picReservar.Size = new System.Drawing.Size(226, 193);
            this.picReservar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReservar.TabIndex = 0;
            this.picReservar.TabStop = false;
            // 
            // picVerificar
            // 
            this.picVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVerificar.Image = global::ProyFinal_DB_POO.Properties.Resources.botonVerificar;
            this.picVerificar.Location = new System.Drawing.Point(330, 75);
            this.picVerificar.Name = "picVerificar";
            this.picVerificar.Size = new System.Drawing.Size(226, 193);
            this.picVerificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVerificar.TabIndex = 1;
            this.picVerificar.TabStop = false;
            this.picVerificar.Click += new System.EventHandler(this.picVerificar_Click);
            // 
            // picVacunacion
            // 
            this.picVacunacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVacunacion.Image = global::ProyFinal_DB_POO.Properties.Resources.botonVacunacion;
            this.picVacunacion.Location = new System.Drawing.Point(62, 294);
            this.picVacunacion.Name = "picVacunacion";
            this.picVacunacion.Size = new System.Drawing.Size(226, 193);
            this.picVacunacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVacunacion.TabIndex = 2;
            this.picVacunacion.TabStop = false;
            // 
            // picLog
            // 
            this.picLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLog.Image = global::ProyFinal_DB_POO.Properties.Resources.botonLog;
            this.picLog.Location = new System.Drawing.Point(330, 294);
            this.picLog.Name = "picLog";
            this.picLog.Size = new System.Drawing.Size(226, 193);
            this.picLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLog.TabIndex = 3;
            this.picLog.TabStop = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(215, 20);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(186, 29);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "Menú Principal";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(620, 523);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.picLog);
            this.Controls.Add(this.picVacunacion);
            this.Controls.Add(this.picVerificar);
            this.Controls.Add(this.picReservar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.picReservar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVacunacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picReservar;
        private System.Windows.Forms.PictureBox picVerificar;
        private System.Windows.Forms.PictureBox picVacunacion;
        private System.Windows.Forms.PictureBox picLog;
        private System.Windows.Forms.Label lblMenu;
    }
}