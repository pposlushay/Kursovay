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
    public partial class FormEnter : Form
    {
        private SqlConnection sqlConnection = null;

        public FormEnter()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(panelDrag);
            bunifuFormDock1.SubscribeControlToDragEvents(labelEnter);
            bunifuFormDock1.SubscribeControlToDragEvents(labelLog);
            bunifuFormDock1.SubscribeControlToDragEvents(labelPass);

            KeyPreview = true;
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Enter) ButtonEnter_Click(buttonEnter, null); };


        }

        private void FormEnter_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);

            sqlConnection.Open();

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonToReg_Click(object sender, EventArgs e)
        {
            FormReg f = new FormReg();
            f.Show();
            this.Hide();
        }

        private void CheckBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxPass.PasswordChar = '\0';
            }
            else
            {
                textBoxPass.PasswordChar = '•';
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxLog.Text = "";
            textBoxPass.Text = "";
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Count (*) From Users where Логин = '" + textBoxLog.Text + "' and Пароль = '" + textBoxPass.Text + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows[0][0].ToString() == "1")
            {
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

                SqlCommand LS = new SqlCommand();
                string LoginSPD = "SELECT Логин FROM Users WHERE Логин = '" + textBoxLog.Text + "' and Пароль = '" + textBoxPass.Text + "'";
                LS.CommandText = LoginSPD;
                LS.Connection = sqlConnection;
                var LoginSPD1 = LS.ExecuteScalar().ToString();

                FormSPD f = new FormSPD();
                f.lblUserName.Text = name1 + " " + surname1;
                f.lblWelcome.Text = name1 + ", добро пожаловать в персональный помошник для сохранения личных данных";
                f.NAME = name1;
                f.SURNAME = surname1;
                f.LoginSPD = LoginSPD1;
                f.Show();
                this.Hide();
            }
            else
            {
                FormMessageBox c = new FormMessageBox();
                c.labelError.Text = "Данные введены не верно\nПопробуйте еще раз";
                c.ShowDialog();
            }

        }
    }
}
