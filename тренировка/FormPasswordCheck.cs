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
    public partial class FormPasswordCheck : Form
    {
        public string NAME;
        public string SURNAME;
        public string LoginSPD;

        private SqlConnection sqlConnection = null;

        private SqlCommandBuilder SqlCommandBuilder = null;

        public FormPasswordCheck()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(bnfGradPnlTitle);
            bunifuFormDock1.SubscribeControlToDragEvents(lblInternet);
            bunifuFormDock1.SubscribeControlToDragEvents(pbInternet);

        }

        private void BnBtnPassCheck_Click(object sender, EventArgs e)
        {
            Clear_Sites();
            lblSite.Text = btnVk.Text;
        }

        private void BtnGosuslugi_Click(object sender, EventArgs e)
        {
            Clear_Sites();
            lblSite.Text = btnGosuslugi.Text;
        }

        private void BtnOzone_Click(object sender, EventArgs e)
        {
            Clear_Sites();
            lblSite.Text = btnOzone.Text;
        }

        private void BtnInstagram_Click(object sender, EventArgs e)
        {
            Clear_Sites();
            lblSite.Text = btnInstagram.Text;
        }

        private void BtnFacebook_Click(object sender, EventArgs e)
        {
            Clear_Sites();
            lblSite.Text = btnFacebook.Text;
        }

        private void BtnMirea_Click(object sender, EventArgs e)
        {
            Clear_Sites();
            lblSite.Text = btnMirea.Text;
        }

        private void BtnDrom_Click(object sender, EventArgs e)
        {
            Clear_Sites();
            lblSite.Text = btnDrom.Text;
        }

        private void BtnAuto_Click(object sender, EventArgs e)
        {
            Clear_Sites();
            lblSite.Text = btnAuto.Text;
        }

        private void BtnPochta_Click(object sender, EventArgs e)
        {
            Clear_Sites();
            lblSite.Text = btnPochta.Text;
        }

        void Clear_Sites()
        {
            btnVk.Visible = false;
            btnGosuslugi.Visible = false;
            btnOzone.Visible = false;
            btnInstagram.Visible = false;
            btnFacebook.Visible = false;
            btnMirea.Visible = false;
            btnDrom.Visible = false;
            btnAuto.Visible = false;
            btnPochta.Visible = false;

            lblWelcome.Visible = true;
            txtLog.Visible = true;
            txtPass.Visible = true;
            btnEnter.Visible = true;
        }

        void Add_Sites()
        {
            btnVk.Visible = true;
            btnGosuslugi.Visible = true;
            btnOzone.Visible = true;
            btnInstagram.Visible = true;
            btnFacebook.Visible = true;
            btnMirea.Visible = true;
            btnDrom.Visible = true;
            btnAuto.Visible = true;
            btnPochta.Visible = true;

            lblWelcome.Visible = false;
            txtLog.Visible = false;
            txtPass.Visible = false;
            btnEnter.Visible = false;
            pnlPass.Visible = false;
            pnlLog.Visible = false;
            btnOfferPass.Visible = false;
            btnOfferLog.Visible = false;
            lblNiceEnt.Visible = false;
            txtLog.Text = "";
            txtPass.Text = "";
            btnOfferLog.Text = "";

            pnlDataTop.Visible = false;
            pnlDataButtom.Visible = false;
            lblPassport.Visible = false;
            lblPass.Visible = false;
            lblNumberPhone.Visible = false;
            lblPhone.Visible = false;
            lblDateBirthdat.Visible = false;
            lblBirthday.Visible = false;
            lblEmailPochta.Visible = false;
            lblMail.Visible = false;
            lblPlaceOfLive.Visible = false;
            lblRegistr.Visible = false;
            lblPlaceOfWork.Visible = false;
            lblWork.Visible = false;
            lblGender.Visible = false;
            lblGend.Visible = false;
            btnSaveData.Visible = false;

        }



        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Add_Sites();
            this.Hide();
        }
        private void TxtPass_MouseDown(object sender, MouseEventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select Count (*) From PersData where ЛогинСПД LIKE '%{LoginSPD}%' AND Сайт LIKE '%{lblSite.Text}%'", sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows[0][0].ToString() == "1")
            {
                pnlLog.Visible = true;
                btnOfferLog.Visible = true;
                pnlPass.Visible = false;
                btnOfferPass.Visible = false;

                SqlCommand sqlCommand = new SqlCommand($"SELECT Логин FROM Persdata WHERE ЛогинСПД LIKE '%{LoginSPD}%' AND Сайт LIKE '%{lblSite.Text}%'", sqlConnection);
                btnOfferLog.Text = sqlCommand.ExecuteScalar().ToString();
            }
            else
            {
                pnlLog.Visible = false;
                btnOfferLog.Visible = false;
                pnlPass.Visible = false;
                btnOfferPass.Visible = false;
            }

        }

        private void TxtPass_MouseDown_1(object sender, MouseEventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"Select Count (*) From PersData where ЛогинСПД LIKE '%{LoginSPD}%' AND Сайт LIKE '%{lblSite.Text}%'", sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows[0][0].ToString() == "1")
            {
                pnlPass.Visible = true;
                btnOfferPass.Visible = true;
                pnlLog.Visible = false;
                btnOfferLog.Visible = false;

                SqlCommand sqlCommand = new SqlCommand($"SELECT Пароль FROM Persdata WHERE ЛогинСПД LIKE '%{LoginSPD}%' AND Сайт LIKE '%{lblSite.Text}%'", sqlConnection);
                btnOfferPass.Text = sqlCommand.ExecuteScalar().ToString();
            }
            else
            {
                pnlLog.Visible = false;
                btnOfferLog.Visible = false;
                pnlPass.Visible = false;
                btnOfferPass.Visible = false;
            }


        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Count (*) From PersDataWeb where Логин = '" + txtLog.Text + "' and Пароль = '" + txtPass.Text + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            SqlDataAdapter DA = new SqlDataAdapter($"Select Count (*) From PersData where ЛогинСПД LIKE '%{LoginSPD}%' AND Сайт LIKE '%{lblSite.Text}%'", sqlConnection);
            DataTable DT = new DataTable();
            DA.Fill(DT);


            if (dataTable.Rows[0][0].ToString() == "1" && DT.Rows[0][0].ToString() == "0")
            {
                labelQwest.Visible = true;
                pnlPass.Height = 70;
                pnlPass.Visible = true;
                btnYes.Visible = true;
                btnNo.Visible = true;
            }
            if (dataTable.Rows[0][0].ToString() == "1" && DT.Rows[0][0].ToString() == "1")
            {
                btnEnter.Visible = false;
                txtLog.Visible = false;
                txtPass.Visible = false;
                lblWelcome.Visible = false;
                btnYes.Visible = false;
                pnlPass.Visible = false;
                pnlPass.Height = 45;
                btnNo.Visible = false;

                lblNiceEnt.Visible = true;
                lblNiceEnt.Text = "Вы успешно вошли в личный кабинет";
                btnToViewData.Visible = true;
            }
            if (dataTable.Rows[0][0].ToString() == "0" && DT.Rows[0][0].ToString() == "0")
            {
                FormMessageBox c = new FormMessageBox();
                c.labelError.Text = "Данные введены не верно\nПопробуйте еще раз";
                c.ShowDialog();
            }

        }

        private void FormPasswordCheck_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);

            sqlConnection.Open();
        }

        private void BtnOfferLog_Click(object sender, EventArgs e)
        {
            pnlLog.Visible = false;
            btnOfferLog.Visible = false;

            txtLog.Text = btnOfferLog.Text;
        }

        private void BtnOfferPass_Click(object sender, EventArgs e)
        {
            pnlPass.Visible = false;
            btnOfferPass.Visible = false;

            txtPass.Text = btnOfferPass.Text;

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Add_Sites();
            lblSite.Text = "";
        }

        private void BtnQwest_Click(object sender, EventArgs e)
        {
            btnEnter.Visible = false;
            txtLog.Visible = false;
            txtPass.Visible = false;
            lblWelcome.Visible = false;
            btnYes.Visible = false;
            pnlPass.Visible = false;
            pnlPass.Height = 45;
            btnNo.Visible = false;
            labelQwest.Visible = false;

            lblNiceEnt.Visible = true;
            lblNiceEnt.Text = "Вы успешно вошли в личный кабинет";
            btnToViewData.Visible = true;

            SqlCommand command = new SqlCommand($"INSERT INTO [PersData] (Имя, Фамилия, Сайт, Логин, Пароль, ЛогинСПД) VALUES (N'{NAME}', N'{SURNAME}', '{lblSite.Text}', '{txtLog.Text}', '{txtPass.Text}', '{LoginSPD}')", sqlConnection);
            command.ExecuteNonQuery();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            btnEnter.Visible = false;
            txtLog.Visible = false;
            txtPass.Visible = false;
            lblWelcome.Visible = false;
            btnYes.Visible = false;
            pnlPass.Visible = false;
            pnlPass.Height = 45;
            btnNo.Visible = false;
            labelQwest.Visible = false;

            lblNiceEnt.Visible = true;
            lblNiceEnt.Text = "Вы успешно вошли в личный кабинет";
            btnToViewData.Visible = true;

            SqlCommand command = new SqlCommand($"INSERT INTO [PersData] (Имя, Фамилия, Сайт, ЛогинСПД) VALUES (N'{NAME}', N'{SURNAME}', '{lblSite.Text}', '{LoginSPD}')", sqlConnection);
            command.ExecuteNonQuery();
        }

        private void BtnToViewData_Click(object sender, EventArgs e)
        {
            btnToViewData.Visible = false;
            lblNiceEnt.Visible = false;

            btnSaveData.Visible = true;
            pnlDataTop.Visible = true;
            pnlDataButtom.Visible = true;
            lblPassport.Visible = true;
            lblPass.Visible = true;
            lblNumberPhone.Visible = true;
            lblPhone.Visible = true;
            lblDateBirthdat.Visible = true;
            lblBirthday.Visible = true;
            lblEmailPochta.Visible = true;
            lblMail.Visible = true;
            lblPlaceOfLive.Visible = true;
            lblRegistr.Visible = true;
            lblPlaceOfWork.Visible = true;
            lblWork.Visible = true;
            lblGender.Visible = true;
            lblGend.Visible = true;

            SqlCommand passport = new SqlCommand($"SELECT Паспортные_данные FROM PersDataWeb WHERE ЛогинСПД LIKE '%{LoginSPD}%' AND Сайт LIKE '%{lblSite.Text}%'", sqlConnection);
            lblPass.Text = passport.ExecuteScalar().ToString();

            SqlCommand numphone = new SqlCommand($"SELECT Номер_телефона FROM PersDataWeb WHERE ЛогинСПД LIKE '%{LoginSPD}%' AND Сайт LIKE '%{lblSite.Text}%'", sqlConnection);
            lblPhone.Text = numphone.ExecuteScalar().ToString();

            SqlCommand birthday = new SqlCommand($"SELECT Дата_рождения FROM PersDataWeb WHERE ЛогинСПД LIKE '%{LoginSPD}%' AND Сайт LIKE '%{lblSite.Text}%'", sqlConnection);
            lblBirthday.Text = birthday.ExecuteScalar().ToString();

            SqlCommand email = new SqlCommand($"SELECT Электронная_почта FROM PersDataWeb WHERE ЛогинСПД LIKE '%{LoginSPD}%' AND Сайт LIKE '%{lblSite.Text}%'", sqlConnection);
            lblMail.Text = email.ExecuteScalar().ToString();

            SqlCommand registr = new SqlCommand($"SELECT Место_регистрации FROM PersDataWeb WHERE ЛогинСПД LIKE '%{LoginSPD}%' AND Сайт LIKE '%{lblSite.Text}%'", sqlConnection);
            lblRegistr.Text = registr.ExecuteScalar().ToString();

            SqlCommand placework = new SqlCommand($"SELECT Место_работы FROM PersDataWeb WHERE ЛогинСПД LIKE '%{LoginSPD}%' AND Сайт LIKE '%{lblSite.Text}%'", sqlConnection);
            lblWork.Text = placework.ExecuteScalar().ToString();

            SqlCommand gender = new SqlCommand($"SELECT Пол FROM PersDataWeb WHERE ЛогинСПД LIKE '%{LoginSPD}%' AND Сайт LIKE '%{lblSite.Text}%'", sqlConnection);
            lblGend.Text = gender.ExecuteScalar().ToString();
        }

        private void BtnSaveData_Click(object sender, EventArgs e)
        {
            pnlDataTop.Visible = false;
            pnlDataButtom.Visible = false;
            lblPassport.Visible = false;
            lblPass.Visible = false;
            lblNumberPhone.Visible = false;
            lblPhone.Visible = false;
            lblDateBirthdat.Visible = false;
            lblBirthday.Visible = false;
            lblEmailPochta.Visible = false;
            lblMail.Visible = false;
            lblPlaceOfLive.Visible = false;
            lblRegistr.Visible = false;
            lblPlaceOfWork.Visible = false;
            lblWork.Visible = false;
            lblGender.Visible = false;
            lblGend.Visible = false;
            btnSaveData.Visible = false;

            lblNiceEnt.Text = "Данные сохранены";
            lblNiceEnt.Visible = true;
            SqlCommand command = new SqlCommand($"UPDATE PersData SET Имя = N'{NAME}', Фамилия = N'{SURNAME}', Сайт = '{lblSite.Text}', Номер_телефона = '{lblPhone.Text}', Паспортные_данные = '{lblPass.Text}', Дата_рождения = N'{lblBirthday.Text}', Электронная_почта = '{lblMail.Text}', Место_регистрации = N'{lblRegistr.Text}', Место_работы = N'{lblWork.Text}', Пол = N'{lblGend.Text}' WHERE ЛогинСПД LIKE '%{LoginSPD}%' AND Сайт LIKE '%{lblSite.Text}%'", sqlConnection);
            command.ExecuteNonQuery();
        }
    }
}
