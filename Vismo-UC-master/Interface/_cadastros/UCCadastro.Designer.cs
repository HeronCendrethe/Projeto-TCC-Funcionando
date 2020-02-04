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
            this.picFornecedor = new System.Windows.Forms.PictureBox();
            this.picProdutoSEstoque = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picProdutoLocal = new System.Windows.Forms.PictureBox();
            this.lblFornecedores = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picPagamento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutoSEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutoLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // picFornecedor
            // 
            this.picFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("picFornecedor.Image")));
            this.picFornecedor.Location = new System.Drawing.Point(75, 78);
            this.picFornecedor.Name = "picFornecedor";
            this.picFornecedor.Size = new System.Drawing.Size(87, 86);
            this.picFornecedor.TabIndex = 5;
            this.picFornecedor.TabStop = false;
            this.picFornecedor.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picFornecedor.MouseLeave += new System.EventHandler(this.picFornecedor_MouseLeave);
            this.picFornecedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picFornecedor_MouseMove);
            // 
            // picProdutoSEstoque
            // 
            this.picProdutoSEstoque.Image = ((System.Drawing.Image)(resources.GetObject("picProdutoSEstoque.Image")));
            this.picProdutoSEstoque.Location = new System.Drawing.Point(307, 78);
            this.picProdutoSEstoque.Name = "picProdutoSEstoque";
            this.picProdutoSEstoque.Size = new System.Drawing.Size(87, 86);
            this.picProdutoSEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picProdutoSEstoque.TabIndex = 6;
            this.picProdutoSEstoque.TabStop = false;
            this.picProdutoSEstoque.Click += new System.EventHandler(this.picProdutoSEstoque_Click);
            this.picProdutoSEstoque.MouseLeave += new System.EventHandler(this.picProdutoSEstoque_MouseLeave);
            this.picProdutoSEstoque.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picProdutoSEstoque_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(307, 284);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // picProdutoLocal
            // 
            this.picProdutoLocal.Image = ((System.Drawing.Image)(resources.GetObject("picProdutoLocal.Image")));
            this.picProdutoLocal.Location = new System.Drawing.Point(307, 179);
            this.picProdutoLocal.Name = "picProdutoLocal";
            this.picProdutoLocal.Size = new System.Drawing.Size(87, 86);
            this.picProdutoLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picProdutoLocal.TabIndex = 8;
            this.picProdutoLocal.TabStop = false;
            this.picProdutoLocal.Click += new System.EventHandler(this.picProdutoLocal_Click);
            this.picProdutoLocal.MouseLeave += new System.EventHandler(this.picProdutoLocal_MouseLeave);
            this.picProdutoLocal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picProdutoLocal_MouseMove);
            // 
            // lblFornecedores
            // 
            this.lblFornecedores.AutoSize = true;
            this.lblFornecedores.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedores.Location = new System.Drawing.Point(29, 25);
            this.lblFornecedores.Name = "lblFornecedores";
            this.lblFornecedores.Size = new System.Drawing.Size(210, 36);
            this.lblFornecedores.TabIndex = 9;
            this.lblFornecedores.Text = "Fornecedores";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.lblProdutos.Location = new System.Drawing.Point(354, 25);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(138, 36);
            this.lblProdutos.TabIndex = 10;
            this.lblProdutos.Text = "Produtos";
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.lblPagamento.Location = new System.Drawing.Point(611, 25);
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
            this.label3.Location = new System.Drawing.Point(428, 106);
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
            this.label4.Location = new System.Drawing.Point(428, 218);
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
            this.label5.Location = new System.Drawing.Point(428, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cadastro produto fornecido\r\n";
            // 
            // picPagamento
            // 
            this.picPagamento.BackColor = System.Drawing.Color.Transparent;
            this.picPagamento.Image = ((System.Drawing.Image)(resources.GetObject("picPagamento.Image")));
            this.picPagamento.Location = new System.Drawing.Point(648, 78);
            this.picPagamento.Name = "picPagamento";
            this.picPagamento.Size = new System.Drawing.Size(87, 86);
            this.picPagamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPagamento.TabIndex = 12;
            this.picPagamento.TabStop = false;
            this.picPagamento.Click += new System.EventHandler(this.picPagamento_Click);
            this.picPagamento.MouseLeave += new System.EventHandler(this.picPagamento_MouseLeave);
            this.picPagamento.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPagamento_MouseMove);
            // 
            // UCCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picPagamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picProdutoLocal);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.picProdutoSEstoque);
            this.Controls.Add(this.lblFornecedores);
            this.Name = "UCCadastro";
            this.Size = new System.Drawing.Size(833, 452);
            this.Load += new System.EventHandler(this.UCCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutoSEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutoLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picFornecedor;
        private System.Windows.Forms.PictureBox picProdutoSEstoque;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picProdutoLocal;
        private System.Windows.Forms.Label lblFornecedores;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picPagamento;
    }
}
