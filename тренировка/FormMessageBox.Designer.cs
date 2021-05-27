namespace тренировка
{
    partial class FormMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageBox));
            this.labelError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pbError = new System.Windows.Forms.PictureBox();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.panelForm = new System.Windows.Forms.Panel();
            this.bunifuFormDock2 = new Bunifu.UI.WinForms.BunifuFormDock();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Proxima Nova Cn Lt", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            this.labelError.Location = new System.Drawing.Point(10, 77);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(330, 53);
            this.labelError.TabIndex = 17;
            this.labelError.Text = "Данные введены не верно\r\nПопробуйте еще раз";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 2);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            this.panel2.Location = new System.Drawing.Point(10, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 2);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            this.panel3.Location = new System.Drawing.Point(10, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 120);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            this.panel4.Location = new System.Drawing.Point(338, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 100);
            this.panel4.TabIndex = 21;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(327, 8);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(17, 17);
            this.buttonClose.TabIndex = 38;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // pbError
            // 
            this.pbError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbError.BackgroundImage")));
            this.pbError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbError.Location = new System.Drawing.Point(18, 30);
            this.pbError.Name = "pbError";
            this.pbError.Size = new System.Drawing.Size(314, 35);
            this.pbError.TabIndex = 39;
            this.pbError.TabStop = false;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = false;
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
            // panelForm
            // 
            this.panelForm.Controls.Add(this.buttonClose);
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(350, 150);
            this.panelForm.TabIndex = 40;
            // 
            // bunifuFormDock2
            // 
            this.bunifuFormDock2.AllowFormDragging = true;
            this.bunifuFormDock2.AllowFormDropShadow = true;
            this.bunifuFormDock2.AllowFormResizing = false;
            this.bunifuFormDock2.AllowHidingBottomRegion = true;
            this.bunifuFormDock2.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock2.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock2.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock2.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock2.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock2.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock2.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock2.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock2.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock2.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock2.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock2.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock2.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock2.ContainerControl = this;
            this.bunifuFormDock2.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock2.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock2.DockingOptions.DockAll = true;
            this.bunifuFormDock2.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock2.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock2.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock2.DockingOptions.DockLeft = true;
            this.bunifuFormDock2.DockingOptions.DockRight = true;
            this.bunifuFormDock2.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock2.DockingOptions.DockTopRight = true;
            this.bunifuFormDock2.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock2.ParentForm = this;
            this.bunifuFormDock2.ShowCursorChanges = false;
            this.bunifuFormDock2.ShowDockingIndicators = false;
            this.bunifuFormDock2.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock2.TitleBarOptions.BunifuFormDock = this.bunifuFormDock2;
            this.bunifuFormDock2.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock2.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock2.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // FormMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.pbError);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pbError;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Panel panelForm;
        public System.Windows.Forms.Label labelError;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock2;
    }
}