using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaqueForm saqueTela = new SaqueForm();
            saqueTela.Show();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositoForm depositoTela = new DepositoForm();
            depositoTela.Show();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferenciaForm transferenciaTela = new TransferenciaForm();
            transferenciaTela.Show();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExtratoForm extratoTela = new ExtratoForm();
            extratoTela.Show();
        }
    }
}
