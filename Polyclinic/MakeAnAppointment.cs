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
    public partial class MakeAnAppointment : Form
    {
        public MakeAnAppointment()
        {
            InitializeComponent();
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

        private void button5_Click(object sender, EventArgs e)
        {
            // вихід з програми
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PatientIsPersonalAccount mainMenu = new PatientIsPersonalAccount();
            mainMenu.Show();
            Hide();
        }

        private void dateTimeD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MakeAnAppointment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet19.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter2.Fill(this.polyclinicDataSet19.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet18.Schedule". При необходимости она может быть перемещена или удалена.
            this.scheduleTableAdapter.Fill(this.polyclinicDataSet18.Schedule);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet14.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.polyclinicDataSet14.Doctor);

            spec_box.Text = "";
            doctor_box.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string spec = spec_box.Text;

            if (spec == "" || spec.Length == 0)
            {
                MessageBox.Show("Виберіть спеціальність!");
                this.spec_box.BackColor = System.Drawing.Color.LawnGreen;
                return;
            }
            this.spec_box.BackColor = System.Drawing.Color.White;

            string doctor_name = doctor_box.Text;

            if (doctor_name == "" || doctor_name.Length == 0)
            {
                MessageBox.Show("Виберіть лікаря!");
                this.doctor_box.BackColor = System.Drawing.Color.LawnGreen;
                return;
            }
            this.doctor_box.BackColor = System.Drawing.Color.White;

            var dateOfBirthday = date_box.Value.ToString("dd:MM:yyyy");

            MessageBox.Show("Ви успішно записалися!\n" +
                            "Лікарь — " + doctor_name + ".\n" +
                            "Спецільність — " + spec + ".\n" +
                            "Дата — " + dateOfBirthday, "Вітаємо!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Hide();
            PatientIsPersonalAccount mainMenu = new PatientIsPersonalAccount();
            mainMenu.Show();
        }

        private void viewAllDoc_Click(object sender, EventArgs e)
        {
            viewAllDoctors view = new viewAllDoctors();
            view.Show();
        }
    }
}
