using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vismo._cadastros;

namespace Vismo
{
    public partial class UCCadastro : UserControl
    {
        public UCCadastro()
        {
            InitializeComponent();
        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            UCCadFornecedor uc = new UCCadFornecedor();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadFornecedor"].BringToFront();
        }

        private void BtnProdutoE_Click(object sender, EventArgs e)
        {
            UCCadProdutoE uc = new UCCadProdutoE();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadProdutoE"].BringToFront();
        }

        private void BtnProdutoL_Click(object sender, EventArgs e)
        {
            UCCadProdutoL uc = new UCCadProdutoL();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadProdutoL"].BringToFront();
        }

        private void BtnProdutoF_Click(object sender, EventArgs e)
        {
            UCCadProdutoF uc = new UCCadProdutoF();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadProdutoF"].BringToFront();
        }

        private void BtnPagamento_Click(object sender, EventArgs e)
        {
            UCCadPagamento uc = new UCCadPagamento();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadPagamento"].BringToFront();
        }
    }
}
