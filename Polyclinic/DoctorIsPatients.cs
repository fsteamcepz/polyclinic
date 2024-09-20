using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Polyclinic
{
    public partial class DoctorIsPatients : Form
    {
        DateBase dateBase = new DateBase();

        public DoctorIsPatients()
        {
            InitializeComponent();

            CreateColums();
            dataOutputToTheTable(patients);
        }

        public void CreateColums()
        {
            // рядки по центру
            DataGridViewCellStyle style = patients.ColumnHeadersDefaultCellStyle;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // автопідбір ширини стовпців за вмістом
            patients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            patients.Columns.Add("idPatient", "№");
            patients.Columns.Add("fullNamePat", "ПІБ пацієнта");
            patients.Columns.Add("ipnPat", "ІПН");
            patients.Columns.Add("addressPat", "Адреса проживання");
            patients.Columns.Add("dateBirthdayPat", "Дата народження");
            patients.Columns.Add("numberInsurance", "Номер страховки");
            patients.Columns.Add("telPat", "Телефон");
            patients.Columns.Add("idFamilyDoctor", "Номер лікаря");
        }

        private void readSingleRow(DataGridView line, IDataRecord record)
        {
            line.Rows.Add(record.GetInt32(0),
                          record.GetString(1),
                          record.GetString(2),
                          record.GetString(3),
                          record.GetDateTime(4),
                          record.GetInt32(5),
                          record.GetString(6),
                          record.GetInt32(8));
        }

        private void dataOutputToTheTable(DataGridView line2)
        {
            line2.Rows.Clear();

            string queryString = $"select * from Patient";

            // перенесення запита до БД в змінну command (запрос, об'єкт dateBase, в якому метод getConnection)
            SqlCommand command = new SqlCommand(queryString, dateBase.getConnection());

            dateBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                readSingleRow(line2, reader);
            }
            reader.Close();

            dateBase.closeConnection();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DoctorIsPersonalAccount mainMenu = new DoctorIsPersonalAccount();
            mainMenu.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // метод Exit Повідомляє всім засобам перенесення повідомлень,
            // що вони повинні завершити роботу, а потім закриває всі
            // вікна програми після обробки повідомлень.
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleForTheWeek viewD = new ScheduleForTheWeek();
            viewD.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionHistoryOfDoctor viewD = new ReceptionHistoryOfDoctor();
            viewD.Show();
        }
    }
}
