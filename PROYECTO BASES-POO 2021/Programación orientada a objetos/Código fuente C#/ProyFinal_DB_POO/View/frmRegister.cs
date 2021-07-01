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

namespace ProyFinal_DB_POO
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, MouseEventArgs e)
        {
            bool condicion = txtUsuario.Text.Length < 25
                && txtContra.Text.Length > 7
                && txtNombre.Text.Length > 10
                && txtCorreo.Text.Length > 6
                && txtDireccion.Text.Length > 1;

            if (condicion)
            {
                Employee user = new Employee();

                user.Username = txtUsuario.Text;
                user.Name = txtNombre.Text;
                user.Password = txtContra.Text;
                user.Email = txtCorreo.Text;
                user.Address = txtDireccion.Text;
                user.TypeId = 1;

                var Db = new ProyectContext();
                Db.Add(user);
                Db.SaveChanges();

                MessageBox.Show("Tu usuario ha sido creado");
            }
            else
                MessageBox.Show("Tus datos no son validos, vuelve a intentarlo");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin form = new frmLogin();
            form.Show();
        }
    }
}
