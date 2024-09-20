using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class Add_Schedule : Form
    {
        DateBase dateBase = new DateBase();


        public Add_Schedule()
        {
            InitializeComponent();
            // center
            // StartPosition = FormStartPosition.CenterScreen;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DoctorIsPersonalAccount mainMenu = new DoctorIsPersonalAccount();
            mainMenu.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dateBase.openConnection();

            string doctor = Doctors.SelectedValue.ToString();

            // Понеділок
            var pon = "Понеділок";
            var p1 = ponS.Text;
            var p2 = ponE.Text;
            var p3 = ponK.Text;

            string addQuery1 = $"insert into Schedule(idDoc, dayOfTheWeek, startTime, endtime, officeNumber) values('{doctor}', '{pon}', '{p1}', '{p2}', '{p3}')";
            SqlCommand command1 = new SqlCommand(addQuery1, dateBase.getConnection());

            // ExecuteNonQuery використовується для того, щоб
            // виконати процедуру без повернення результату запиту.
            command1.ExecuteNonQuery();


            // Вівторок
            var viv = "Вівторок";
            var v1 = vivS.Text;
            var v2 = vivE.Text;
            var v3 = vivK.Text;

            string addQuery2 = $"insert into Schedule(idDoc, dayOfTheWeek, startTime, endtime, officeNumber) values('{doctor}', '{viv}', '{v1}', '{v2}', '{v3}')";
            SqlCommand command2 = new SqlCommand(addQuery2, dateBase.getConnection());

            command2.ExecuteNonQuery();

            // Середа
            var ser = "Середа";
            var s1 = serS.Text;
            var s2 = serE.Text;
            var s3 = serK.Text;

            string addQuery3 = $"insert into Schedule(idDoc, dayOfTheWeek, startTime, endtime, officeNumber) values('{doctor}', '{ser}', '{s1}', '{s2}', '{s3}')";
            SqlCommand command3 = new SqlCommand(addQuery3, dateBase.getConnection());

            command3.ExecuteNonQuery();

            // Четвер
            var chet = "Четвер";
            var c1 = chetS.Text;
            var c2 = chetE.Text;
            var c3 = chetK.Text;

            string addQuery4 = $"insert into Schedule(idDoc, dayOfTheWeek, startTime, endtime, officeNumber) values('{doctor}', '{chet}', '{c1}', '{c2}', '{c3}')";
            SqlCommand command4 = new SqlCommand(addQuery4, dateBase.getConnection());
            
            command4.ExecuteNonQuery();


            // П'ятниця
            string frid = "Пятниця";
            var f1 = fridS.Text;
            var f2 = fridE.Text;
            var f3 = fridK.Text;


            // sql запит, вставляємо дані в таблицю "Розклад"
            string addQuery5 = $"insert into Schedule(idDoc, dayOfTheWeek, startTime, endtime, officeNumber) values('{doctor}', '{frid}', '{f1}', '{f2}', '{f3}')";
            SqlCommand command5 = new SqlCommand(addQuery5, dateBase.getConnection());

            command5.ExecuteNonQuery();
            MessageBox.Show("Розклад на неділю створений!", "Гарного дня!");

            this.Hide();
            DoctorIsPersonalAccount mainMenu = new DoctorIsPersonalAccount();
            mainMenu.Show();

            dateBase.closeConnection();
        }

        private void Add_Schedule_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet4.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter1.Fill(this.polyclinicDataSet4.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet3.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.polyclinicDataSet3.Doctor);
            Doctors.Text = "";
        }

        private void Doctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Doctors.SelectedValue.ToString());
        }
    }
}
