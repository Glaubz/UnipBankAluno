using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClientModel;
using ClientControl;

namespace WindowsForms.Forms
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
            btnAtualizar.Enabled = false;

            MessageBox.Show("Salvo com sucesso!! ");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            mdlClient _mdlClient = new mdlClient();
            _mdlClient.cpf = txtCpf.Text;
            _mdlClient.nome = txtNome.Text;
            _mdlClient.rua = txtRua.Text;
            _mdlClient.nr_rua = Convert.ToInt32(txtNumero.Text);
            _mdlClient.renda = Convert.ToInt32(txtRenda.Text);
            _mdlClient.dt_nasc = txtDataNasc.Text;

            ctlClient _ctlCliente = new ctlClient();
            bool retorno = _ctlCliente.Cadastro(_mdlClient.cpf, _mdlClient.nome, _mdlClient.rua, _mdlClient.nr_rua, _mdlClient.renda, _mdlClient.dt_nasc);
            MessageBox.Show("Salvo com sucesso!! ");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ctlClient _ctlClient = new ctlClient();
            DataTable dtbClient = new DataTable();
            dtbClient = _ctlClient.Lista();

            dgvDados.DataSource = dtbClient;
            dgvDados.Columns[0].Visible = false;
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCpf.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = dgvDados.CurrentRow.Cells[2].Value.ToString();
            txtRua.Text = dgvDados.CurrentRow.Cells[3].Value.ToString();
            txtNumero.Text = dgvDados.CurrentRow.Cells[4].Value.ToString();
            txtDataNasc.Text = dgvDados.CurrentRow.Cells[5].Value.ToString();
            txtRenda.Text = dgvDados.CurrentRow.Cells[6].Value.ToString();

            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscar.Enabled = false;
            btnListar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mdlClient _mdlCliente = new mdlClient();
            _mdlCliente.cpf = txtCpf.Text;

            ctlClient _ctlClient = new ctlClient();
            DataTable dtbCliente = new DataTable();
            dtbCliente = _ctlClient.Busca(_mdlCliente.cpf);


            dgvDados.DataSource = dtbCliente;
            dgvDados.Columns[0].Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            mdlClient _mdlClient = new mdlClient();
            _mdlClient.cpf = txtCpf.Text;

            ctlClient _ctlClient = new ctlClient();
            _ctlClient.Exclui(_mdlClient.cpf);

            MessageBox.Show("Excluído com sucesso");

            DataTable dtbClient = new DataTable();
            dtbClient = _ctlClient.Lista();

            dgvDados.DataSource = dtbClient;
            dgvDados.Columns[0].Visible = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCpf.Text = "";
            txtDataNasc.Text = "";
            txtNome.Text = "";
            txtNumero.Text = "";
            txtRenda.Text = "";
            txtRua.Text = "";
            dgvDados.DataSource = null;
            dgvDados.Refresh();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtCpf.Enabled = false;
            btnAtualizar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            mdlClient _mdlClient = new mdlClient();
            _mdlClient.cpf = txtCpf.Text;
            _mdlClient.nome = txtNome.Text;
            _mdlClient.rua = txtRua.Text;
            _mdlClient.nr_rua = Convert.ToInt32(txtNumero.Text);
            _mdlClient.renda = Convert.ToInt32(txtRenda.Text);
            _mdlClient.dt_nasc = txtDataNasc.Text;


            ctlClient _ctlClient = new ctlClient();
            _ctlClient.Atualiza(_mdlClient.cpf, _mdlClient.nome, _mdlClient.rua, _mdlClient.nr_rua, _mdlClient.renda, _mdlClient.dt_nasc);
            MessageBox.Show("Modificado com sucesso");

            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            btnExcluir.Enabled = true;
            btnBuscar.Enabled = true;
            btnListar.Enabled = true;

            btnAtualizar.Enabled = false;
        }
    }
}
