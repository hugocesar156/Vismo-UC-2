namespace Vismo
{
    partial class UCCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCadastro));
            this.lblFornecedores = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnProdutoE = new System.Windows.Forms.Button();
            this.btnProdutoL = new System.Windows.Forms.Button();
            this.btnProdutoF = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFornecedores
            // 
            this.lblFornecedores.AutoSize = true;
            this.lblFornecedores.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedores.Location = new System.Drawing.Point(28, 15);
            this.lblFornecedores.Name = "lblFornecedores";
            this.lblFornecedores.Size = new System.Drawing.Size(210, 36);
            this.lblFornecedores.TabIndex = 9;
            this.lblFornecedores.Text = "Fornecedores";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.lblProdutos.Location = new System.Drawing.Point(334, 15);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(138, 36);
            this.lblProdutos.TabIndex = 10;
            this.lblProdutos.Text = "Produtos";
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.lblPagamento.Location = new System.Drawing.Point(587, 15);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(197, 36);
            this.lblPagamento.TabIndex = 11;
            this.lblPagamento.Text = "Pagamentos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(330, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Produtos Sem Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(336, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Produtos no recinto\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(303, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cadastro produto fornecido\r\n";
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFornecedor.FlatAppearance.BorderSize = 2;
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
            this.btnFornecedor.Location = new System.Drawing.Point(69, 62);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(125, 83);
            this.btnFornecedor.TabIndex = 16;
            this.btnFornecedor.TabStop = false;
            this.btnFornecedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFornecedor.UseVisualStyleBackColor = false;
            this.btnFornecedor.Click += new System.EventHandler(this.BtnFornecedor_Click);
            // 
            // btnProdutoE
            // 
            this.btnProdutoE.BackColor = System.Drawing.Color.Transparent;
            this.btnProdutoE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProdutoE.FlatAppearance.BorderSize = 2;
            this.btnProdutoE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutoE.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutoE.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutoE.Image")));
            this.btnProdutoE.Location = new System.Drawing.Point(340, 62);
            this.btnProdutoE.Name = "btnProdutoE";
            this.btnProdutoE.Size = new System.Drawing.Size(125, 83);
            this.btnProdutoE.TabIndex = 17;
            this.btnProdutoE.TabStop = false;
            this.btnProdutoE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProdutoE.UseVisualStyleBackColor = false;
            this.btnProdutoE.Click += new System.EventHandler(this.BtnProdutoE_Click);
            // 
            // btnProdutoL
            // 
            this.btnProdutoL.BackColor = System.Drawing.Color.Transparent;
            this.btnProdutoL.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProdutoL.FlatAppearance.BorderSize = 2;
            this.btnProdutoL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutoL.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutoL.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutoL.Image")));
            this.btnProdutoL.Location = new System.Drawing.Point(340, 187);
            this.btnProdutoL.Name = "btnProdutoL";
            this.btnProdutoL.Size = new System.Drawing.Size(125, 83);
            this.btnProdutoL.TabIndex = 18;
            this.btnProdutoL.TabStop = false;
            this.btnProdutoL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProdutoL.UseVisualStyleBackColor = false;
            this.btnProdutoL.Click += new System.EventHandler(this.BtnProdutoL_Click);
            // 
            // btnProdutoF
            // 
            this.btnProdutoF.BackColor = System.Drawing.Color.Transparent;
            this.btnProdutoF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProdutoF.FlatAppearance.BorderSize = 2;
            this.btnProdutoF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutoF.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutoF.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutoF.Image")));
            this.btnProdutoF.Location = new System.Drawing.Point(340, 317);
            this.btnProdutoF.Name = "btnProdutoF";
            this.btnProdutoF.Size = new System.Drawing.Size(125, 83);
            this.btnProdutoF.TabIndex = 19;
            this.btnProdutoF.TabStop = false;
            this.btnProdutoF.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProdutoF.UseVisualStyleBackColor = false;
            this.btnProdutoF.Click += new System.EventHandler(this.BtnProdutoF_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.Color.Transparent;
            this.btnPagamento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPagamento.FlatAppearance.BorderSize = 2;
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamento.Image")));
            this.btnPagamento.Location = new System.Drawing.Point(624, 62);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(125, 83);
            this.btnPagamento.TabIndex = 20;
            this.btnPagamento.TabStop = false;
            this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagamento.UseVisualStyleBackColor = false;
            this.btnPagamento.Click += new System.EventHandler(this.BtnPagamento_Click);
            // 
            // UCCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.btnProdutoF);
            this.Controls.Add(this.btnProdutoL);
            this.Controls.Add(this.btnProdutoE);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.lblFornecedores);
            this.Name = "UCCadastro";
            this.Size = new System.Drawing.Size(833, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFornecedores;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnProdutoE;
        private System.Windows.Forms.Button btnProdutoL;
        private System.Windows.Forms.Button btnProdutoF;
        private System.Windows.Forms.Button btnPagamento;
    }
}
