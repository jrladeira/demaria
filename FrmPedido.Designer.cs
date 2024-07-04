
namespace DeMaria
{
    partial class FrmPedido
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
            this.pnlPedido = new System.Windows.Forms.Panel();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtQuantidadeTotal = new System.Windows.Forms.TextBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblQuantidadeTotal = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlPedido.SuspendLayout();
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
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Location = new System.Drawing.Point(168, 12);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(75, 23);
            this.cmdExcluir.TabIndex = 34;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = true;
            // 
            // cmdAlterar
            // 
            this.cmdAlterar.Location = new System.Drawing.Point(90, 12);
            this.cmdAlterar.Name = "cmdAlterar";
            this.cmdAlterar.Size = new System.Drawing.Size(75, 23);
            this.cmdAlterar.TabIndex = 33;
            this.cmdAlterar.Text = "Alterar";
            this.cmdAlterar.UseVisualStyleBackColor = true;
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
            // 
            // cmdInserir
            // 
            this.cmdInserir.Location = new System.Drawing.Point(12, 12);
            this.cmdInserir.Name = "cmdInserir";
            this.cmdInserir.Size = new System.Drawing.Size(75, 23);
            this.cmdInserir.TabIndex = 31;
            this.cmdInserir.Text = "Cadastrar";
            this.cmdInserir.UseVisualStyleBackColor = true;
            // 
            // pnlPedido
            // 
            this.pnlPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPedido.Controls.Add(this.txtClienteNome);
            this.pnlPedido.Controls.Add(this.txtValorTotal);
            this.pnlPedido.Controls.Add(this.txtQuantidadeTotal);
            this.pnlPedido.Controls.Add(this.txtClienteId);
            this.pnlPedido.Controls.Add(this.txtData);
            this.pnlPedido.Controls.Add(this.txtId);
            this.pnlPedido.Controls.Add(this.lblValorTotal);
            this.pnlPedido.Controls.Add(this.lblQuantidadeTotal);
            this.pnlPedido.Controls.Add(this.lblCliente);
            this.pnlPedido.Controls.Add(this.lblData);
            this.pnlPedido.Controls.Add(this.lblId);
            this.pnlPedido.Enabled = false;
            this.pnlPedido.Location = new System.Drawing.Point(12, 42);
            this.pnlPedido.Name = "pnlPedido";
            this.pnlPedido.Size = new System.Drawing.Size(564, 192);
            this.pnlPedido.TabIndex = 37;
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.Enabled = false;
            this.txtClienteNome.Location = new System.Drawing.Point(210, 54);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(324, 20);
            this.txtClienteNome.TabIndex = 20;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(366, 84);
            this.txtValorTotal.MaxLength = 60;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(168, 20);
            this.txtValorTotal.TabIndex = 19;
            // 
            // txtQuantidadeTotal
            // 
            this.txtQuantidadeTotal.Enabled = false;
            this.txtQuantidadeTotal.Location = new System.Drawing.Point(96, 84);
            this.txtQuantidadeTotal.MaxLength = 20;
            this.txtQuantidadeTotal.Name = "txtQuantidadeTotal";
            this.txtQuantidadeTotal.Size = new System.Drawing.Size(192, 20);
            this.txtQuantidadeTotal.TabIndex = 18;
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(96, 54);
            this.txtClienteId.MaxLength = 100;
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(102, 20);
            this.txtClienteId.TabIndex = 17;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(252, 24);
            this.txtData.MaxLength = 60;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(102, 20);
            this.txtData.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(96, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(102, 20);
            this.txtId.TabIndex = 15;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Location = new System.Drawing.Point(294, 90);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(66, 13);
            this.lblValorTotal.TabIndex = 14;
            this.lblValorTotal.Text = "Valor Total:";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblQuantidadeTotal
            // 
            this.lblQuantidadeTotal.Location = new System.Drawing.Point(24, 90);
            this.lblQuantidadeTotal.Name = "lblQuantidadeTotal";
            this.lblQuantidadeTotal.Size = new System.Drawing.Size(66, 13);
            this.lblQuantidadeTotal.TabIndex = 13;
            this.lblQuantidadeTotal.Text = "Qtde. Total:";
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(24, 60);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(54, 13);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblData
            // 
            this.lblData.Location = new System.Drawing.Point(204, 30);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 13);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Data:";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(24, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(54, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "Código:";
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 247);
            this.Controls.Add(this.pnlPedido);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmdAlterar);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.cmdInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPedido";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.pnlPedido.ResumeLayout(false);
            this.pnlPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdAlterar;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.Button cmdInserir;
        private System.Windows.Forms.Panel pnlPedido;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtQuantidadeTotal;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblQuantidadeTotal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtClienteNome;
    }
}