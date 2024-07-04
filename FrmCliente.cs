using DeMaria.DAL;
using DeMaria.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeMaria
{
    public partial class FrmCliente : Form
    {
        private string operacao = string.Empty;

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            operacao = "A";

            HabilitarControles();

            txtNome.Focus();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do cliente?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClienteDAL.Excluir(int.Parse(txtId.Text));

                LimparCampos();
            }
        }

        private void cmdInserir_Click(object sender, EventArgs e)
        {
            operacao = "I";

            LimparCampos();
            HabilitarControles();

            txtNome.Focus();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            operacao = "P";

            HabilitarControles();

            pnlPesquisa.Visible = true;

            txtPesquisaId.Text = string.Empty;
            txtPesquisaId.Focus();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                ClienteId = operacao == "I" ? 0 : int.Parse(txtId.Text),
                Nome = txtNome.Text.Trim(),
                Endereco = txtEndereco.Text.Trim(),
                Telefone = txtTelefone.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            ClienteDAL.Salvar(cliente);

            txtId.Text = cliente.ClienteId.ToString();
            txtNome.Text = cliente.Nome;
            txtEndereco.Text = cliente.Endereco;
            txtTelefone.Text = cliente.Telefone;
            txtEmail.Text = cliente.Email;

            MessageBox.Show("Cliente gravado com sucesso!");

            HabilitarControles();

            cmdInserir.Focus();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (operacao == "I")
            {
                LimparCampos();
            }
            else
            {
                var cliente = ClienteDAL.Consultar(int.Parse(txtId.Text));

                txtId.Text = cliente.ClienteId.ToString();
                txtNome.Text = cliente.Nome;
                txtEndereco.Text = cliente.Endereco;
                txtTelefone.Text = cliente.Telefone;
                txtEmail.Text = cliente.Email;
            }

            HabilitarControles();

            cmdInserir.Focus();
        }

        private void cmdPesquisaCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles();

            pnlPesquisa.Visible = false;
        }

        private void cmdPesquisaOk_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPesquisaId.Text, out int clienteId))
            {
                MessageBox.Show("Código inválido!");
                return;
            }

            var cliente = ClienteDAL.Consultar(clienteId);

            if (cliente.ClienteId == 0)
            {
                MessageBox.Show("Código não encontrado!");
                return;
            }

            txtId.Text = cliente.ClienteId.ToString();
            txtNome.Text = cliente.Nome;
            txtEndereco.Text = cliente.Endereco;
            txtTelefone.Text = cliente.Telefone;
            txtEmail.Text = cliente.Email;

            HabilitarControles();

            pnlPesquisa.Visible = false;
        }

        private void HabilitarControles()
        {
            cmdInserir.Enabled = !cmdInserir.Enabled;
            cmdAlterar.Enabled = !cmdAlterar.Enabled;
            cmdExcluir.Enabled = !cmdExcluir.Enabled;
            cmdPesquisar.Enabled = !cmdPesquisar.Enabled;

            if (operacao != "P")
            {
                cmdSalvar.Visible = !cmdSalvar.Visible;
                cmdCancelar.Visible = !cmdCancelar.Visible;

                pnlCliente.Enabled = !pnlCliente.Enabled;
            }
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
    }
}
