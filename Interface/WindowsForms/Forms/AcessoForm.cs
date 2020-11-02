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
    public partial class AcessoForm : Form
    {
        public AcessoForm()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            mdlAcesso _mdlAcesso = new ClientModel.mdlAcesso();
            _mdlAcesso.Nome = txtUsuario.Text;
            _mdlAcesso.Senha = txtSenha.Text;

            ctlAcesso _ctlAcesso = new ctlAcesso();
            DataTable usuarioAcesso = _ctlAcesso.UsuarioAcesso(_mdlAcesso.Nome);

            if (_mdlAcesso.Senha != usuarioAcesso.ToString())
            {
                MessageBox.Show("Senha incorreta, tente novamente");
            }
            else
            {
                ClienteForm clienteForm = new ClienteForm();
                clienteForm.MdiParent = this;
                clienteForm.Show();
            }

        }


    }
}
