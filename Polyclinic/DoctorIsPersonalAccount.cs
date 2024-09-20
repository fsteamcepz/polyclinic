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
    public partial class DoctorIsPersonalAccount : Form
    {
        public DoctorIsPersonalAccount()
        {
            // Метод, який ініціалізує всі компоненти, які розташовані на
            // формі (DoctorIsPersonalAccount): поля, кнопки, меню, перемикачі
            InitializeComponent();

            pib_doc.Text = LoginForm.d_PIB;

            pib_doc2.Text = DoctorRegistration.d_PIB;
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
            DoctorIsPatients viewD = new DoctorIsPatients();
            viewD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleForTheWeek viewD = new ScheduleForTheWeek();
            viewD.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionHistoryOfDoctor viewD = new ReceptionHistoryOfDoctor();
            viewD.Show();
        }

        private void pib_doc_Click(object sender, EventArgs e)
        {

        }

        private void pib_doc2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("З прийдешнім Новим Роком");
        }
    }
}
