
namespace DeMaria
{
    partial class FrmCliente
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
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.cmdPesquisar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdAlterar = new System.Windows.Forms.Button();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.cmdInserir = new System.Windows.Forms.Button();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.cmdPesquisaCancelar = new System.Windows.Forms.Button();
            this.cmdPesquisaOk = new System.Windows.Forms.Button();
            this.txtPesquisaId = new System.Windows.Forms.TextBox();
            this.lblPesquisaId = new System.Windows.Forms.Label();
            this.pnlCliente.SuspendLayout();
            this.pnlPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCliente
            // 
            this.pnlCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCliente.Controls.Add(this.txtEmail);
            this.pnlCliente.Controls.Add(this.txtTelefone);
            this.pnlCliente.Controls.Add(this.txtEndereco);
            this.pnlCliente.Controls.Add(this.txtNome);
            this.pnlCliente.Controls.Add(this.txtId);
            this.pnlCliente.Controls.Add(this.lblEmail);
            this.pnlCliente.Controls.Add(this.lblTelefone);
            this.pnlCliente.Controls.Add(this.lblEndereco);
            this.pnlCliente.Controls.Add(this.lblNome);
            this.pnlCliente.Controls.Add(this.lblId);
            this.pnlCliente.Enabled = false;
            this.pnlCliente.Location = new System.Drawing.Point(12, 42);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(480, 192);
            this.pnlCliente.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 144);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(90, 114);
            this.txtTelefone.MaxLength = 20;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(192, 20);
            this.txtTelefone.TabIndex = 18;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(90, 84);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(360, 20);
            this.txtEndereco.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 54);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(360, 20);
            this.txtNome.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(90, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(102, 20);
            this.txtId.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(24, 150);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "e-mail:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.Location = new System.Drawing.Point(24, 120);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(54, 13);
            this.lblTelefone.TabIndex = 13;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.Location = new System.Drawing.Point(24, 90);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(54, 13);
            this.lblEndereco.TabIndex = 12;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(24, 60);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome:";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(24, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(54, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "Código:";
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Location = new System.Drawing.Point(252, 12);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(75, 23);
            this.cmdPesquisar.TabIndex = 30;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.UseVisualStyleBackColor = true;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(420, 12);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 29;
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
            this.cmdExcluir.TabIndex = 28;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdAlterar
            // 
            this.cmdAlterar.Location = new System.Drawing.Point(90, 12);
            this.cmdAlterar.Name = "cmdAlterar";
            this.cmdAlterar.Size = new System.Drawing.Size(75, 23);
            this.cmdAlterar.TabIndex = 27;
            this.cmdAlterar.Text = "Alterar";
            this.cmdAlterar.UseVisualStyleBackColor = true;
            this.cmdAlterar.Click += new System.EventHandler(this.cmdAlterar_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Location = new System.Drawing.Point(342, 12);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(75, 23);
            this.cmdSalvar.TabIndex = 26;
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
            this.cmdInserir.TabIndex = 25;
            this.cmdInserir.Text = "Cadastrar";
            this.cmdInserir.UseVisualStyleBackColor = true;
            this.cmdInserir.Click += new System.EventHandler(this.cmdInserir_Click);
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
            this.pnlPesquisa.TabIndex = 31;
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
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 247);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmdAlterar);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.cmdInserir);
            this.Controls.Add(this.pnlCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmCliente";
            this.Text = "Clientes";
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdAlterar;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.Button cmdInserir;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.Button cmdPesquisaCancelar;
        private System.Windows.Forms.Button cmdPesquisaOk;
        private System.Windows.Forms.TextBox txtPesquisaId;
        private System.Windows.Forms.Label lblPesquisaId;
    }
}