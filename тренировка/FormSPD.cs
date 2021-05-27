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
    public partial class FormSPD : Form
    {
        public string LoginSPD;
        public string NAME;
        public string SURNAME;

        private SqlConnection sqlConnection = null;
        public FormSPD()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(bnfGradPnlTitle);
            bunifuFormDock1.SubscribeControlToDragEvents(lblTitle);
            bunifuFormDock1.SubscribeControlToDragEvents(lblUserName);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormSPD_Load(object sender, EventArgs e)
        {
            Opac_Text();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);

            sqlConnection.Open();
            
        }

        async void Opac_Text()
        {
            for (byte r = 255, g = 255, b = 255; r >= 116 & g >= 86 & b >= 174; r -= 5, g -= 6, b -= 3, await Task.Delay(40))
            {
                lblWelcome.ForeColor = Color.FromArgb(r, g, b);
            }
        }

        private void BnfBtnPersData_Click(object sender, EventArgs e)
        {
            txtSearchPass.Visible = false;
            txtSearchSite.Visible = false;
            bnBtnPassCheck.Visible = false;
            lblWelcome.Visible = false;

            DGV.DefaultCellStyle.SelectionBackColor = Color.White;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Имя, Фамилия, Паспортные_данные, Номер_телефона, Дата_рождения, Электронная_почта, Место_регистрации, Место_работы, Пол FROM Users WHERE Логин = '" + LoginSPD + "'", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DGV.DataSource = dataSet.Tables[0];

            DGV.Columns["Имя"].Width = 150;
            DGV.Columns["Фамилия"].Width = 150;
            DGV.Columns["Номер_телефона"].Width = 150;
            DGV.Columns["Паспортные_данные"].Width = 150;
            DGV.Columns["Дата_рождения"].Width = 150;
            DGV.Columns["Электронная_почта"].Width = 220;
            DGV.Columns["Место_регистрации"].Width = 450;
            DGV.Columns["Место_работы"].Width = 400;
            DGV.Columns["Пол"].Width = 80;
        }



        private void BnfBtnPass_Click(object sender, EventArgs e)
        {
            txtSearchPass.Visible = true;
            txtSearchSite.Visible = false;
            bnBtnPassCheck.Visible = true;
            lblWelcome.Visible = false;

            DGV.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Сайт, Логин, Пароль FROM PersData WHERE ЛогинСПД = '" + LoginSPD + "'", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DGV.DataSource = dataSet.Tables[0];
        }

        private void BnfBtnSites_Click(object sender, EventArgs e)
        {
            txtSearchPass.Visible = false;
            txtSearchSite.Visible = true;
            bnBtnPassCheck.Visible = false;
            lblWelcome.Visible = false;

            BnfBtnSites.ForeColor = Color.FromArgb(255, 255, 255);
            BnfBtnSites.IdleFillColor = Color.FromArgb(116, 86, 174);

            DGV.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Имя, Сайт, Паспортные_данные, Номер_телефона, Дата_рождения, Электронная_почта, Место_регистрации, Место_работы, Пол FROM PersData WHERE ЛогинСПД = '" + LoginSPD + "'", sqlConnection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DGV.DataSource = dataSet.Tables[0];



            DGV.Columns["Имя"].Width = 0;
            DGV.Columns["Сайт"].Width = 170;
            DGV.Columns["Номер_телефона"].Width = 170;
            DGV.Columns["Паспортные_данные"].Width = 170;
            DGV.Columns["Дата_рождения"].Width = 170;
            DGV.Columns["Электронная_почта"].Width = 240;
            DGV.Columns["Место_регистрации"].Width = 470;
            DGV.Columns["Место_работы"].Width = 420;
            DGV.Columns["Пол"].Width = 85;
        }

        private void BnfBtnExit_Click_1(object sender, EventArgs e)
        {
            FormEnter f = new FormEnter();
            f.Show();
            this.Hide();
        }




        //Неипользуемые методы
        #region
        private void DGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
        private void DGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }
        private void DGV_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
        }
        private void DGV_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
        }
        private void BnfBtnExit_Click(object sender, EventArgs e)
        {
        }

        #endregion

        void BtnSearch_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void BnfBtnSites_Leave(object sender, EventArgs e)
        {
            BnfBtnSites.ForeColor = Color.FromArgb(255, 255, 255);
            BnfBtnSites.IdleFillColor = Color.FromArgb(116, 86, 174);

        }

        private void TxtSearch_TextChange(object sender, EventArgs e)
        {
            (DGV.DataSource as DataTable).DefaultView.RowFilter = $"Сайт LIKE '%{txtSearchSite.Text}%' OR Паспортные_данные LIKE '%{txtSearchSite.Text}%' OR Номер_телефона LIKE '%{txtSearchSite.Text}%' OR Convert(Дата_рождения,'System.String') LIKE '%{txtSearchSite.Text}%' OR Электронная_почта LIKE '%{txtSearchSite.Text}%' OR Место_регистрации LIKE '%{txtSearchSite.Text}%' OR Место_работы LIKE '%{txtSearchSite.Text}%' OR Пол LIKE '%{txtSearchSite.Text}%'";
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSearchPass_TextChange(object sender, EventArgs e)
        {
            (DGV.DataSource as DataTable).DefaultView.RowFilter = $"Сайт LIKE '%{txtSearchPass.Text}%' OR Логин LIKE '%{txtSearchPass.Text}%' OR Пароль LIKE '%{txtSearchPass.Text}%'";
        }

        private void BnBtnPassCheck_Click(object sender, EventArgs e)
        {
            FormPasswordCheck f = new FormPasswordCheck();
            {
                f.LoginSPD = LoginSPD;
                f.NAME = NAME;
                f.SURNAME = SURNAME;
            }
            

            f.ShowDialog();
        }
    }
}
