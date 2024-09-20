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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorIsConfirmation doctorRegistration = new DoctorIsConfirmation();
            doctorRegistration.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientRegistration patientRegistration = new PatientRegistration();
            patientRegistration.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm backButton = new MainForm();
            backButton.Show();
            Hide();
        }
    }
}
