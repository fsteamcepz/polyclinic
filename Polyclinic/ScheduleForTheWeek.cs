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
    public partial class ScheduleForTheWeek : Form
    {
        DateBase dateBase = new DateBase();

        public ScheduleForTheWeek()
        {
            InitializeComponent();

            CreateColums();
            dataOutputToTheTable(week_data);
        }

        public void CreateColums()
        {
            // рядки по центру
            DataGridViewCellStyle style = week_data.ColumnHeadersDefaultCellStyle;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // автопідбір ширини стовпців за вмістом
            week_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            week_data.Columns.Add("idSchedule", "№");
            week_data.Columns.Add("idDoc", "Номер лікаря");
            week_data.Columns.Add("dayOfTheWeek", "День тижня");
            week_data.Columns.Add("startTime", "Час початку");
            week_data.Columns.Add("endTime", "Час закінчення");
            week_data.Columns.Add("officeNumber", "Кабінет");
        }

        private void readSingleRow3(DataGridView line3, IDataRecord record)
        {
            line3.Rows.Add(record.GetInt32(0),
                           record.GetInt32(1),
                           record.GetString(2),
                           record.GetString(3),
                           record.GetString(4),
                           record.GetInt32(5));
        }

        private void dataOutputToTheTable(DataGridView line3)
        {
            line3.Rows.Clear();

            string queryString = $"select * from Schedule";

            // перенесення запита до БД в змінну command (запрос, об'єкт dateBase, в якому метод getConnection)
            SqlCommand command = new SqlCommand(queryString, dateBase.getConnection());

            dateBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                readSingleRow3(line3, reader);
            }
            reader.Close();

            dateBase.closeConnection();
        }

        private void Search(DataGridView line3)
        {
            // очистити таблицю
            line3.Rows.Clear();

            // знак $ використовується для отримання списку записів
            // concat - з'єднує атрибути в одне ціле
            // like - визначає, чи збігається вказаний символьний рядок із полями таблиці
            string searchDoctor = $"select * from Schedule where concat(idSchedule, idDoc, dayOfTheWeek, startTime, endTime, officeNumber) like '%" + searchDay.Text + "%'";

            // занесемо запит в command
            SqlCommand command = new SqlCommand(searchDoctor, dateBase.getConnection());

            // відкриваємо зв'язок з БД
            dateBase.openConnection();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                readSingleRow3(line3, read);
            }
            read.Close();

            dateBase.closeConnection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // вихід з програми
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorIsPatients viewD = new DoctorIsPatients();
            viewD.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionHistoryOfDoctor viewD = new ReceptionHistoryOfDoctor();
            viewD.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DoctorIsPersonalAccount mainMenu = new DoctorIsPersonalAccount();
            mainMenu.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Schedule viewD = new Add_Schedule();
            viewD.Show();
        }

        private void searchDoc_TextChanged(object sender, EventArgs e)
        {
            Search(week_data);
        }
    }
}
