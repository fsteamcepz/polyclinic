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
    public partial class FindADoctor : Form
    {
        DateBase dateBase = new DateBase();

        public FindADoctor()
        {
            InitializeComponent();

            CreateColums();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeAnAppointment viewP = new MakeAnAppointment();
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

        // додавання колонок в таблицю doctor
        public void CreateColums()
        {
            // рядки по центру
            DataGridViewCellStyle style = searchBox.ColumnHeadersDefaultCellStyle;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // автопідбір ширини стовпців за вмістом
            searchBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            searchBox.Columns.Add("idDoctor", "№");
            searchBox.Columns.Add("fullNameDoc", "ПІБ лікаря");
            searchBox.Columns.Add("telDoc", "Телефон");
            searchBox.Columns.Add("emailDoc", "Пошта");
            searchBox.Columns.Add("addressDoc", "Адреса");
            searchBox.Columns.Add("dateBirthdayDoc", "Дата народження");
            searchBox.Columns.Add("experience", "Стаж");
            searchBox.Columns.Add("specialization", "Спеціалізація");
        }

        private void readSingleRow2(DataGridView line, IDataRecord record)
        {
            // додавання рядка(ів) в таблицю
            line.Rows.Add(record.GetInt32(0),
                          record.GetString(1),
                          record.GetString(3),
                          record.GetString(4),
                          record.GetString(6),
                          record.GetDateTime(7),
                          record.GetInt32(9),
                          record.GetString(10));
        }

        private void Search(DataGridView line)
        {
            // очистити таблицю
            line.Rows.Clear();

            // знак $ використовується для отримання списку записів
            // concat - з'єднує атрибути в одне ціле
            // like - визначає, чи збігається вказаний символьний рядок із заданим шаблоном
            string searchDoctor = $"select * from Doctor where concat(idDoctor, fullNameDoc, telDoc, emailDoc, addressDoc, dateBirthdayDoc, experience, specialization) like '%" + searchDoc.Text + "%'";

            // занесемо запит в command
            SqlCommand command = new SqlCommand(searchDoctor, dateBase.getConnection());

            // відкриваємо зв'язок з БД
            dateBase.openConnection();

            SqlDataReader read = command.ExecuteReader();

            while(read.Read())
            {
                readSingleRow2(line, read);
            }
            read.Close();

            dateBase.closeConnection();
        }

        private void searchDoc_TextChanged(object sender, EventArgs e)
        {
            Search(searchBox);
        }

        private void searchBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
