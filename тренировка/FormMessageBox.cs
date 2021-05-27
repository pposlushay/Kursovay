using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace тренировка
{
    public partial class FormMessageBox : Form
    {
        public FormMessageBox()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(panelForm);
            bunifuFormDock1.SubscribeControlToDragEvents(pbError);
            bunifuFormDock1.SubscribeControlToDragEvents(labelError);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
