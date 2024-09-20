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
    public partial class viewAllDoctors : Form
    {
        DateBase dateBase = new DateBase();
        public viewAllDoctors()
        {
            InitializeComponent();

            CreateColums();
            dataOutputToTheTable(searchBox);
        }

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

        private void readSingleRowDoc(DataGridView line, IDataRecord record)
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

        private void dataOutputToTheTable(DataGridView line2)
        {
            line2.Rows.Clear();

            string queryString = $"select * from Doctor";

            // перенесення запита до БД в змінну command (запрос, об'єкт dateBase, в якому метод getConnection)
            SqlCommand command = new SqlCommand(queryString, dateBase.getConnection());

            dateBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                readSingleRowDoc(line2, reader);
            }
            reader.Close();

            dateBase.closeConnection();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void searchBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
