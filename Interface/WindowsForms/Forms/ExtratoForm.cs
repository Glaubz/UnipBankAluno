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
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm menuTela = new MainForm();
            menuTela.Show();
        }

        private void dgvLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDados.CurrentRow.Index != -1)
                txtLog.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
