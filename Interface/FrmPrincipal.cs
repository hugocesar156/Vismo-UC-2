using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Controle;
using Vismo._venda;

namespace Vismo
{
    public partial class FrmPrincipal : Form
    {
        Usuario usuario;

        static FrmPrincipal obj;
       
        public FrmPrincipal(int codigo)
        {
            InitializeComponent();

            usuario = new Usuario();
            usuario.Codigo = codigo;
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
   
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(btnClaro, "Alternar entre o modo noturno e claro.");
            toolTip1.SetToolTip(btnEscuro, "Alternar entre o modo noturno e claro.");

            obj = this;

            UCGif uc = new UCGif();
            uc.Dock = DockStyle.Fill;
            panelFill.Controls.Add(uc);

            Tema tema = new Tema();

            tema.usuario.Codigo = usuario.Codigo;

            try
            {
                tema.GetCor();

                panelLeft.BackColor = Color.FromArgb(Convert.ToInt32(tema.R), Convert.ToInt32(tema.G), Convert.ToInt32(tema.B));

                tema.GetModo();

                if (tema.Modo == 1)
                {
                    lblAjuda.ForeColor = Color.Black;
                    lblConf.ForeColor = Color.Black;
                    lblSair.ForeColor = Color.Black;
                    lblSobre.ForeColor = Color.Black;
                    panelFill.BackColor = Color.WhiteSmoke;
                    panelTop.BackColor = Color.White;

                    btnEscuro.Visible = true;
                    btnClaro.Visible = false;

                    logo1.Visible = true;
                }
                else
                {
                    btnFechar.ForeColor = Color.Gray;
                    btnMin.ForeColor = Color.Gray;
                    lblAjuda.ForeColor = Color.Gray;
                    lblConf.ForeColor = Color.Gray;
                    lblSair.ForeColor = Color.Gray;
                    lblSobre.ForeColor = Color.Gray;

                    panelFill.BackColor = Color.FromArgb(68, 68, 68);
                    panelLeft.BackColor = Color.Black;
                    panelTop.BackColor = Color.Black;

                    btnClaro.Visible = true;
                    btnEscuro.Visible = false;

                    logo1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar carregar tema de usuário.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        public static FrmPrincipal Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new FrmPrincipal(0);
                }

                return obj;
            }
        }

        public int Codigo
        {
            get
            {
                return usuario.Codigo;
            }
        }

        public Panel PanelFill
        {
            get
            {
                return panelFill; 
            }
            set
            {
                panelFill = value;
            }
        }

        public Panel PanelLeft
        {
            get
            {
                return panelLeft;
            }
            set
            {
                panelLeft = value;
            }
        }

        public Panel PanelTop
        {
            get
            {
                return panelTop;
            }
            set
            {
                panelTop = value;
            }
        }

        public Button Home
        {
            get
            {
                return btnHome;
            }
            set
            {
                btnHome = value;
            }
        }

        public Button Claro
        {
            get
            {
                return btnClaro;
            }
            set
            {
                btnClaro = value;
            }
        }

        public Button Escuro
        {
            get
            {
                return btnEscuro;
            }
            set
            {
                btnEscuro = value;
            }
        }


        //painel do topo do Form principal

        //variáveis usadas nas ações do panel do topo 
        bool mouseClicked;
        Point clickedAt;

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseClicked = true;
                clickedAt = e.Location;
            }
        }

        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked == true)
            {
                Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }


        //painel esquerdo do Form principal

        //ação do botão de cadastro
        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            panelFill.Controls.Clear();

            UCCadastro uc = new UCCadastro();
            uc.Dock = DockStyle.Fill;
            panelFill.Controls.Add(uc);

            panelFill.Controls["UCCadastro"].BringToFront();

            btnCadastro.BackColor = Color.Gray;

            btnRegistro.BackColor = Color.Transparent;
            btnVenda.BackColor = Color.Transparent;
            btnEstoque.BackColor = Color.Transparent;

            btnClaro.Visible = false;
            btnEscuro.Visible = false;

            Point point = new Point(384, 3);
            btnHome.Location = point;
        }

        //ação do botão de registro
        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            panelFill.Controls.Clear();

            UCRegistro uc = new UCRegistro();
            uc.Dock = DockStyle.Fill;
            panelFill.Controls.Add(uc);

            panelFill.Controls["UCRegistro"].BringToFront();

            btnRegistro.BackColor = Color.Gray;

            btnCadastro.BackColor = Color.Transparent;
            btnVenda.BackColor = Color.Transparent;
            btnEstoque.BackColor = Color.Transparent;

            btnClaro.Visible = false;
            btnEscuro.Visible = false;

            Point point = new Point(384, 3);
            btnHome.Location = point;
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            panelFill.Controls.Clear();

            UCNovaVenda uc = new UCNovaVenda();
            uc.Dock = DockStyle.Fill;
            panelFill.Controls.Add(uc);

            panelFill.Controls["UCNovaVenda"].BringToFront();

            btnVenda.BackColor = Color.Gray;

            btnCadastro.BackColor = Color.Transparent;
            btnRegistro.BackColor = Color.Transparent;
            btnEstoque.BackColor = Color.Transparent;

            btnClaro.Visible = false;
            btnEscuro.Visible = false;

            Point point = new Point(384, 3);
            btnHome.Location = point;
        }


        //cabeçalho do Form principal

        //botão "Home"
        private void BtnHome_Click(object sender, EventArgs e)
        {
            panelFill.Controls.Clear();

            UCPrincipal uc = new UCPrincipal();
            uc.Dock = DockStyle.Fill;
            panelFill.Controls.Add(uc);

            panelFill.Controls["UCPrincipal"].BringToFront();

            btnCadastro.BackColor = Color.Transparent;
            btnRegistro.BackColor = Color.Transparent;
            btnVenda.BackColor = Color.Transparent;
            btnEstoque.BackColor = Color.Transparent;

            if (panelTop.BackColor == Color.Black)
            {
                btnClaro.Visible = true;
            }
            else
            {
                btnEscuro.Visible = true;
            }

            Point point = new Point(8, 19);
            btnHome.Location = point;
        }

       
        //label "Sair"
        private void LblSair_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FrmLogin"].Show();

            Close();
        }

        //label "Ajuda"
        private void LblAjuda_Click(object sender, EventArgs e)
        {
            //link do site aqui
            //System.Diagnostics.Process.Start("");
        }

        //botão "Minimizar"
        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //botão "Fechar"
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEscuro_Click(object sender, EventArgs e)
        {
            Tema tema = new Tema();

            tema.usuario.Codigo = usuario.Codigo;
            tema.Modo = 0;

            btnFechar.ForeColor = Color.Gray;
            btnMin.ForeColor = Color.Gray;
            lblAjuda.ForeColor = Color.Gray;
            lblConf.ForeColor = Color.Gray;
            lblSair.ForeColor = Color.Gray;
            lblSobre.ForeColor = Color.Gray;

            panelFill.BackColor = Color.FromArgb(68, 68, 68);
            panelLeft.BackColor = Color.Black;
            panelTop.BackColor = Color.Black;

            btnClaro.Visible = true;
            btnEscuro.Visible = false;

            logo1.Visible = false;

            tema.MudaTema();

            panelFill.Controls.Clear();

            UCPrincipal uc = new UCPrincipal();
            uc.Dock = DockStyle.Fill;
            panelFill.Controls.Add(uc);

            panelFill.Controls["UCPrincipal"].BringToFront();
        }

        private void BtnClaro_Click(object sender, EventArgs e)
        {
            Tema tema = new Tema();

            tema.usuario.Codigo = usuario.Codigo;
            tema.Modo = 1;

            lblAjuda.ForeColor = Color.Black;
            lblConf.ForeColor = Color.Black;
            lblSair.ForeColor = Color.Black;
            lblSobre.ForeColor = Color.Black;
            panelFill.BackColor = Color.WhiteSmoke;
            panelTop.BackColor = Color.White;
    
            try
            {
                tema.GetCor();

                panelLeft.BackColor = Color.FromArgb(Convert.ToInt32(tema.R), Convert.ToInt32(tema.G), Convert.ToInt32(tema.B));

                tema.MudaTema();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar carregar tema de usuário.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }

            btnEscuro.Visible = true;
            btnClaro.Visible = false;

            logo1.Visible = true;

            panelFill.Controls.Clear();

            UCPrincipal uc = new UCPrincipal();
            uc.Dock = DockStyle.Fill;
            panelFill.Controls.Add(uc);

            panelFill.Controls["UCPrincipal"].BringToFront();
        }
    }
}
