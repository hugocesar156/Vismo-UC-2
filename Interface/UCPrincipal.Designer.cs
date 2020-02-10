namespace Vismo
{
    partial class UCPrincipal
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.ImgDigitos = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRelogioMinuto = new System.Windows.Forms.Label();
            this.lblRelogioHora = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.piclogo2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblNoti = new System.Windows.Forms.Label();
            this.cuboAzul = new System.Windows.Forms.PictureBox();
            this.cuboVerde = new System.Windows.Forms.PictureBox();
            this.cuboAmarelo = new System.Windows.Forms.PictureBox();
            this.lblAutonomo = new System.Windows.Forms.Label();
            this.lblAlternar = new System.Windows.Forms.Label();
            this.lblAusente = new System.Windows.Forms.Label();
            this.lblDisponivel = new System.Windows.Forms.Label();
            this.btnAutonomo = new System.Windows.Forms.Button();
            this.btnAusente = new System.Windows.Forms.Button();
            this.btnDisponivel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuboAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuboVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuboAmarelo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(796, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = " ! ";
            this.label1.Visible = false;
            // 
            // ImgDigitos
            // 
            this.ImgDigitos.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgDigitos.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgDigitos.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblRelogioMinuto
            // 
            this.lblRelogioMinuto.AutoSize = true;
            this.lblRelogioMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogioMinuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRelogioMinuto.Location = new System.Drawing.Point(411, 37);
            this.lblRelogioMinuto.Name = "lblRelogioMinuto";
            this.lblRelogioMinuto.Size = new System.Drawing.Size(104, 73);
            this.lblRelogioMinuto.TabIndex = 16;
            this.lblRelogioMinuto.Text = "00";
            // 
            // lblRelogioHora
            // 
            this.lblRelogioHora.AutoSize = true;
            this.lblRelogioHora.BackColor = System.Drawing.Color.Transparent;
            this.lblRelogioHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogioHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRelogioHora.Location = new System.Drawing.Point(309, 37);
            this.lblRelogioHora.Name = "lblRelogioHora";
            this.lblRelogioHora.Size = new System.Drawing.Size(104, 73);
            this.lblRelogioHora.TabIndex = 15;
            this.lblRelogioHora.Text = "00";
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(399, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = ":";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 2000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(706, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(759, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // piclogo2
            // 
            this.piclogo2.Image = ((System.Drawing.Image)(resources.GetObject("piclogo2.Image")));
            this.piclogo2.Location = new System.Drawing.Point(706, 68);
            this.piclogo2.Name = "piclogo2";
            this.piclogo2.Size = new System.Drawing.Size(114, 113);
            this.piclogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo2.TabIndex = 20;
            this.piclogo2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(759, 200);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPerfil.Location = new System.Drawing.Point(591, 138);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(109, 25);
            this.lblPerfil.TabIndex = 22;
            this.lblPerfil.Text = "Meu Perfil";
            // 
            // lblNoti
            // 
            this.lblNoti.AutoSize = true;
            this.lblNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNoti.Location = new System.Drawing.Point(623, 230);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(130, 25);
            this.lblNoti.TabIndex = 23;
            this.lblNoti.Text = "Notificações";
            // 
            // cuboAzul
            // 
            this.cuboAzul.Image = ((System.Drawing.Image)(resources.GetObject("cuboAzul.Image")));
            this.cuboAzul.Location = new System.Drawing.Point(677, 9);
            this.cuboAzul.Name = "cuboAzul";
            this.cuboAzul.Size = new System.Drawing.Size(49, 47);
            this.cuboAzul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cuboAzul.TabIndex = 24;
            this.cuboAzul.TabStop = false;
            // 
            // cuboVerde
            // 
            this.cuboVerde.Image = ((System.Drawing.Image)(resources.GetObject("cuboVerde.Image")));
            this.cuboVerde.Location = new System.Drawing.Point(676, 9);
            this.cuboVerde.Name = "cuboVerde";
            this.cuboVerde.Size = new System.Drawing.Size(49, 47);
            this.cuboVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cuboVerde.TabIndex = 25;
            this.cuboVerde.TabStop = false;
            // 
            // cuboAmarelo
            // 
            this.cuboAmarelo.Image = ((System.Drawing.Image)(resources.GetObject("cuboAmarelo.Image")));
            this.cuboAmarelo.Location = new System.Drawing.Point(677, 9);
            this.cuboAmarelo.Name = "cuboAmarelo";
            this.cuboAmarelo.Size = new System.Drawing.Size(49, 47);
            this.cuboAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cuboAmarelo.TabIndex = 26;
            this.cuboAmarelo.TabStop = false;
            // 
            // lblAutonomo
            // 
            this.lblAutonomo.AutoSize = true;
            this.lblAutonomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutonomo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAutonomo.Location = new System.Drawing.Point(731, 33);
            this.lblAutonomo.Name = "lblAutonomo";
            this.lblAutonomo.Size = new System.Drawing.Size(98, 24);
            this.lblAutonomo.TabIndex = 28;
            this.lblAutonomo.Text = "Autônomo";
            // 
            // lblAlternar
            // 
            this.lblAlternar.AutoSize = true;
            this.lblAlternar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlternar.ForeColor = System.Drawing.Color.Black;
            this.lblAlternar.Location = new System.Drawing.Point(690, 289);
            this.lblAlternar.Name = "lblAlternar";
            this.lblAlternar.Size = new System.Drawing.Size(129, 24);
            this.lblAlternar.TabIndex = 29;
            this.lblAlternar.Text = "Alternar Modo";
            this.lblAlternar.Click += new System.EventHandler(this.lblAlternar_Click);
            this.lblAlternar.DoubleClick += new System.EventHandler(this.lblAlternar_DoubleClick);
            this.lblAlternar.MouseLeave += new System.EventHandler(this.lblAlternar_MouseLeave);
            this.lblAlternar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAlternar_MouseMove);
            // 
            // lblAusente
            // 
            this.lblAusente.AutoSize = true;
            this.lblAusente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAusente.ForeColor = System.Drawing.Color.Gold;
            this.lblAusente.Location = new System.Drawing.Point(732, 32);
            this.lblAusente.Name = "lblAusente";
            this.lblAusente.Size = new System.Drawing.Size(80, 24);
            this.lblAusente.TabIndex = 36;
            this.lblAusente.Text = "Ausente";
            // 
            // lblDisponivel
            // 
            this.lblDisponivel.AutoSize = true;
            this.lblDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponivel.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDisponivel.Location = new System.Drawing.Point(731, 32);
            this.lblDisponivel.Name = "lblDisponivel";
            this.lblDisponivel.Size = new System.Drawing.Size(97, 24);
            this.lblDisponivel.TabIndex = 37;
            this.lblDisponivel.Text = "Disponível";
            // 
            // btnAutonomo
            // 
            this.btnAutonomo.BackColor = System.Drawing.Color.Transparent;
            this.btnAutonomo.FlatAppearance.BorderSize = 2;
            this.btnAutonomo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutonomo.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutonomo.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAutonomo.Location = new System.Drawing.Point(79, 329);
            this.btnAutonomo.Name = "btnAutonomo";
            this.btnAutonomo.Size = new System.Drawing.Size(205, 69);
            this.btnAutonomo.TabIndex = 38;
            this.btnAutonomo.Text = "Autônomo";
            this.btnAutonomo.UseVisualStyleBackColor = false;
            this.btnAutonomo.Visible = false;
            this.btnAutonomo.Click += new System.EventHandler(this.BtnAutonomo_Click);
            this.btnAutonomo.MouseEnter += new System.EventHandler(this.BtnAutonomo_MouseEnter);
            this.btnAutonomo.MouseLeave += new System.EventHandler(this.BtnAutonomo_MouseLeave);
            // 
            // btnAusente
            // 
            this.btnAusente.BackColor = System.Drawing.Color.Transparent;
            this.btnAusente.FlatAppearance.BorderSize = 2;
            this.btnAusente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAusente.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAusente.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAusente.Location = new System.Drawing.Point(322, 329);
            this.btnAusente.Name = "btnAusente";
            this.btnAusente.Size = new System.Drawing.Size(205, 69);
            this.btnAusente.TabIndex = 39;
            this.btnAusente.Text = "Ausente";
            this.btnAusente.UseVisualStyleBackColor = false;
            this.btnAusente.Visible = false;
            this.btnAusente.Click += new System.EventHandler(this.BtnAusente_Click);
            this.btnAusente.MouseEnter += new System.EventHandler(this.BtnAusente_MouseEnter);
            this.btnAusente.MouseLeave += new System.EventHandler(this.BtnAusente_MouseLeave);
            // 
            // btnDisponivel
            // 
            this.btnDisponivel.BackColor = System.Drawing.Color.Transparent;
            this.btnDisponivel.FlatAppearance.BorderSize = 2;
            this.btnDisponivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponivel.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponivel.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDisponivel.Location = new System.Drawing.Point(563, 329);
            this.btnDisponivel.Name = "btnDisponivel";
            this.btnDisponivel.Size = new System.Drawing.Size(205, 69);
            this.btnDisponivel.TabIndex = 40;
            this.btnDisponivel.Text = "Disponível";
            this.btnDisponivel.UseVisualStyleBackColor = false;
            this.btnDisponivel.Visible = false;
            this.btnDisponivel.Click += new System.EventHandler(this.BtnDisponivel_Click);
            this.btnDisponivel.MouseEnter += new System.EventHandler(this.BtnDisponivel_MouseEnter);
            this.btnDisponivel.MouseLeave += new System.EventHandler(this.BtnDisponivel_MouseLeave);
            // 
            // UCPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDisponivel);
            this.Controls.Add(this.btnAusente);
            this.Controls.Add(this.btnAutonomo);
            this.Controls.Add(this.lblDisponivel);
            this.Controls.Add(this.lblAusente);
            this.Controls.Add(this.lblAutonomo);
            this.Controls.Add(this.lblAlternar);
            this.Controls.Add(this.cuboVerde);
            this.Controls.Add(this.lblNoti);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRelogioMinuto);
            this.Controls.Add(this.piclogo2);
            this.Controls.Add(this.lblRelogioHora);
            this.Controls.Add(this.cuboAzul);
            this.Controls.Add(this.cuboAmarelo);
            this.Name = "UCPrincipal";
            this.Size = new System.Drawing.Size(836, 420);
            this.Load += new System.EventHandler(this.UCPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuboAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuboVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuboAmarelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ImgDigitos;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblRelogioMinuto;
        public System.Windows.Forms.Label lblRelogioHora;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox piclogo2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblNoti;
        private System.Windows.Forms.PictureBox cuboAzul;
        private System.Windows.Forms.PictureBox cuboVerde;
        private System.Windows.Forms.PictureBox cuboAmarelo;
        private System.Windows.Forms.Label lblAutonomo;
        private System.Windows.Forms.Label lblAlternar;
        private System.Windows.Forms.Label lblAusente;
        private System.Windows.Forms.Label lblDisponivel;
        private System.Windows.Forms.Button btnAutonomo;
        private System.Windows.Forms.Button btnAusente;
        private System.Windows.Forms.Button btnDisponivel;
    }
}
