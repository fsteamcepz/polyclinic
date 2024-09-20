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
    public partial class PatientIsPersonalAccount : Form
    {
        public PatientIsPersonalAccount()
        {
            // Метод, який ініціалізує всі компоненти, які розташовані на
            // формі (DoctorIsPersonalAccount): поля, кнопки, меню, перемикачі
            InitializeComponent();

            pib_pat.Text = LoginForm.p_PIB;

            pib_pat2.Text = PatientRegistration.p_PIB;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeAnAppointment viewP = new MakeAnAppointment();
            viewP.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // вихід з програми
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainForm backButton = new MainForm();
            backButton.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindADoctor viewP = new FindADoctor();
            viewP.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetAService viewP = new GetAService();
            viewP.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            PatientIsPersonalAccount mainMenu = new PatientIsPersonalAccount();
            mainMenu.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // вихід з програми
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeAnAppointment viewP = new MakeAnAppointment();
            viewP.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindADoctor viewP = new FindADoctor();
            viewP.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetAService viewP = new GetAService();
            viewP.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MainForm backButton = new MainForm();
            backButton.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("З прийдешнім Новим Роком");
        }
    }
}
