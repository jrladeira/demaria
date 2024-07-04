using DeMaria.DAL;
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
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            var pedido = PedidoDAL.Consultar(1);

            txtId.Text = pedido.PedidoId.ToString();
            txtData.Text = pedido.PedidoData.ToString();
            txtClienteId.Text = pedido.ClienteId.ToString();
            txtClienteNome.Text = pedido.Nome;
            txtQuantidadeTotal.Text = pedido.QuantidadeTotal.ToString();
            txtValorTotal.Text = pedido.ValorTotal.ToString();
        }
    }
}
