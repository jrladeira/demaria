
namespace DeMaria
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdPesquisar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdAlterar = new System.Windows.Forms.Button();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.cmdInserir = new System.Windows.Forms.Button();
            this.pnlProduto = new System.Windows.Forms.Panel();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.cmdPesquisaCancelar = new System.Windows.Forms.Button();
            this.cmdPesquisaOk = new System.Windows.Forms.Button();
            this.txtPesquisaId = new System.Windows.Forms.TextBox();
            this.lblPesquisaId = new System.Windows.Forms.Label();
            this.pnlProduto.SuspendLayout();
            this.pnlPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Location = new System.Drawing.Point(252, 12);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(75, 23);
            this.cmdPesquisar.TabIndex = 36;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.UseVisualStyleBackColor = true;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(420, 12);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 35;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Visible = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Location = new System.Drawing.Point(168, 12);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(75, 23);
            this.cmdExcluir.TabIndex = 34;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdAlterar
            // 
            this.cmdAlterar.Location = new System.Drawing.Point(90, 12);
            this.cmdAlterar.Name = "cmdAlterar";
            this.cmdAlterar.Size = new System.Drawing.Size(75, 23);
            this.cmdAlterar.TabIndex = 33;
            this.cmdAlterar.Text = "Alterar";
            this.cmdAlterar.UseVisualStyleBackColor = true;
            this.cmdAlterar.Click += new System.EventHandler(this.cmdAlterar_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Location = new System.Drawing.Point(342, 12);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(75, 23);
            this.cmdSalvar.TabIndex = 32;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.UseVisualStyleBackColor = true;
            this.cmdSalvar.Visible = false;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // cmdInserir
            // 
            this.cmdInserir.Location = new System.Drawing.Point(12, 12);
            this.cmdInserir.Name = "cmdInserir";
            this.cmdInserir.Size = new System.Drawing.Size(75, 23);
            this.cmdInserir.TabIndex = 31;
            this.cmdInserir.Text = "Cadastrar";
            this.cmdInserir.UseVisualStyleBackColor = true;
            this.cmdInserir.Click += new System.EventHandler(this.cmdInserir_Click);
            // 
            // pnlProduto
            // 
            this.pnlProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProduto.Controls.Add(this.txtEstoque);
            this.pnlProduto.Controls.Add(this.txtPreco);
            this.pnlProduto.Controls.Add(this.txtDescricao);
            this.pnlProduto.Controls.Add(this.txtId);
            this.pnlProduto.Controls.Add(this.lblEstoque);
            this.pnlProduto.Controls.Add(this.lblPreco);
            this.pnlProduto.Controls.Add(this.lblDescricao);
            this.pnlProduto.Controls.Add(this.lblId);
            this.pnlProduto.Enabled = false;
            this.pnlProduto.Location = new System.Drawing.Point(12, 42);
            this.pnlProduto.Name = "pnlProduto";
            this.pnlProduto.Size = new System.Drawing.Size(480, 162);
            this.pnlProduto.TabIndex = 37;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(90, 114);
            this.txtEstoque.MaxLength = 0;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(84, 20);
            this.txtEstoque.TabIndex = 18;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(90, 84);
            this.txtPreco.MaxLength = 0;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(84, 20);
            this.txtPreco.TabIndex = 17;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(90, 54);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(360, 20);
            this.txtDescricao.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(90, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(102, 20);
            this.txtId.TabIndex = 15;
            // 
            // lblEstoque
            // 
            this.lblEstoque.Location = new System.Drawing.Point(24, 120);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(60, 13);
            this.lblEstoque.TabIndex = 13;
            this.lblEstoque.Text = "Estoque:";
            // 
            // lblPreco
            // 
            this.lblPreco.Location = new System.Drawing.Point(24, 90);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(60, 13);
            this.lblPreco.TabIndex = 12;
            this.lblPreco.Text = "Preço:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.Location = new System.Drawing.Point(24, 60);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(60, 13);
            this.lblDescricao.TabIndex = 11;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(24, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(60, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "Código:";
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPesquisa.Controls.Add(this.cmdPesquisaCancelar);
            this.pnlPesquisa.Controls.Add(this.cmdPesquisaOk);
            this.pnlPesquisa.Controls.Add(this.txtPesquisaId);
            this.pnlPesquisa.Controls.Add(this.lblPesquisaId);
            this.pnlPesquisa.Location = new System.Drawing.Point(252, 42);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(192, 90);
            this.pnlPesquisa.TabIndex = 38;
            this.pnlPesquisa.Visible = false;
            // 
            // cmdPesquisaCancelar
            // 
            this.cmdPesquisaCancelar.Location = new System.Drawing.Point(102, 54);
            this.cmdPesquisaCancelar.Name = "cmdPesquisaCancelar";
            this.cmdPesquisaCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdPesquisaCancelar.TabIndex = 5;
            this.cmdPesquisaCancelar.Text = "Cancelar";
            this.cmdPesquisaCancelar.UseVisualStyleBackColor = true;
            this.cmdPesquisaCancelar.Click += new System.EventHandler(this.cmdPesquisaCancelar_Click);
            // 
            // cmdPesquisaOk
            // 
            this.cmdPesquisaOk.Location = new System.Drawing.Point(18, 54);
            this.cmdPesquisaOk.Name = "cmdPesquisaOk";
            this.cmdPesquisaOk.Size = new System.Drawing.Size(75, 23);
            this.cmdPesquisaOk.TabIndex = 4;
            this.cmdPesquisaOk.Text = "OK";
            this.cmdPesquisaOk.UseVisualStyleBackColor = true;
            this.cmdPesquisaOk.Click += new System.EventHandler(this.cmdPesquisaOk_Click);
            // 
            // txtPesquisaId
            // 
            this.txtPesquisaId.Location = new System.Drawing.Point(66, 18);
            this.txtPesquisaId.Name = "txtPesquisaId";
            this.txtPesquisaId.Size = new System.Drawing.Size(108, 20);
            this.txtPesquisaId.TabIndex = 3;
            // 
            // lblPesquisaId
            // 
            this.lblPesquisaId.AutoSize = true;
            this.lblPesquisaId.Location = new System.Drawing.Point(18, 24);
            this.lblPesquisaId.Name = "lblPesquisaId";
            this.lblPesquisaId.Size = new System.Drawing.Size(43, 13);
            this.lblPesquisaId.TabIndex = 2;
            this.lblPesquisaId.Text = "Código:";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 217);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.pnlProduto);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmdAlterar);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.cmdInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmProduto";
            this.Text = "Produtos";
            this.pnlProduto.ResumeLayout(false);
            this.pnlProduto.PerformLayout();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdAlterar;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.Button cmdInserir;
        private System.Windows.Forms.Panel pnlProduto;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.Button cmdPesquisaCancelar;
        private System.Windows.Forms.Button cmdPesquisaOk;
        private System.Windows.Forms.TextBox txtPesquisaId;
        private System.Windows.Forms.Label lblPesquisaId;
    }
}