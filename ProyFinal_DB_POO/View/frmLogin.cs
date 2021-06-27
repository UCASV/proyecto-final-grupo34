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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Check(object sender, MouseEventArgs e)
        {
            if (txtUserTB.Text.Length == 0 || txtPasswordTB.Text.Length == 0)
            {
                MessageBox.Show("Ingrese su usuario o contraseña correctamente");
                txtUserTB.Focus();
            }
            else
            {
                login();
            }
        }

        private void login()
        {
            using (var db = new ProyectContext())
            {
                Employee user = new Employee();
                var name = txtUserTB.Text;

                try
                {
                    user = db.Employees.Where(q => name.Contains(q.Username)).First();
                    if (user.Password == txtPasswordTB.Text)
                    {
                        log(user.Booth, user);

                        //Codigo para abrir form main
                        frmMain form = new frmMain(user.EmployeeId);
                        this.Hide();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nombre o contraseña incorrecta");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Nombre o Contraseña incorrecta");
                }
            }
        }

        private void OpenChangePassword(object sender, MouseEventArgs e)
        {

            //Codigo para abrir form de cambio de contraseñas
            frmChangePassword form = new frmChangePassword();
            form.Show();
            this.Hide();
        }

        private void OpenRegister(object sender, MouseEventArgs e)
        {
            frmRegister form = new frmRegister();
            form.Show();
            this.Hide();
        }

        private void log(Booth cabina, Employee empleado)
        {
            var Db = new ProyectContext();

            Log log = new Log();
            log.EmployeeId = empleado.EmployeeId;
            log.LogIn = System.DateTime.Now;
            log.LogOut = System.DateTime.Now;

            if (empleado.BoothId == null)
            {
                log.BoothId = 1;
            }
            else
            {
                log.BoothId = empleado.BoothId.Value;
            }

            Db.Add(log);
            Db.SaveChanges();
        }
    }
}
