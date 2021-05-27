using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace тренировка
{
    public partial class FormReg : Form
    {
        public string NAME;
        public string SURNAME;
        public string NUMPHONE;

        private SqlConnection sqlConnection = null;

        public FormReg()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(panelDrag);
            bunifuFormDock1.SubscribeControlToDragEvents(labelReg);
            bunifuFormDock1.SubscribeControlToDragEvents(labelName);
            bunifuFormDock1.SubscribeControlToDragEvents(labelSurName);
            bunifuFormDock1.SubscribeControlToDragEvents(labelNumPhone);
            bunifuFormDock1.SubscribeControlToDragEvents(labelLog);
            bunifuFormDock1.SubscribeControlToDragEvents(labelPass);
            bunifuFormDock1.SubscribeControlToDragEvents(labelComPass);

            KeyPreview = true;
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Enter) ButtonReg_Click(buttonReg, null); };

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxPass.PasswordChar = '\0';
                textBoxComPass.PasswordChar = '\0';
            }
            else
            {
                textBoxPass.PasswordChar = '•';
                textBoxComPass.PasswordChar = '•';

            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxSurName.Text = "";
            maskedTextBoxNumPhone.Text = "";
            textBoxLog.Text = "";
            textBoxPass.Text = "";
            textBoxComPass.Text = "";

            labelNameMist.Text = "";
            labelSurNameMist.Text = "";
            labelLogMist.Text = "";
            labelPassMist.Text = "";
            labelComPassMist.Text = "";
            labelNumPhoneMist.Text = "";
        }

        private void ButtonToEnter_Click(object sender, EventArgs e)
        {
            FormEnter f = new FormEnter();
            f.Show();
            this.Hide();
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);

            sqlConnection.Open();

        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            //Проверка данных на верный формат ввода
            #region
            if (textBoxName.Text.Length == 0)
            {
                labelNameMist.Text = "Введите Имя";
            }
            if (textBoxName.Text.Length == 1)
            {
                labelNameMist.Text = "Количество символов от 2 до 30";
            }
            if (textBoxName.Text.Length > 1)
            {
                labelNameMist.Text = "";
            }


            if (textBoxSurName.Text.Length == 0)
            {
                labelSurNameMist.Text = "Введите фамилию";
            }
            if (textBoxSurName.Text.Length == 1)
            {
                labelSurNameMist.Text = "Количество символов от 2 до 30";
            }
            if (textBoxSurName.Text.Length > 1)
            {
                labelSurNameMist.Text = "";
            }


            if (maskedTextBoxNumPhone.Text.Length < 22)
            {
                labelNumPhoneMist.Text = "Введите номер корректно";
            }
            else
                labelNumPhoneMist.Text = "";


            if (textBoxLog.Text.Length < 5)
            {
                labelLogMist.Text = "Количество символов от 5 до 30";
            }
            else
                labelLogMist.Text = "";
            if (textBoxLog.Text.Length > 4)
            {
                for (int i = 0; i < textBoxLog.Text.Length; i++)
                {
                    if (!(Char.IsDigit(textBoxLog.Text[i]) || textBoxLog.Text[i] >= 'a' && textBoxLog.Text[i] <= 'z' || textBoxLog.Text[i] >= 'A' && textBoxLog.Text[i] <= 'Z'))
                    {
                        labelLogMist.Text = "Буквы только на латинском";
                    }
                }
            }


            if (textBoxPass.Text.Length < 5)
            {
                labelPassMist.Text = "Количество символов от 5 до 30";
            }
            else
                labelPassMist.Text = "";
            if (textBoxPass.Text.Length > 4)
            {
                for (int i = 0; i < textBoxPass.Text.Length; i++)
                {
                    if (!(Char.IsDigit(textBoxPass.Text[i]) || textBoxPass.Text[i] >= 'a' && textBoxPass.Text[i] <= 'z' || textBoxPass.Text[i] >= 'A' && textBoxPass.Text[i] <= 'Z'))
                    {
                        labelPassMist.Text = "Буквы только на латинском";
                    }
                }
            }


            if (textBoxPass.Text != textBoxComPass.Text && textBoxComPass.Text.Length > 4 && textBoxPass.Text.Length > 4)
            {
                labelComPassMist.Text = "Пароли не совпадают";
            }
            else
                labelComPassMist.Text = "";
            #endregion

            if (labelNameMist.Text == "" && labelSurNameMist.Text == "" && labelNumPhoneMist.Text == "" && labelLogMist.Text == "" && labelPassMist.Text == "" && labelComPassMist.Text == "")
            {
                 void EnterToSPD()
                {
                    SqlCommand command1 = new SqlCommand($"INSERT INTO [Users] (Имя, Фамилия, Номер_телефона, Логин, Пароль) VALUES (N'{textBoxName.Text}', N'{textBoxSurName.Text}', '{maskedTextBoxNumPhone.Text}', '{textBoxLog.Text}', '{textBoxPass.Text}')", sqlConnection);
                    SqlCommand command2 = new SqlCommand($"INSERT INTO [PersData] (Имя, Фамилия, Номер_телефона, Логин, Пароль) VALUES (N'{textBoxName.Text}', N'{textBoxSurName.Text}', '{maskedTextBoxNumPhone.Text}', '{textBoxLog.Text}', '{textBoxPass.Text}')", sqlConnection);

                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();

                    SqlCommand NM = new SqlCommand();
                    string name = "SELECT Имя FROM Users WHERE Логин = '" + textBoxLog.Text + "' and Пароль = '" + textBoxPass.Text + "'";
                    NM.CommandText = name;
                    NM.Connection = sqlConnection;
                    var name1 = NM.ExecuteScalar().ToString();

                    SqlCommand SN = new SqlCommand();
                    string surname = "SELECT Фамилия FROM Users WHERE Логин = '" + textBoxLog.Text + "' and Пароль = '" + textBoxPass.Text + "'";
                    SN.CommandText = surname;
                    SN.Connection = sqlConnection;
                    var surname1 = SN.ExecuteScalar().ToString();

                    SqlCommand NP = new SqlCommand();
                    string numphone = "SELECT Номер_телефона FROM Users WHERE Логин = '" + textBoxLog.Text + "' and Пароль = '" + textBoxPass.Text + "'";
                    NP.CommandText = numphone;
                    NP.Connection = sqlConnection;
                    var numphone1 = NP.ExecuteScalar().ToString();

                    SqlCommand LS = new SqlCommand();
                    string LoginSPD = "SELECT Логин FROM Users WHERE Логин = '" + textBoxLog.Text + "' and Пароль = '" + textBoxPass.Text + "'";
                    LS.CommandText = LoginSPD;
                    LS.Connection = sqlConnection;
                    var LoginSPD1 = LS.ExecuteScalar().ToString();

                    FormSPD f = new FormSPD();
                    f.lblUserName.Text = name1 + " " + surname1;
                    NAME = name1;
                    SURNAME = surname1;
                    NUMPHONE = numphone1;
                    f.LoginSPD = LoginSPD1;
                    f.Show();
                    this.Hide();

                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Count (*) From Users where Логин = '" + textBoxLog.Text + "'", sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                SqlDataAdapter DA = new SqlDataAdapter("Select Count (*) From Users where Номер_телефона = '" + maskedTextBoxNumPhone.Text + "'", sqlConnection);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                if (DT.Rows[0][0].ToString() == "1" && dataTable.Rows[0][0].ToString() == "0")
                {
                    FormMessageBox c = new FormMessageBox();
                    c.labelError.Text = "Такой номер зарегестрирован";
                    c.ShowDialog();
                }

                if (dataTable.Rows[0][0].ToString() == "1" && DT.Rows[0][0].ToString() == "0")
                {
                    FormMessageBox c = new FormMessageBox();
                    c.labelError.Text = "Такой логин зарегестрирован";
                    c.ShowDialog();
                }

                if (DT.Rows[0][0].ToString() == "0" && dataTable.Rows[0][0].ToString() == "0")
                {
                    EnterToSPD();
                }

                if (DT.Rows[0][0].ToString() == "1" && dataTable.Rows[0][0].ToString() == "1")
                {
                    FormMessageBox c = new FormMessageBox();
                    c.labelError.Text = "Такой логин зарегестрирован";
                    c.ShowDialog();
                }


            }
        }

        private void PanelDrag_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
