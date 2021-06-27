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
                        MessageBox.Show("entra 1");
                        log(user.Booth, user);
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

            //codigo para abrir form Para cambio de contraseñas
            ChangePassword form = new ChangePassword();
            form.Show();
            this.Hide();
        }

        private void OpenRegister(object sender, MouseEventArgs e)
        {
            Register form = new Register();
            form.Show();
            this.Hide();
        }

        private void log(Booth cabina, Employee empleado)
        {
            MessageBox.Show("entra 2");
            var Db = new parcial_finalContext();
            
            Log log = new Log ();
            log.EmployeeId = empleado.EmployeeId;
            log.LogIn= System.DateTime.Now;
            log.LogOut = System.DateTime.Now;
            if (empleado.BoothId == null)
            {
                log.BoothId = 1;
            }
            else
            {
                log.BoothId = empleado.BoothId.Value;
            }
            MessageBox.Show("entra 3");

            Db.Add(log);
            Db.SaveChanges();
            MessageBox.Show("entra 4");
        }
    }
}
