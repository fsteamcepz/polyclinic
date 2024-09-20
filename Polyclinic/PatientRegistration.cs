using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Polyclinic
{
    public partial class PatientRegistration : Form
    {
        DateBase dateBase = new DateBase();

        public static string p_PIB;     // d - display (вивести ПІБ на екран)

        public PatientRegistration()
        {
            InitializeComponent();
            passP.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // вихід з програми
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm returnToRegistration = new RegisterForm();
            returnToRegistration.Show();
        }

        private void checkPassPat_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkPassPat.Checked)       // пароль вимк.
            {
                passP.UseSystemPasswordChar = false;
            }
            else
            {
                passP.UseSystemPasswordChar = true;
            }
        }

        static bool Spaces(char chr)
        {
            if (chr == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void registrationPatient(object sender, EventArgs e)
        {
            string user = fullNameP.Text;
            if (user == "admin")
            {
                this.Hide();
                PatientIsPersonalAccount entranceToTheAccountP = new PatientIsPersonalAccount();
                entranceToTheAccountP.Show();
            }
            else
            {
                //////////////////////////////////////////////////////
                /// 1    Checking FULL NAME
                //////////////////////////////////////////////////////
                string fullName = fullNameP.Text;

                if (fullName == " " || fullName.Length == 0)
                {
                    MessageBox.Show("Поле з ПІБ порожнє!");
                    this.fullNameP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }

                foreach (var item in fullName)
                {
                    if (char.IsDigit(item))     // якщо хоч один символ число
                    {
                        MessageBox.Show("В ПІБ не можна вводити цифру(и)!");
                        this.fullNameP.BackColor = System.Drawing.Color.LawnGreen;
                        return;
                    }
                }

                string symbols = "[]{}+=&^:;|/><$#@!?№%()_₴~*";
                int count_name = 0;

                for (int i = 0; i < fullName.Length; i++)
                {
                    for (int j = 0; j < symbols.Length; j++)
                    {
                        if (fullName.Contains(symbols[j]))
                        {
                            count_name++;
                        }
                    }
                }

                if (count_name > 0)
                {
                    MessageBox.Show("В ПІБ є недопустимі символи!");
                    this.fullNameP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }

                char[] chars = fullName.ToCharArray();
                char[] findSpaces = Array.FindAll(chars, Spaces);

                if (findSpaces.Length == 0)
                {
                    MessageBox.Show("Введіть ПІБ через пробіл");
                    this.fullNameP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else if (findSpaces.Length == 1 || findSpaces.Length >= 3)
                {
                    MessageBox.Show("Неправильно введено ПІБ!");
                    this.fullNameP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                this.fullNameP.BackColor = System.Drawing.Color.White;



                //////////////////////////////////////////////////////
                /// 2    Checking TIN (ІПН)
                //////////////////////////////////////////////////////
                string id = idP.Text;

                if (id == " " || id.Length == 0)
                {
                    MessageBox.Show("Поле з ІПН порожнє!");
                    this.idP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else
                {
                    foreach (var item in id)
                    {
                        if (!char.IsDigit(item))            // якщо хоч один символ не число
                        {
                            MessageBox.Show("ІПН не може складатися з символа(ів)!");
                            this.idP.BackColor = System.Drawing.Color.LawnGreen;
                            return;
                        }
                    }

                }
                this.idP.BackColor = System.Drawing.Color.White;



                //////////////////////////////////////////////////////
                /// 3    Checking the address
                //////////////////////////////////////////////////////
                string address = addressP.Text;

                string p = "[]{}+=&^:;|/><$#@!?№%()_₴~*";
                int count = 0;

                if (address == " " || address.Length == 0)
                {
                    MessageBox.Show("Поле з адресою порожнє!");
                    this.addressP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }

                for (int i = 0; i < address.Length; i++)
                {
                    for (int j = 0; j < p.Length; j++)
                    {
                        if (address.Contains(p[j]))
                        {
                            count++;
                        }
                    }
                }

                if (count > 0)
                {
                    MessageBox.Show("В адресі є недопустимі символи!");
                    this.addressP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                this.addressP.BackColor = System.Drawing.Color.White;



                //////////////////////////////////////////////////////
                /// 4    Checking family doctor
                //////////////////////////////////////////////////////
                string doctor = familyDoctorP.SelectedValue.ToString();

                if (doctor == " " || doctor.Length == 0)
                {
                    MessageBox.Show("Виберіть сімейного лікаря!");
                    this.familyDoctorP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }

                /*foreach (var item in doctor)
                {
                    if (char.IsDigit(item))     // якщо хоч один символ число
                    {
                        MessageBox.Show("В поле з сімейним лікарем не можна вводити цифру(и)!");
                        this.familyDoctorP.BackColor = System.Drawing.Color.LawnGreen;
                        return;
                    }
                }

                string symbols2 = "[]{}+=&^:;|/><$#@!?№%()_₴~*";
                int count_doctor = 0;

                for (int i = 0; i < doctor.Length; i++)
                {
                    for (int j = 0; j < symbols2.Length; j++)
                    {
                        if (doctor.Contains(symbols2[j]))
                        {
                            count_doctor++;
                        }
                    }
                }

                if (count_doctor > 0)
                {
                    MessageBox.Show("В полі з сімейним лікарем є недопустимі символи!");
                    this.familyDoctorP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }*/
                this.familyDoctorP.BackColor = System.Drawing.Color.White;

                //MessageBox.Show(doctor);



                //////////////////////////////////////////////////////
                /// 5    Checking insurance number
                //////////////////////////////////////////////////////
                string inP = insuranceNumberP.Text;

                if (inP == " " || inP.Length == 0)
                {
                    MessageBox.Show("Поле з номером страховки порожнє!");
                    this.insuranceNumberP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else
                {
                    foreach (var item in inP)
                    {
                        if (!char.IsDigit(item))            // якщо хоч один символ не число
                        {
                            MessageBox.Show("Номер страховки не може складатися з символа(ів)!");
                            this.insuranceNumberP.BackColor = System.Drawing.Color.LawnGreen;
                            return;
                        }
                    }

                }
                this.insuranceNumberP.BackColor = System.Drawing.Color.White;



                //////////////////////////////////////////////////////
                /// 6    Checking the phone number
                //////////////////////////////////////////////////////
                string phone = phoneP.Text;

                // якщо є пробіл або порожньо
                if (phone == " " || phone.Length == 0)
                {
                    MessageBox.Show("Поле з номером телефону порожнє!");
                    this.phoneP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                // якщо кількість чисел менше 10
                else if (phone.Length <= 9 && phone.Length != 10)
                {
                    MessageBox.Show("Номер телефону не може бути менше 10 чисел!");
                    this.phoneP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                // якщо є символи
                else
                {
                    foreach (var item in phone)
                    {
                        if (!char.IsDigit(item))            // якщо хоч один символ не число
                        {
                            MessageBox.Show("Телефон не може складатися з символа(ів)!");
                            this.phoneP.BackColor = System.Drawing.Color.LawnGreen;
                            return;
                        }
                    }
                }
                this.phoneP.BackColor = System.Drawing.Color.White;



                //////////////////////////////////////////////////////
                /// 7    Checking the password
                //////////////////////////////////////////////////////
                string password = passP.Text;
                // якщо є пробіл або порожньо
                if (password == " " || password.Length == 0)
                {
                    MessageBox.Show("Поле з паролем порожнє!");
                    this.passP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else if (password.Length > 0 && password.Length < 4)
                {
                    MessageBox.Show("Пароль повинен складатися з 4 до 32 символів!");
                    this.passP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else if ((Regex.Match(password, @"[а-яА-Я]").Success))
                {
                    MessageBox.Show("Пароль повинен складатися з латинських символів!");
                    this.passP.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                this.passP.BackColor = System.Drawing.Color.White;


                // Date
                var dateOfBirthday = dateP.Value.ToString("yyyy-MM-dd");



                // створення sql запита (знак $ використовується для отримання списку записів)
                string queryString = $"insert into Patient(fullNamePat, ipnPat, addressPat, dateBirthdayPat, numberInsurance, telPat, passPat, idFamilyDoctor) values('{fullName}', '{id}', '{address}', '{dateOfBirthday}', '{inP}', '{phone}', '{password}', '{doctor}')";

                SqlCommand command = new SqlCommand(queryString, dateBase.getConnection());

                dateBase.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Реєстрація пройшла успішно!", "Ви зареєструвалися!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    //
                    //  При успішній реєстрації виводиться ПІБ на головному меню
                    //
                    // запит на ПІБ до БД, таблиці Patient
                    string queryString_PIB = $"select fullNamePat from Patient where telPat = '{phone}' and passPat = '{password}'";

                    // За допомогою SqlCommand можна виконати до БД будь-які команди
                    // додати до БД об'єкт, видалити, змінити його
                    SqlCommand command_PIB = new SqlCommand(queryString_PIB, dateBase.getConnection());

                    dateBase.openConnection();

                    p_PIB = (string)command_PIB.ExecuteScalar();


                    this.Hide();
                    PatientIsPersonalAccount entranceToTheAccountP = new PatientIsPersonalAccount();
                    entranceToTheAccountP.Show();
                    dateBase.closeConnection();
                }
                else
                {
                    MessageBox.Show("Помилка!", "Не вдалося створити акаунт!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.polyclinicDataSet.Doctor);
            familyDoctorP.Text = "";
        }

        private void familyDoctorP_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Показати у вікні індекс вибраного лікаря
            //MessageBox.Show(familyDoctorP.SelectedValue.ToString());
        }
    }
}
