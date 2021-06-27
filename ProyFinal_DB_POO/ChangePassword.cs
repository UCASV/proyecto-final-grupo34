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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void Change_Password(object sender, MouseEventArgs e)
        {
            using (var db = new parcial_finalContext())
            { 
                Employee user = new Employee();
                var name = txtuser.Text;
                try { user = db.Employees.Where(q => name.Contains(q.Username)).First(); } 
                catch { MessageBox.Show("Usuario o contraseña incorrecto"); }

                if (user.Password == txtpassword.Text)
                {
                    user.Password = txtnew.Text;
                    db.SaveChanges();
                    MessageBox.Show("guardado correctamente");
                }
                else { MessageBox.Show("Usuario o contraseña incorrecto"); }
           
            }
        }

        private void back(object sender, MouseEventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
