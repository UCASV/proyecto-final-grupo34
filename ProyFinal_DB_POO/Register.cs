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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }


        private void btnCrearUsuario_Click(object sender, MouseEventArgs e)
        {
            bool condicion = txtusuario.Text.Length < 25
                && txtcontra.Text.Length > 7
                && txtnombre.Text.Length > 10
                && txtcorreo.Text.Length > 6
                && txtdireccion.Text.Length > 1;

            if (condicion)
            {
                Employee user = new Employee();

                user.Username = txtusuario.Text;
                user.Name = txtnombre.Text;
                user.Password = txtcontra.Text;
                user.Email = txtcorreo.Text;
                user.Address = txtdireccion.Text;
                user.TypeId = 1;

                var Db = new parcial_finalContext();
                Db.Add(user);
                Db.SaveChanges();

                MessageBox.Show("Tu usuario ha sido creado.");
            }
            else
                MessageBox.Show("Tus datos no son validos, vuelve a intentarlo.");
        }

        private void close(object sender, MouseEventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }
    }
}
