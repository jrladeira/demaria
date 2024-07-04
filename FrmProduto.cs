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
    public partial class FrmProduto : Form
    {
        private string operacao = string.Empty;

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            operacao = "A";

            HabilitarControles();

            txtDescricao.Focus();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do produto?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ProdutoDAL.Excluir(int.Parse(txtId.Text));

                LimparCampos();
            }
        }

        private void cmdInserir_Click(object sender, EventArgs e)
        {
            operacao = "I";

            LimparCampos();
            HabilitarControles();

            txtDescricao.Focus();
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
            var produto = new Produto
            {
                ProdutoId = operacao == "I" ? 0 : int.Parse(txtId.Text),
                Descricao = txtDescricao.Text.Trim(),
                Preco = decimal.Parse(txtPreco.Text.Trim()),
                Estoque = int.Parse(txtEstoque.Text.Trim())
            };

            ProdutoDAL.Salvar(produto);

            txtId.Text = produto.ProdutoId.ToString();
            txtDescricao.Text = produto.Descricao;
            txtPreco.Text = produto.Preco.ToString();
            txtEstoque.Text = produto.Estoque.ToString();

            MessageBox.Show("Produto gravado com sucesso!");

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
                var produto = ProdutoDAL.Consultar(int.Parse(txtId.Text));

                txtId.Text = produto.ProdutoId.ToString();
                txtDescricao.Text = produto.Descricao;
                txtPreco.Text = produto.Preco.ToString();
                txtEstoque.Text = produto.Estoque.ToString();
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
            if (!int.TryParse(txtPesquisaId.Text, out int produtoId))
            {
                MessageBox.Show("Código inválido!");
                return;
            }

            var produto = ProdutoDAL.Consultar(produtoId);

            if (produto.ProdutoId == 0)
            {
                MessageBox.Show("Código não encontrado!");
                return;
            }

            txtId.Text = produto.ProdutoId.ToString();
            txtDescricao.Text = produto.Descricao;
            txtPreco.Text = produto.Preco.ToString();
            txtEstoque.Text = produto.Estoque.ToString();

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

                pnlProduto.Enabled = !pnlProduto.Enabled;
            }
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtEstoque.Text = string.Empty;
        }
    }
}
