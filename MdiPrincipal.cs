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
    public partial class MdiPrincipal : Form
    {
        public MdiPrincipal()
        {
            InitializeComponent();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuCliente_Click(object sender, EventArgs e)
        {
            var childForm = this.MdiChildren.Where(x => x.Name == "FrmCliente").FirstOrDefault();

            if (childForm == null)
            {
                childForm = new FrmCliente();
                childForm.MdiParent = this;
                childForm.Show();
            }

            childForm.Activate();
        }

        private void mnuProduto_Click(object sender, EventArgs e)
        {
            var childForm = this.MdiChildren.Where(x => x.Name == "FrmProduto").FirstOrDefault();

            if (childForm == null)
            {
                childForm = new FrmProduto();
                childForm.MdiParent = this;
                childForm.Show();
            }

            childForm.Activate();
        }

        private void mnuPedido_Click(object sender, EventArgs e)
        {
            var childForm = this.MdiChildren.Where(x => x.Name == "FrmPedido").FirstOrDefault();

            if (childForm == null)
            {
                childForm = new FrmPedido();
                childForm.MdiParent = this;
                childForm.Show();
            }

            childForm.Activate();
        }
    }
}
