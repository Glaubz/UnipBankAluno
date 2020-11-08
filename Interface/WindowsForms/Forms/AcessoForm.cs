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
            mdlAcesso _mdlAcesso = new mdlAcesso
            {
                Usuario = txtUsuario.Text,
                Senha = txtSenha.Text
            };

            ctlAcesso _ctlAcesso = new ctlAcesso();
            Dictionary<int, string> usuarioAcesso = _ctlAcesso.UsuarioAcesso(_mdlAcesso.Usuario);

            string mensagem;
            if (usuarioAcesso.TryGetValue(0, out mensagem))
            {
                MessageBox.Show(mensagem);
            }
            else
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                
                DataTable usuario = _ctlAcesso.InfoUsuario(_mdlAcesso.Usuario);
                ctlConta _ctlConta = new ctlConta();
                mdlClient cliente = new mdlClient
                {
                    Acesso = _mdlAcesso,
                    Conta = _ctlConta.ObterConta(_mdlAcesso.Usuario), //ObtemConta
                    cpf = usuario.Rows[0]["cpf"].ToString(),
                    nome = usuario.Rows[0]["nome"].ToString(),
                    nr_rua = Convert.ToInt32(usuario.Rows[0]["nr_rua"]),
                    renda = double.Parse(usuario.Rows[0]["renda"].ToString()),
                    dt_nasc = usuario.Rows[0]["dt_nasc"].ToString(),
                };
            }

        }


    }
}
