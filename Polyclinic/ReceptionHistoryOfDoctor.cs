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
    public partial class ReceptionHistoryOfDoctor : Form
    {
        DateBase dateBase = new DateBase();

        public ReceptionHistoryOfDoctor()
        {
            InitializeComponent();

            CreateColums();
            dataOutputToTheTable(history_data);
        }

        public void CreateColums()
        {
            // рядки по центру
            DataGridViewCellStyle style = history_data.ColumnHeadersDefaultCellStyle;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // автопідбір ширини стовпців за вмістом
            history_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            history_data.Columns.Add("idDoc", "№");
            history_data.Columns.Add("idPat", "Номер пацієнта");
            history_data.Columns.Add("dateReception", "Дата прийому");
            history_data.Columns.Add("idServ", "Номер послуги");
            history_data.Columns.Add("result", "Результат  прийому");
            history_data.Columns.Add("idDiag", "Номер діагнозу");
        }

        private void readSingleRow(DataGridView line2, IDataRecord record)
        {
            line2.Rows.Add(record.GetInt32(0),
                          record.GetInt32(1),
                          record.GetDateTime(2),
                          record.GetInt32(3),
                          record.GetInt32(4),
                          record.GetInt32(5));
        }

        private void dataOutputToTheTable(DataGridView line2)
        {
            line2.Rows.Clear();

            string queryString = $"select * from Reception";

            // перенесення запита до БД в змінну command (запрос, об'єкт dateBase, в якому метод getConnection)
            SqlCommand command = new SqlCommand(queryString, dateBase.getConnection());

            dateBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                readSingleRow(line2, reader);
            }
            reader.Close();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleForTheWeek viewD = new ScheduleForTheWeek();
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
            History_Form viewD = new History_Form();
            viewD.Show();
        }
    }
}
