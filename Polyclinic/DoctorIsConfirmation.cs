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
    public partial class DoctorIsConfirmation : Form
    {
        public DoctorIsConfirmation()
        {
            InitializeComponent();
            PassConDoc.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string confrimPass = PassConDoc.Text;
            string a = "Паляниця";

            if (confrimPass == " " || confrimPass.Length == 0 || confrimPass != a)
            {
                MessageBox.Show("Пароль не вірний!");
                return;
            }

            this.Hide();
            DoctorRegistration doctorRegistration = new DoctorRegistration();
            doctorRegistration.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm doctorRegistration = new RegisterForm();
            doctorRegistration.Show();
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)       // пароль вимк.
            {
                PassConDoc.UseSystemPasswordChar = false;
            }
            else
            {
                PassConDoc.UseSystemPasswordChar = true;
            }
        }
    }
}
