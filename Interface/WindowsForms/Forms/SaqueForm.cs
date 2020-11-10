using ClientControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClientModel;

namespace WindowsForms.Forms
{
    public partial class SaqueForm : Form
    {
        

        public SaqueForm()
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

        private void btnSacar_Click(object sender, EventArgs e)
        {
            ctlSaque _ctlSaque = new ctlSaque();

            try
            {
                decimal valorSaque = decimal.Parse(txtValorSaque.Text);
                lblValor.Text = _ctlSaque.Saque(valorSaque, Context.Usuario).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex?.InnerException?.Message ?? ex?.Message);
            }
        }
    }
}
