using System;
using System.Windows.Forms;

namespace XO_Game
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            Form frm = new FrmGame();
            frm.ShowDialog();
        }

    }
}
