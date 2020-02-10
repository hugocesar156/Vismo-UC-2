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
using Vismo._modos;

namespace Vismo
{
    public partial class UCPrincipal : UserControl
    {
        bool x = false;

        public UCPrincipal()
        {
            InitializeComponent();

            BackColor = FrmPrincipal.Instance.PanelFill.BackColor;

            lblNoti.Visible = false;
            lblPerfil.Visible = false;

            if(BackColor == Color.DimGray)
            {
                lblAlternar.ForeColor = Color.Coral;
            }

            try
            {
                Modo modo = new Modo();

                modo.usuario.Codigo = FrmPrincipal.Instance.Codigo;

                modo.BuscaModo();

                if (modo.Tipo == 1)
                {
                    cuboVerde.Visible = true;
                    cuboAmarelo.Visible = false;
                    cuboAzul.Visible = false;

                    lblDisponivel.Visible = true;
                    lblAusente.Visible = false;
                    lblAutonomo.Visible = false;
                }
                else if (modo.Tipo == 2)
                {
                    cuboVerde.Visible = false;
                    cuboAmarelo.Visible = true;
                    cuboAzul.Visible = false;

                    lblDisponivel.Visible = false;
                    lblAusente.Visible = true;
                    lblAutonomo.Visible = false;
                }
                else
                {
                    cuboVerde.Visible = false;
                    cuboAmarelo.Visible = false;
                    cuboAzul.Visible = true;

                    lblDisponivel.Visible = false;
                    lblAusente.Visible = false;
                    lblAutonomo.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar atualizar modo de usuário.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UCPerfil uc = new UCPerfil();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCPerfil"].BringToFront();
        }

        private void UCPrincipal_Load(object sender, EventArgs e)
        {
            timer3.Start();
            timer4.Start();

            int hora;
            hora = DateTime.Now.Hour;
     
            lblRelogioHora.Text = Convert.ToString(DateTime.Now.Hour);
            lblRelogioMinuto.Text = Convert.ToString(DateTime.Now.Minute);

            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(lblAlternar, "Clique uma vez para manter os modos fixos, clique duas para manter alternado.");
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
        }
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblRelogioHora.Text = Convert.ToString(DateTime.Now.Hour);

            int minuto;
            minuto = DateTime.Now.Minute;

            if (minuto <10)
            {
                lblRelogioMinuto.Text = Convert.ToString("0"+DateTime.Now.Minute);
            }
            else
            {
                lblRelogioMinuto.Text = Convert.ToString(DateTime.Now.Minute);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Interval == 3000)
            {
            
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timer3.Interval == 1000)
            {
                label2.Visible = false;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (timer4.Interval == 2000)
            {
                label2.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Instance.Claro.Visible = false;
            FrmPrincipal.Instance.Escuro.Visible = false;

            UCPerfil uc = new UCPerfil();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCPerfil"].BringToFront();

            Point point = new Point(384, 3);
            FrmPrincipal.Instance.Home.Location = point;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lblPerfil.Visible = false;
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblPerfil.Visible = true;
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
        }

        private void piclogo2_Click(object sender, EventArgs e)
        {
            UCPerfil uc = new UCPerfil();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCPerfil"].BringToFront();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            lblNoti.Visible = false;

            pictureBox2.Visible = true;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            lblNoti.Visible = true;
            pictureBox2.Visible = false;
        }

        private void lblAlternar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAutonomo.Visible = true;
            btnAusente.Visible = true;
            btnDisponivel.Visible = true;
        }

        private void lblAlternar_MouseLeave(object sender, EventArgs e)
        {
            if (x == true)
            {
                btnAutonomo.Visible = true;
                btnAusente.Visible = true;
                btnDisponivel.Visible = true;
            }
            else
            {
                btnAutonomo.Visible = false;
                btnAusente.Visible = false;
                btnDisponivel.Visible = false;
            }
        }

        private void lblAlternar_Click(object sender, EventArgs e)
        {
            x = true;
    
            btnAutonomo.Visible = true;
            btnAusente.Visible = true;
            btnDisponivel.Visible = true;

        }

        private void lblAlternar_DoubleClick(object sender, EventArgs e)
        {
            x = false;

            btnAutonomo.Visible = false;
            btnAusente.Visible = false;
            btnDisponivel.Visible = false;
        }

        private void BtnAutonomo_MouseEnter(object sender, EventArgs e)
        {
            if (FrmPrincipal.Instance.Claro.Visible == true)
            {
                btnAutonomo.ForeColor = Color.Black;
                btnAutonomo.Text = "Iniciar";
            }
            else
            {
                btnAutonomo.BackColor = Color.Coral;
                btnAutonomo.ForeColor = Color.White;
                btnAutonomo.Text = "Iniciar";
            }
        }

        private void BtnAutonomo_MouseLeave(object sender, EventArgs e)
        {
            if (FrmPrincipal.Instance.Claro.Visible == true)
            {
                btnAutonomo.ForeColor = Color.DarkOrange;
                btnAutonomo.Text = "Autônomo";
            }
            else
            {
                btnAutonomo.BackColor = Color.Transparent;
                btnAutonomo.ForeColor = Color.DarkOrange;
                btnAutonomo.Text = "Autônomo";
            }     
        }

        private void BtnAusente_MouseEnter(object sender, EventArgs e)
        {
            if (FrmPrincipal.Instance.Claro.Visible == true)
            {
                btnAusente.ForeColor = Color.Black;
                btnAusente.Text = "Iniciar";
            }
            else
            {
                btnAusente.BackColor = Color.Coral;
                btnAusente.ForeColor = Color.White;
                btnAusente.Text = "Iniciar";
            }
        }

        private void BtnAusente_MouseLeave(object sender, EventArgs e)
        {
            if (FrmPrincipal.Instance.Claro.Visible == true)
            {
                btnAusente.ForeColor = Color.DarkOrange;
                btnAusente.Text = "Ausente";
            }
            else
            {
                btnAusente.BackColor = Color.Transparent;
                btnAusente.ForeColor = Color.DarkOrange;
                btnAusente.Text = "Ausente";
            }
        }

        private void BtnDisponivel_MouseEnter(object sender, EventArgs e)
        {
            if (FrmPrincipal.Instance.Claro.Visible == true)
            {
                btnDisponivel.ForeColor = Color.Black;
                btnDisponivel.Text = "Iniciar";
            }
            else
            {
                btnDisponivel.BackColor = Color.Coral;
                btnDisponivel.ForeColor = Color.White;
                btnDisponivel.Text = "Iniciar";
            }
        }

        private void BtnDisponivel_MouseLeave(object sender, EventArgs e)
        {
            if (FrmPrincipal.Instance.Claro.Visible == true)
            {
                btnDisponivel.ForeColor = Color.DarkOrange;
                btnDisponivel.Text = "Disponível";
            }
            else
            {
                btnDisponivel.BackColor = Color.Transparent;
                btnDisponivel.ForeColor = Color.DarkOrange;
                btnDisponivel.Text = "Disponível";
            }
        }

        private void BtnDisponivel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Entrar no Modo Disponível?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Modo modo = new Modo();

                modo.usuario.Codigo = FrmPrincipal.Instance.Codigo;

                modo.Tipo = 1;

                try
                {
                    modo.AlteraModo();

                    cuboVerde.Visible = true;
                    cuboAmarelo.Visible = false;
                    cuboAzul.Visible = false;

                    lblDisponivel.Visible = true;
                    lblAusente.Visible = false;
                    lblAutonomo.Visible = false;

                    MessageBox.Show("Você entrou no Modo Disponivel.", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar atualizar modo de usuário.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MessageBox.Show(ex.Message);
                }
            }  
        }

        private void BtnAusente_Click(object sender, EventArgs e)
        {
            UCAusente1 uc = new UCAusente1();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCAusente1"].BringToFront();
        }

        private void BtnAutonomo_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Instance.Visible = false;

            log tela = new log();
            tela.Show();
        }
    }
}
