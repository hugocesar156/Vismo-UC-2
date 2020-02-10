using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vismo
{
    public partial class UCGif : UserControl
    {
        public UCGif()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            FrmPrincipal.Instance.PanelFill.Controls.Clear();

            UCPrincipal uc = new UCPrincipal();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelLeft.Visible = true;
            FrmPrincipal.Instance.PanelTop.Visible = true;

            FrmPrincipal.Instance.PanelFill.Controls["UCPrincipal"].BringToFront();
        }
    }
}
