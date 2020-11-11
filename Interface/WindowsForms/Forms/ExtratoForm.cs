using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClientControl;

namespace WindowsForms.Forms
{
    public partial class ExtratoForm : Form
    {
        public ExtratoForm()
        {
            InitializeComponent();

            ctlConta _ctlConta = new ctlConta();
            lblValor.Text = _ctlConta.ValorEmConta(Context.Usuario).ToString();
            ctlExtrato _ctlExtrato = new ctlExtrato();
            lblLog1.Text = _ctlExtrato.GetLogs()[4];
            lblLog2.Text = _ctlExtrato.GetLogs()[3];
            lblLog3.Text = _ctlExtrato.GetLogs()[2];
            lblLog4.Text = _ctlExtrato.GetLogs()[1];
            lblLog5.Text = _ctlExtrato.GetLogs()[0];
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm menuTela = new MainForm();
            menuTela.Show();
        }

    }
}
