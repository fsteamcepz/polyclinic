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

namespace Polyclinic
{
    public partial class History_Form : Form
    {
        DateBase dateBase = new DateBase();

        public History_Form()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DoctorIsPersonalAccount mainMenu = new DoctorIsPersonalAccount();
            mainMenu.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // ПІБ пацієнта
            string fullName = pib_box.SelectedValue.ToString();

            if (fullName == "" || fullName.Length == 0)
            {
                MessageBox.Show("Виберіть пацієнта!");
                this.pib_box.BackColor = System.Drawing.Color.LawnGreen;
                return;
            }
            this.pib_box.BackColor = System.Drawing.Color.White;


            // Дата прийому
            var dateReception = date_box.Value.ToString("yyyy-MM-dd");


            // Вид послуги
            string typeService = service_box.SelectedValue.ToString();

            if (typeService == "" || typeService.Length == 0)
            {
                MessageBox.Show("Виберіть послугу!");
                this.service_box.BackColor = System.Drawing.Color.LawnGreen;
                return;
            }
            this.service_box.BackColor = System.Drawing.Color.White;


            // Результат прийому
            string result = result_box.Text;

            if (result == "" || result.Length == 0)
            {
                MessageBox.Show("Виберіть результат прийому!");
                this.result_box.BackColor = System.Drawing.Color.LawnGreen;
                return;
            }
            else if (result == "Завершено")
            {
                result = "1";
            }
            else if (result == "Не завершено")
            {
                result = "0";
            }
            this.result_box.BackColor = System.Drawing.Color.White;


            // Діагноз
            string diagnos = diagnos_box.Text;

            if (diagnos == "" || diagnos.Length == 0)
            {
                MessageBox.Show("Виберіть діагноз!");
                this.diagnos_box.BackColor = System.Drawing.Color.LawnGreen;
                return;
            }
            else
            {
                diagnos = diagnos_box.SelectedValue.ToString();
            }
            this.diagnos_box.BackColor = System.Drawing.Color.White;


            // створення sql запита (знак $ використовується для отримання списку записів)
            string queryString = $"insert into Reception(idPat, dateReception, idServ, result, idDiag) values('{fullName}', '{dateReception}', '{typeService}', '{result}', '{diagnos}')";

            SqlCommand command = new SqlCommand(queryString, dateBase.getConnection());

            dateBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Прийом успішно додано!", "Чудово!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                this.Hide();
                DoctorIsPersonalAccount mainMenu = new DoctorIsPersonalAccount();
                mainMenu.Show();

                dateBase.closeConnection();
            }
            else
            {
                MessageBox.Show("Помилка!", "Не вдалося додати прийом!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void History_Form_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet13.Diagnos". При необходимости она может быть перемещена или удалена.
            this.diagnosTableAdapter.Fill(this.polyclinicDataSet13.Diagnos);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet11.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.polyclinicDataSet11.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet10.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.polyclinicDataSet10.Patient);
            
            pib_box.Text = "";
            service_box.Text = "";
            diagnos_box.Text = "";
        }
    }
}
