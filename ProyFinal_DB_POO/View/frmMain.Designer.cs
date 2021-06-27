
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
            this.picLog = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picReservar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).BeginInit();
            this.SuspendLayout();
            // 
            // picReservar
            // 
            this.picReservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReservar.Image = global::ProyFinal_DB_POO.Properties.Resources.botonHacerCita;
            this.picReservar.Location = new System.Drawing.Point(72, 100);
            this.picReservar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picReservar.Name = "picReservar";
            this.picReservar.Size = new System.Drawing.Size(258, 257);
            this.picReservar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReservar.TabIndex = 0;
            this.picReservar.TabStop = false;
            this.picReservar.Click += new System.EventHandler(this.picReservar_Click);
            // 
            // picVerificar
            // 
            this.picVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVerificar.Image = global::ProyFinal_DB_POO.Properties.Resources.botonVerificar;
            this.picVerificar.Location = new System.Drawing.Point(378, 100);
            this.picVerificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picVerificar.Name = "picVerificar";
            this.picVerificar.Size = new System.Drawing.Size(258, 257);
            this.picVerificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVerificar.TabIndex = 1;
            this.picVerificar.TabStop = false;
            this.picVerificar.Click += new System.EventHandler(this.picVerificar_Click);
            // 
            // picLog
            // 
            this.picLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLog.Image = global::ProyFinal_DB_POO.Properties.Resources.botonLog;
            this.picLog.Location = new System.Drawing.Point(72, 416);
            this.picLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picLog.Name = "picLog";
            this.picLog.Size = new System.Drawing.Size(258, 257);
            this.picLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLog.TabIndex = 3;
            this.picLog.TabStop = false;
            this.picLog.Click += new System.EventHandler(this.picLog_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(246, 31);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(227, 35);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "Menú Principal";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.Location = new System.Drawing.Point(378, 524);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(258, 45);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(709, 723);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.picLog);
            this.Controls.Add(this.picVerificar);
            this.Controls.Add(this.picReservar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            ((System.ComponentModel.ISupportInitialize)(this.picReservar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picReservar;
        private System.Windows.Forms.PictureBox picVerificar;
        private System.Windows.Forms.PictureBox picLog;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}