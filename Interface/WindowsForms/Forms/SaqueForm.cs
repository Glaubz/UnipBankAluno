using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class SaqueForm : Form
    {
        public SaqueForm()
        {
            InitializeComponent();

            lblValor.Text = ValorEmConta();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm menuTela = new MainForm();
            menuTela.Show();
        }

        private void lblValor_Click(object sender, EventArgs e)
        {
            
        }
    }
}
