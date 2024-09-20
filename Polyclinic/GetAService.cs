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
    public partial class GetAService : Form
    {
        DateBase dateBase = new DateBase();

        public GetAService()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // за допомогою this ми можемо отримати доступ до поточного екземпляру класу
            this.Hide();
            MakeAnAppointment viewP = new MakeAnAppointment();
            viewP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // за допомогою this ми можемо отримати доступ до поточного екземпляру класу
            this.Hide();
            FindADoctor viewP = new FindADoctor();
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

        private void button6_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////
            /// 1    Checking Service name
            //////////////////////////////////////////////////////
            string service = poslyga_Name.Text;

            if (service == " " || service.Length == 0)
            {
                MessageBox.Show("Оберіть будь ласка послугу!");
                this.poslyga_Name.BackColor = System.Drawing.Color.LawnGreen;
                return;
            }
            this.poslyga_Name.BackColor = System.Drawing.Color.White;


            //////////////////////////////////////////////////////
            /// 2    Checking Service salary
            //////////////////////////////////////////////////////
            string salary = salary_Pos.Text;

            if (salary == " " || salary.Length == 0)
            {
                MessageBox.Show("Поле з вартістю порожнє!");
                this.salary_Pos.BackColor = System.Drawing.Color.LawnGreen;
                return;
            }
            else
            {
                if (int.Parse(salary) > 999999)
                {
                    MessageBox.Show("Воу-воу, полегше тигре! Звідки такий апетит?");
                    this.salary_Pos.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else if (int.Parse(salary) < 0)
                {
                    MessageBox.Show("Вартість не може бути від'ємною!");
                    this.salary_Pos.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else
                {
                    foreach (var item in salary)
                    {
                        if (!char.IsDigit(item))            // якщо хоч один символ не число
                        {
                            MessageBox.Show("Вартість не може складатися з символа(ів)!");
                            this.salary_Pos.BackColor = System.Drawing.Color.LawnGreen;
                            return;
                        }
                    }
                }
            }
            this.salary_Pos.BackColor = System.Drawing.Color.White;

            //////////////////////////////////////////////////////
            /// 3    Checking Service full name
            //////////////////////////////////////////////////////
            string full_Name = PIB_Doc.Text;

            if (full_Name == " " || full_Name.Length == 0)
            {
                MessageBox.Show("Оберіть лікаря!");
                this.PIB_Doc.BackColor = System.Drawing.Color.LawnGreen;
                return;
            }
            this.PIB_Doc.BackColor = System.Drawing.Color.White;

            //////////////////////////////////////////////////////
            /// 4    Checking comment
            //////////////////////////////////////////////////////
            string comm = comment.Text;

            if (comm == " " || comm.Length == 0)
            {
                MessageBox.Show("Поле з коментарем обов'язкове!");
                this.comment.BackColor = System.Drawing.Color.LawnGreen;
                return;
            }
            this.comment.BackColor = System.Drawing.Color.White;


            // створення sql запита (знак $ використовується для отримання списку записів)
            string queryString = $"insert into Service(typeService, costDoctor, fullNameDoc, comment) values('{service}', '{salary}', '{full_Name}', '{comm}')";

            SqlCommand command = new SqlCommand(queryString, dateBase.getConnection());

            dateBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Ви успішно записалися на послугу!", "Вітаємо!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                PatientIsPersonalAccount mainMenu = new PatientIsPersonalAccount();
                mainMenu.Show();
                this.Hide();            // за допомогою this ми можемо отримати доступ до поточного екземпляру класу

                dateBase.closeConnection();
            }
            else
            {
                MessageBox.Show("Помилка!", "Не вдалося записатися на послугу!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetAService_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet7.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter1.Fill(this.polyclinicDataSet7.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet6.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.polyclinicDataSet6.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet5.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.polyclinicDataSet5.Service);
            poslyga_Name.Text = "";
            PIB_Doc.Text = "";
        }
    }
}
