using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vismo._modos
{
    public partial class UCAusente1 : UserControl
    {
        public UCAusente1()
        {
            InitializeComponent();

            FrmPrincipal.Instance.Claro.Visible = false;
            FrmPrincipal.Instance.Escuro.Visible = false;

            Point point = new Point(384, 3);
            FrmPrincipal.Instance.Home.Location = point;
        }

        private void BtnSeguir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

            }
            else
            {
                if (radioButton2.Checked == true)
                {

                }
                else
                {
                    if (radioButton3.Checked == true)
                    {

                    }
                    else
                    {
                        if (radioButton4.Checked == true)
                        {

                        }
                    }
                }
            }

            if (rd1.Checked == true)
            {


            }
            else
            {
                if (rd2.Checked == true)
                {

                }
                else
                {
                    if (rd3.Checked == true)
                    {

                    }
                    else
                    {
                        if (rd4.Checked == true)
                        {

                        }
                    }
                }

            }

            FrmPrincipal.Instance.PanelFill.Controls.Clear();

            UCAusente2 uc = new UCAusente2();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCAusente2"].BringToFront();
        }
    }
}
