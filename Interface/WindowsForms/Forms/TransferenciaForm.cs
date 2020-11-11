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
    public partial class TransferenciaForm : Form
    {
        public TransferenciaForm()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm menuTela = new MainForm();
            menuTela.Show();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            ctlTransferencia _ctlTransferencia = new ctlTransferencia();

            try
            {
                decimal valorTransferencia = decimal.Parse(txtValorTransferencia.Text);
                string usuarioOrigem = Context.Usuario;
                string usuarioDestino = txtNomeDestinatario.Text;

                _ctlTransferencia.Transferir(valorTransferencia, usuarioOrigem, usuarioDestino);

                MessageBox.Show("Transferencia realizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex?.InnerException?.Message ?? ex?.Message);
            }
        }
    }
}
