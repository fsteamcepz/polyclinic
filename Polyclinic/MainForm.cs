using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            // закрили вікно в якому зараз знаходимося
            this.Hide();

            // відкриваємо вікно RegisterForm
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            // закрили вікно в якому зараз знаходимося
            this.Hide();

            // перехід до наступного вікна
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // вихід з програми
            Application.Exit();
        }
    }
}
