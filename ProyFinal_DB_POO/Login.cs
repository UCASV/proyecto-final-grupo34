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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Check(object sender, MouseEventArgs e)
        {
            if (UserTB.Text.Length == 0 || PasswordTB.Text.Length == 0)
            {
                MessageBox.Show("ingrese su usuario o su contraseña Correctamente");
                UserTB.Focus();
            }
            else
            {
                login();
            }
        }

        private void login()
        {
            using (var db = new parcial_finalContext())
            {
                Employee user = new Employee();
                var name = UserTB.Text;
                try
                {
                    user = db.Employees.Where(q => name.Contains(q.Username)).First();
                    if (user.Password == PasswordTB.Text)
                    {
                        //codigo para abrir form main
                        Form1 form = new Form1(user);
                        this.Hide();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nombre o Contraseña Incorrecta");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Nombre o Contraseña Incorrecta");

                }
            }
        }
        private void OpenChangePassword(object sender, MouseEventArgs e)
        {
            this.Close();
            //codigo para abrir form Para cambio de contraseñas
        }

        private void OpenRegister(object sender, MouseEventArgs e)
        {
            this.Close();
            //codigo para abrir form de registro de usuarios
        }
    }
}
