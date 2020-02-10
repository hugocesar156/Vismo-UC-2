using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;

namespace Vismo._modos
{
    public partial class UCAusente2 : UserControl
    {
        public UCAusente2()
        {
            InitializeComponent();
        }

        private void BtnConcluido_Click(object sender, EventArgs e)
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

            if (MessageBox.Show("Confirmar mudanças?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Modo modo = new Modo();

                modo.usuario.Codigo = FrmPrincipal.Instance.Codigo;

                modo.Tipo = 2;

                try
                {
                    modo.AlteraModo();

                    MessageBox.Show("Você entrou no Modo Ausente.", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar atualizar modo de usuário.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MessageBox.Show(ex.Message);
                }
            }

            FrmPrincipal.Instance.PanelFill.Controls.Clear();

            UCPrincipal uc = new UCPrincipal();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            if (FrmPrincipal.Instance.PanelTop.BackColor == Color.Black)
            {
                FrmPrincipal.Instance.Claro.Visible = true;
            }
            else
            {
                FrmPrincipal.Instance.Escuro.Visible = true;
            }

            Point point = new Point(8, 19);
            FrmPrincipal.Instance.Home.Location = point;

            FrmPrincipal.Instance.PanelFill.Controls["UCPrincipal"].BringToFront();
        }
    }
}
