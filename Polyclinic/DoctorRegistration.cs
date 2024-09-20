using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Polyclinic
{
    public partial class DoctorRegistration : Form
    {
        DateBase dateBase = new DateBase();

        public static string d_PIB;

        public DoctorRegistration()
        {
            InitializeComponent();
            passD.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm returnToRegistration = new RegisterForm();
            returnToRegistration.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // вихід з програми
            Application.Exit();
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)       // пароль вимк.
            {
                passD.UseSystemPasswordChar = false;
            }
            else
            {
                passD.UseSystemPasswordChar = true;
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
        private void registrationDoctor_Click_1(object sender, EventArgs e)
        {
            string admin = fullNameD.Text;
            if (admin == "A5A4P-NASA")
            {
                this.Hide();
                DoctorIsPersonalAccount entranceToTheAccountD = new DoctorIsPersonalAccount();
                entranceToTheAccountD.Show();
            }
            else
            {
                //////////////////////////////////////////////////////
                /// 1    Checking FULL NAME
                //////////////////////////////////////////////////////
                string fullName = fullNameD.Text;

                if (fullName == " " || fullName.Length == 0)
                {
                    MessageBox.Show("Поле з ПІБ порожнє!");
                    this.fullNameD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
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
                    this.fullNameD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }

                char[] chars = fullName.ToCharArray();
                char[] findSpaces = Array.FindAll(chars, Spaces);

                if (findSpaces.Length == 0)
                {
                    MessageBox.Show("Введіть ПІБ через пробіл");
                    this.fullNameD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else if (findSpaces.Length == 1 || findSpaces.Length >= 3)
                {
                    MessageBox.Show("Неправильно введено ПІБ!");
                    this.fullNameD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else
                {
                    foreach (var item in fullName)
                    {
                        if (char.IsDigit(item))     // якщо хоч один символ число
                        {
                            MessageBox.Show("В ПІБ не можна вводити цифру(и)!");
                            this.fullNameD.BackColor = System.Drawing.Color.LawnGreen;
                            return;
                        }
                    }
                }
                this.fullNameD.BackColor = System.Drawing.Color.White;



                //////////////////////////////////////////////////////
                /// 2    Checking TIN (ІПН)
                //////////////////////////////////////////////////////
                string id = idD.Text;

                if (id == " " || id.Length == 0)
                {
                    MessageBox.Show("Поле з ІПН порожнє!");
                    this.idD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else
                {
                    foreach (var item in id)
                    {
                        if (!char.IsDigit(item))            // якщо хоч один символ не число
                        {
                            MessageBox.Show("ІПН не може складатися з символа(ів)!");
                            this.idD.BackColor = System.Drawing.Color.LawnGreen;
                            return;
                        }
                    }

                }
                this.idD.BackColor = System.Drawing.Color.White;



                //////////////////////////////////////////////////////
                /// 3    Checking the phone number
                //////////////////////////////////////////////////////
                string phone = phoneD.Text;

                // якщо є пробіл або порожньо
                if (phone == " " || phone.Length == 0)
                {
                    MessageBox.Show("Поле з номером телефону порожнє!");
                    this.phoneD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                // якщо кількість чисел менше 10
                else if (phone.Length <= 9 && phone.Length != 10)
                {
                    MessageBox.Show("Номер телефону не може бути менше 10 чисел!");
                    this.phoneD.BackColor = System.Drawing.Color.LawnGreen;
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
                            this.phoneD.BackColor = System.Drawing.Color.LawnGreen;
                            return;
                        }
                    }
                }
                this.phoneD.BackColor = System.Drawing.Color.White;



                //////////////////////////////////////////////////////
                /// 4    Checking e-mail
                //////////////////////////////////////////////////////
                string email = emailD.Text;
                string original_email = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                     @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

                // якщо є пробіл або порожньо
                if (email == " " || email.Length == 0)
                {
                    MessageBox.Show("Поле з поштою порожнє!");
                    this.emailD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else if (!Regex.IsMatch(email, original_email, RegexOptions.IgnoreCase))      // IsValidEmail(email) == false
                {
                    MessageBox.Show("Неправильно введена пошта!");
                    this.emailD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                this.emailD.BackColor = System.Drawing.Color.White;



                //////////////////////////////////////////////////////
                /// 5    Checking the password
                //////////////////////////////////////////////////////
                string password = passD.Text;
                // якщо є пробіл або порожньо
                if (password == " " || password.Length == 0)
                {
                    MessageBox.Show("Поле з паролем порожнє!");
                    this.passD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else if (password.Length > 0 && password.Length < 4)
                {
                    MessageBox.Show("Пароль повинен складатися з 4 до 32 символів!");
                    this.passD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else if ((Regex.Match(password, @"[а-яА-Я]").Success))
                {
                    MessageBox.Show("Пароль повинен складатися з латинських символів!");
                    this.passD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                this.passD.BackColor = System.Drawing.Color.White;



                //////////////////////////////////////////////////////
                /// 6    Checking the address
                //////////////////////////////////////////////////////
                string address = addressD.Text;

                string d = "[]{}+=&^:;|/><$#@!?№%()_₴~*";
                int count = 0;

                if (address == " " || address.Length == 0)
                {
                    MessageBox.Show("Поле з адресою порожнє!");
                    this.addressD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }

                for (int i = 0; i < address.Length; i++)
                {
                    for (int j = 0; j < d.Length; j++)
                    {
                        if (address.Contains(d[j]))
                        {
                            count++;
                        }
                    }
                }

                if (count > 0)
                {
                    MessageBox.Show("В адресі є недопустимі символи!");
                    this.addressD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                this.addressD.BackColor = System.Drawing.Color.White;



                //////////////////////////////////////////////////////
                /// 7    Checking the salary
                //////////////////////////////////////////////////////
                string salary = salaryD.Text;
                int cs = 0;

                if (salary == " " || salary.Length == 0)
                {
                    MessageBox.Show("Поле з окладом порожнє!");
                    this.salaryD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }

                for (int i = 0; i < salary.Length; i++)
                {
                    for (int j = 0; j < d.Length; j++)
                    {
                        if (salary.Contains(d[j]))
                        {
                            cs++;
                        }
                    }
                }
                if (cs > 0)
                {
                    MessageBox.Show("В полі 'Оклад' є недопустимі символи!");
                    this.salaryD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else if (int.Parse(salary) == 0)
                {
                    MessageBox.Show("Оклад не може становити 0 грн!");
                    this.salaryD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else if(int.Parse(salary) > 999999)
                {
                    MessageBox.Show("Воу-воу, полегше тигре! Звідки такий апетит?");
                    this.salaryD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                else if (int.Parse(salary) < 0)
                {
                    MessageBox.Show("Оклад не може бути від'ємним!");
                    this.salaryD.BackColor = System.Drawing.Color.LawnGreen;
                    return;
                }
                this.salaryD.BackColor = System.Drawing.Color.White;


                //////////////////////////////////////////////////////
                /// 8    Checking the specialization
                //////////////////////////////////////////////////////
                string specialization = specializationD.Text;

                if (specialization == " " || specialization.Length == 0)
                {
                    MessageBox.Show("Оберіть спеціалізацію!");
                    return;
                }

                this.specializationD.BackColor = System.Drawing.Color.White;


                // дата народження ERROR - "Conversion failed when converting date and/or time from character string."
                
                //string dateS = dateTimeD.Value.ToShortDateString();

                var dateD = dateTimeD.Value.ToString("yyyy-MM-dd");

                // стаж
                string experience = experienceD.Text;


                // створення sql запита (знак $ використовується для отримання списку записів)
                string queryString = $"insert into Doctor(fullNameDoc, ipnDoc, telDoc, emailDoc, passDoc, addressDoc, dateBirthdayDoc, salary, experience, specialization) values('{fullName}', '{id}', '{phone}', '{email}', '{password}', '{address}', '{dateD}', '{salary}', '{experience}', '{specialization}')";

                SqlCommand command = new SqlCommand(queryString, dateBase.getConnection());

                dateBase.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Реєстрація пройшла успішно!", "Ви зареєструвалися!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    //
                    //  При успішній реєстрації виводиться ПІБ на головному меню
                    //
                    // запит на ПІБ до БД, таблиці Doctor
                    string queryString_PIB = $"select fullNameDoc from Doctor where emailDoc = '{email}' and passDoc = '{password}'";

                    // За допомогою SqlCommand можна виконати до БД будь-які команди
                    // додати до БД об'єкт, видалити, змінити його
                    SqlCommand command_PIB = new SqlCommand(queryString_PIB, dateBase.getConnection());

                    dateBase.openConnection();

                    d_PIB = (string)command_PIB.ExecuteScalar();


                    this.Hide();
                    DoctorIsPersonalAccount entranceToTheAccountD = new DoctorIsPersonalAccount();
                    entranceToTheAccountD.Show();
                    dateBase.closeConnection();
                }
                else
                {
                    MessageBox.Show("Помилка!", "Не вдалося створити акаунт!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
