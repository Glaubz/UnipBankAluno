using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class ExtratoForm : Form
    {
        public ExtratoForm()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm menuTela = new MainForm();
            menuTela.Show();
        }
    }
}
