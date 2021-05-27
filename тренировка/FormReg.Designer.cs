namespace тренировка
{
    partial class FormReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReg));
            this.buttonToEnter = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.labelSurName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.labelReg = new System.Windows.Forms.Label();
            this.panelSurName = new System.Windows.Forms.Panel();
            this.labelNumPhone = new System.Windows.Forms.Label();
            this.panelNumPhone = new System.Windows.Forms.Panel();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.panelLog = new System.Windows.Forms.Panel();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.panelPass = new System.Windows.Forms.Panel();
            this.textBoxComPass = new System.Windows.Forms.TextBox();
            this.labelComPass = new System.Windows.Forms.Label();
            this.panelComPass = new System.Windows.Forms.Panel();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxNumPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelNameMist = new System.Windows.Forms.Label();
            this.labelSurNameMist = new System.Windows.Forms.Label();
            this.labelLogMist = new System.Windows.Forms.Label();
            this.labelPassMist = new System.Windows.Forms.Label();
            this.labelComPassMist = new System.Windows.Forms.Label();
            this.labelNumPhoneMist = new System.Windows.Forms.Label();
            this.panelDrag = new System.Windows.Forms.Panel();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.SuspendLayout();
            // 
            // buttonToEnter
            // 
            this.buttonToEnter.BackColor = System.Drawing.Color.White;
            this.buttonToEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToEnter.FlatAppearance.BorderSize = 0;
            this.buttonToEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonToEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonToEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToEnter.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonToEnter.Location = new System.Drawing.Point(95, 610);
            this.buttonToEnter.Name = "buttonToEnter";
            this.buttonToEnter.Size = new System.Drawing.Size(166, 25);
            this.buttonToEnter.TabIndex = 39;
            this.buttonToEnter.Text = "На страницу авторизации";
            this.buttonToEnter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonToEnter.UseVisualStyleBackColor = false;
            this.buttonToEnter.Click += new System.EventHandler(this.ButtonToEnter_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonClear.Location = new System.Drawing.Point(15, 560);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(320, 40);
            this.buttonClear.TabIndex = 37;
            this.buttonClear.Text = "СТЕРЕТЬ";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.FlatAppearance.BorderSize = 0;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.ForeColor = System.Drawing.Color.White;
            this.buttonReg.Location = new System.Drawing.Point(15, 510);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(320, 40);
            this.buttonReg.TabIndex = 38;
            this.buttonReg.Text = "ЗАРЕГЕСТРИРОВАТЬСЯ";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.ButtonReg_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(327, 10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(13, 13);
            this.buttonClose.TabIndex = 36;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxName.Location = new System.Drawing.Point(25, 90);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(300, 20);
            this.textBoxName.TabIndex = 31;
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxSurName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSurName.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSurName.Location = new System.Drawing.Point(25, 160);
            this.textBoxSurName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSurName.MaxLength = 30;
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(300, 20);
            this.textBoxSurName.TabIndex = 32;
            // 
            // labelSurName
            // 
            this.labelSurName.AutoSize = true;
            this.labelSurName.BackColor = System.Drawing.Color.Transparent;
            this.labelSurName.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurName.ForeColor = System.Drawing.Color.Gray;
            this.labelSurName.Location = new System.Drawing.Point(10, 130);
            this.labelSurName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurName.Name = "labelSurName";
            this.labelSurName.Size = new System.Drawing.Size(62, 20);
            this.labelSurName.TabIndex = 29;
            this.labelSurName.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.Gray;
            this.labelName.Location = new System.Drawing.Point(10, 60);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 20);
            this.labelName.TabIndex = 30;
            this.labelName.Text = "Имя";
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.panelName.Location = new System.Drawing.Point(15, 85);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(320, 30);
            this.panelName.TabIndex = 34;
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelReg.Location = new System.Drawing.Point(10, 10);
            this.labelReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(112, 25);
            this.labelReg.TabIndex = 28;
            this.labelReg.Text = "РЕГИСТРАЦИЯ";
            // 
            // panelSurName
            // 
            this.panelSurName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.panelSurName.Location = new System.Drawing.Point(15, 155);
            this.panelSurName.Name = "panelSurName";
            this.panelSurName.Size = new System.Drawing.Size(320, 30);
            this.panelSurName.TabIndex = 35;
            // 
            // labelNumPhone
            // 
            this.labelNumPhone.AutoSize = true;
            this.labelNumPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelNumPhone.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumPhone.ForeColor = System.Drawing.Color.Gray;
            this.labelNumPhone.Location = new System.Drawing.Point(10, 200);
            this.labelNumPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumPhone.Name = "labelNumPhone";
            this.labelNumPhone.Size = new System.Drawing.Size(103, 20);
            this.labelNumPhone.TabIndex = 29;
            this.labelNumPhone.Text = "Номер телефона";
            // 
            // panelNumPhone
            // 
            this.panelNumPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.panelNumPhone.Location = new System.Drawing.Point(15, 225);
            this.panelNumPhone.Name = "panelNumPhone";
            this.panelNumPhone.Size = new System.Drawing.Size(320, 30);
            this.panelNumPhone.TabIndex = 35;
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLog.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLog.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLog.Location = new System.Drawing.Point(25, 300);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLog.MaxLength = 30;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(300, 20);
            this.textBoxLog.TabIndex = 41;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.BackColor = System.Drawing.Color.Transparent;
            this.labelLog.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.ForeColor = System.Drawing.Color.Gray;
            this.labelLog.Location = new System.Drawing.Point(10, 270);
            this.labelLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(43, 20);
            this.labelLog.TabIndex = 40;
            this.labelLog.Text = "Логин";
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.panelLog.Location = new System.Drawing.Point(15, 295);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(320, 30);
            this.panelLog.TabIndex = 42;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPass.Location = new System.Drawing.Point(25, 370);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPass.MaxLength = 30;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '•';
            this.textBoxPass.Size = new System.Drawing.Size(300, 20);
            this.textBoxPass.TabIndex = 44;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.ForeColor = System.Drawing.Color.Gray;
            this.labelPass.Location = new System.Drawing.Point(10, 340);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(51, 20);
            this.labelPass.TabIndex = 43;
            this.labelPass.Text = "Пароль";
            // 
            // panelPass
            // 
            this.panelPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.panelPass.Location = new System.Drawing.Point(15, 365);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(320, 30);
            this.panelPass.TabIndex = 45;
            // 
            // textBoxComPass
            // 
            this.textBoxComPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxComPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxComPass.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxComPass.ForeColor = System.Drawing.Color.Gray;
            this.textBoxComPass.Location = new System.Drawing.Point(25, 440);
            this.textBoxComPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComPass.MaxLength = 30;
            this.textBoxComPass.Name = "textBoxComPass";
            this.textBoxComPass.PasswordChar = '•';
            this.textBoxComPass.Size = new System.Drawing.Size(300, 20);
            this.textBoxComPass.TabIndex = 47;
            // 
            // labelComPass
            // 
            this.labelComPass.AutoSize = true;
            this.labelComPass.BackColor = System.Drawing.Color.Transparent;
            this.labelComPass.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComPass.ForeColor = System.Drawing.Color.Gray;
            this.labelComPass.Location = new System.Drawing.Point(10, 410);
            this.labelComPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComPass.Name = "labelComPass";
            this.labelComPass.Size = new System.Drawing.Size(112, 20);
            this.labelComPass.TabIndex = 46;
            this.labelComPass.Text = "Повторите пароль";
            // 
            // panelComPass
            // 
            this.panelComPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.panelComPass.Location = new System.Drawing.Point(15, 435);
            this.panelComPass.Name = "panelComPass";
            this.panelComPass.Size = new System.Drawing.Size(320, 30);
            this.panelComPass.TabIndex = 48;
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowPass.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxShowPass.Location = new System.Drawing.Point(230, 470);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(110, 22);
            this.checkBoxShowPass.TabIndex = 49;
            this.checkBoxShowPass.Text = "Показать пароль";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.CheckBoxShowPass_CheckedChanged);
            // 
            // maskedTextBoxNumPhone
            // 
            this.maskedTextBoxNumPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.maskedTextBoxNumPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxNumPhone.Font = new System.Drawing.Font("Proxima Nova ExCn Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxNumPhone.ForeColor = System.Drawing.Color.Gray;
            this.maskedTextBoxNumPhone.Location = new System.Drawing.Point(25, 230);
            this.maskedTextBoxNumPhone.Mask = "+7 (000) 000 - 00 - 00";
            this.maskedTextBoxNumPhone.Name = "maskedTextBoxNumPhone";
            this.maskedTextBoxNumPhone.Size = new System.Drawing.Size(300, 20);
            this.maskedTextBoxNumPhone.TabIndex = 50;
            // 
            // labelNameMist
            // 
            this.labelNameMist.AutoSize = true;
            this.labelNameMist.Font = new System.Drawing.Font("Proxima Nova ExCn Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameMist.ForeColor = System.Drawing.Color.Silver;
            this.labelNameMist.Location = new System.Drawing.Point(150, 60);
            this.labelNameMist.Name = "labelNameMist";
            this.labelNameMist.Size = new System.Drawing.Size(0, 20);
            this.labelNameMist.TabIndex = 51;
            // 
            // labelSurNameMist
            // 
            this.labelSurNameMist.AutoSize = true;
            this.labelSurNameMist.Font = new System.Drawing.Font("Proxima Nova ExCn Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurNameMist.ForeColor = System.Drawing.Color.Silver;
            this.labelSurNameMist.Location = new System.Drawing.Point(150, 130);
            this.labelSurNameMist.Name = "labelSurNameMist";
            this.labelSurNameMist.Size = new System.Drawing.Size(0, 20);
            this.labelSurNameMist.TabIndex = 52;
            // 
            // labelLogMist
            // 
            this.labelLogMist.AutoSize = true;
            this.labelLogMist.Font = new System.Drawing.Font("Proxima Nova ExCn Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogMist.ForeColor = System.Drawing.Color.Silver;
            this.labelLogMist.Location = new System.Drawing.Point(150, 270);
            this.labelLogMist.Name = "labelLogMist";
            this.labelLogMist.Size = new System.Drawing.Size(0, 20);
            this.labelLogMist.TabIndex = 54;
            // 
            // labelPassMist
            // 
            this.labelPassMist.AutoSize = true;
            this.labelPassMist.Font = new System.Drawing.Font("Proxima Nova ExCn Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassMist.ForeColor = System.Drawing.Color.Silver;
            this.labelPassMist.Location = new System.Drawing.Point(150, 340);
            this.labelPassMist.Name = "labelPassMist";
            this.labelPassMist.Size = new System.Drawing.Size(0, 20);
            this.labelPassMist.TabIndex = 55;
            // 
            // labelComPassMist
            // 
            this.labelComPassMist.AutoSize = true;
            this.labelComPassMist.Font = new System.Drawing.Font("Proxima Nova ExCn Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComPassMist.ForeColor = System.Drawing.Color.Silver;
            this.labelComPassMist.Location = new System.Drawing.Point(150, 410);
            this.labelComPassMist.Name = "labelComPassMist";
            this.labelComPassMist.Size = new System.Drawing.Size(0, 20);
            this.labelComPassMist.TabIndex = 56;
            // 
            // labelNumPhoneMist
            // 
            this.labelNumPhoneMist.AutoSize = true;
            this.labelNumPhoneMist.Font = new System.Drawing.Font("Proxima Nova ExCn Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumPhoneMist.ForeColor = System.Drawing.Color.Silver;
            this.labelNumPhoneMist.Location = new System.Drawing.Point(150, 200);
            this.labelNumPhoneMist.Name = "labelNumPhoneMist";
            this.labelNumPhoneMist.Size = new System.Drawing.Size(0, 20);
            this.labelNumPhoneMist.TabIndex = 57;
            // 
            // panelDrag
            // 
            this.panelDrag.Location = new System.Drawing.Point(0, 0);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(350, 650);
            this.panelDrag.TabIndex = 58;
            this.panelDrag.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDrag_Paint);
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = false;
            this.bunifuFormDock1.ShowDockingIndicators = false;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 650);
            this.Controls.Add(this.labelNumPhoneMist);
            this.Controls.Add(this.labelComPassMist);
            this.Controls.Add(this.labelPassMist);
            this.Controls.Add(this.labelLogMist);
            this.Controls.Add(this.labelSurNameMist);
            this.Controls.Add(this.labelNameMist);
            this.Controls.Add(this.maskedTextBoxNumPhone);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.textBoxComPass);
            this.Controls.Add(this.labelComPass);
            this.Controls.Add(this.panelComPass);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.panelPass);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.buttonToEnter);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurName);
            this.Controls.Add(this.labelNumPhone);
            this.Controls.Add(this.labelSurName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.panelNumPhone);
            this.Controls.Add(this.panelSurName);
            this.Controls.Add(this.panelDrag);
            this.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToEnter;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.Label labelSurName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Panel panelSurName;
        private System.Windows.Forms.Label labelNumPhone;
        private System.Windows.Forms.Panel panelNumPhone;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.TextBox textBoxComPass;
        private System.Windows.Forms.Label labelComPass;
        private System.Windows.Forms.Panel panelComPass;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumPhone;
        private System.Windows.Forms.Label labelNameMist;
        private System.Windows.Forms.Label labelSurNameMist;
        private System.Windows.Forms.Label labelLogMist;
        private System.Windows.Forms.Label labelPassMist;
        private System.Windows.Forms.Label labelComPassMist;
        private System.Windows.Forms.Label labelNumPhoneMist;
        private System.Windows.Forms.Panel panelDrag;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
    }
}