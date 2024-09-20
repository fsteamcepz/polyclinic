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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Polyclinic
{
    public partial class LoginForm : Form
    {
        DateBase dateBase = new DateBase();

        // змінна, в якій буде зберігатися повна інформація користувача
        public static string d_PIB;     // d - display (вивести) - Doctor
        public static string p_PIB;     // Patient

        public LoginForm()
        {
            InitializeComponent();
            loginPassword.UseSystemPasswordChar = true;     // відображення пароля увм.
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MainForm backButton = new MainForm();
            backButton.Show();
            Hide();
        }

        private void loginToAcc_Click(object sender, EventArgs e)
        {
            // дані лікаря
            var emailD = login.Text;
            var passwordD = loginPassword.Text;

            // 2 об'єкта класа для роботи з БД
            SqlDataAdapter adapterD = new SqlDataAdapter();
            DataTable tableD = new DataTable();

            // створення sql запита для таблиці Doctor
            string queryStringDoctor = $"select emailDoc, passDoc from Doctor where emailDoc = '{emailD}' and passDoc = '{passwordD}'";

            SqlCommand commandD = new SqlCommand(queryStringDoctor, dateBase.getConnection());

            adapterD.SelectCommand = commandD;

            // заповнення DataTable
            adapterD.Fill(tableD);

            if (tableD.Rows.Count == 1)
            {
                // запит на ПІБ до БД, таблиці Doctor
                string queryString_PIB = $"select fullNameDoc from Doctor where emailDoc = '{emailD}' and passDoc = '{passwordD}'";

                // За допомогою SqlCommand можна виконати до БД будь-які команди
                // додати до БД об'єкт, видалити, змінити його
                SqlCommand command_PIB = new SqlCommand(queryString_PIB, dateBase.getConnection());

                dateBase.openConnection();

                d_PIB = (string)command_PIB.ExecuteScalar();

                this.Hide();                    // за допомогою this ми можемо отримати доступ до поточного екземпляру класу
                DoctorIsPersonalAccount account = new DoctorIsPersonalAccount();
                account.Show();
            }
            else
            {
                // дані пацієнта
                var phoneP = login.Text;
                var passwordP = loginPassword.Text;

                // 2 об'єкта класа для роботи з БД
                SqlDataAdapter adapterP = new SqlDataAdapter();
                DataTable tableP = new DataTable();

                // створення sql запита для таблиці Patient
                string queryStringPatient = $"select telPat, passPat from Patient where telPat = '{phoneP}' and passPat = '{passwordP}'";

                SqlCommand commandP = new SqlCommand(queryStringPatient, dateBase.getConnection());
                adapterP.SelectCommand = commandP;

                // заповнення DataTable
                adapterP.Fill(tableP);

                if (tableP.Rows.Count == 1)
                {
                    // запит на ПІБ до БД, таблиці Patient
                    string queryString_PIB2 = $"select fullNamePat from Patient where telPat = '{phoneP}' and passPat = '{passwordP}'";

                    // За допомогою SqlCommand можна виконати до БД будь-які команди
                    // додати до БД об'єкт, видалити, змінити його
                    SqlCommand command_PIB2 = new SqlCommand(queryString_PIB2, dateBase.getConnection());

                    dateBase.openConnection();

                    p_PIB = (string)command_PIB2.ExecuteScalar();


                    // за допомогою this ми можемо отримати доступ до поточного екземпляру класу
                    this.Hide();
                    PatientIsPersonalAccount entranceToTheAccountP = new PatientIsPersonalAccount();
                    entranceToTheAccountP.Show();
                }
                else
                {
                    MessageBox.Show("Tакоro акаунта не існує!", "Акаунт не знайдено!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    login.Text = "";
                    loginPassword.Text = "";
                    return;
                }
            }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkPass.Checked)       // пароль вимк.
            {
                loginPassword.UseSystemPasswordChar = false;
            }
            else
            {
                loginPassword.UseSystemPasswordChar = true;
            }
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
