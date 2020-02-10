using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vismo._modos;

namespace Vismo
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();

            FrmPrincipal.Instance.Claro.Visible = false;
            FrmPrincipal.Instance.Escuro.Visible = false;

            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            FrmPrincipal.Instance.Visible = true;

            FrmPrincipal.Instance.PanelFill.Controls.Clear();

            UCAutonomo uc = new UCAutonomo();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCAutonomo"].BringToFront();

            Close();
        }
    }
}
