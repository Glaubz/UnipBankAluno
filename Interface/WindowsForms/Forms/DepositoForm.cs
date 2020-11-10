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
    public partial class DepositoForm : Form
    {
        public DepositoForm()
        {
            InitializeComponent();

            ctlConta _ctlConta = new ctlConta();
            lblValor.Text = _ctlConta.ValorEmConta(Context.Usuario).ToString();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm menuTela = new MainForm();
            menuTela.Show();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            ctlDeposito _ctlDeposito = new ctlDeposito();

            try
            {
                decimal valorSaque = decimal.Parse(txtValorDeposito.Text);
                lblValor.Text = _ctlDeposito.Depositar(valorSaque, Context.Usuario).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex?.InnerException?.Message ?? ex?.Message);
            }
        }
    }
}
