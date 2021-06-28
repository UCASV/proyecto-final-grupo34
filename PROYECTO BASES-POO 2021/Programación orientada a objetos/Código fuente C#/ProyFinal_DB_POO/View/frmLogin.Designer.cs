
namespace ProyFinal_DB_POO
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtUserTB = new System.Windows.Forms.TextBox();
            this.txtPasswordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnCambiarContra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarSesion.Location = new System.Drawing.Point(106, 223);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(165, 31);
            this.btnIniciarSesion.TabIndex = 0;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Check);
            // 
            // txtUserTB
            // 
            this.txtUserTB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserTB.Location = new System.Drawing.Point(80, 53);
            this.txtUserTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUserTB.Name = "txtUserTB";
            this.txtUserTB.Size = new System.Drawing.Size(218, 26);
            this.txtUserTB.TabIndex = 1;
            // 
            // txtPasswordTB
            // 
            this.txtPasswordTB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordTB.Location = new System.Drawing.Point(80, 139);
            this.txtPasswordTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPasswordTB.Name = "txtPasswordTB";
            this.txtPasswordTB.PasswordChar = '*';
            this.txtPasswordTB.Size = new System.Drawing.Size(218, 26);
            this.txtPasswordTB.TabIndex = 2;
            this.txtPasswordTB.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarse.Location = new System.Drawing.Point(106, 276);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(165, 31);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OpenRegister);
            // 
            // btnCambiarContra
            // 
            this.btnCambiarContra.BackColor = System.Drawing.SystemColors.Control;
            this.btnCambiarContra.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCambiarContra.Location = new System.Drawing.Point(106, 328);
            this.btnCambiarContra.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCambiarContra.Name = "btnCambiarContra";
            this.btnCambiarContra.Size = new System.Drawing.Size(165, 32);
            this.btnCambiarContra.TabIndex = 6;
            this.btnCambiarContra.Text = "Cambiar contraseña";
            this.btnCambiarContra.UseVisualStyleBackColor = false;
            this.btnCambiarContra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OpenChangePassword);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(371, 392);
            this.Controls.Add(this.btnCambiarContra);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswordTB);
            this.Controls.Add(this.txtUserTB);
            this.Controls.Add(this.btnIniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión - Módulo de gestores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtUserTB;
        private System.Windows.Forms.TextBox txtPasswordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnCambiarContra;
    }
}

