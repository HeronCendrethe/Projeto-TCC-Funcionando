namespace Vismo
{
    partial class UCRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRegistro));
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnFornecedor.FlatAppearance.BorderSize = 2;
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFornecedor.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
            this.btnFornecedor.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedor.Location = new System.Drawing.Point(26, 159);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(191, 104);
            this.btnFornecedor.TabIndex = 3;
            this.btnFornecedor.TabStop = false;
            this.btnFornecedor.Text = "Fornecedores";
            this.btnFornecedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFornecedor.UseVisualStyleBackColor = false;
            this.btnFornecedor.Click += new System.EventHandler(this.BtnFornecedor_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnProduto.FlatAppearance.BorderSize = 2;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProduto.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto.Image")));
            this.btnProduto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduto.Location = new System.Drawing.Point(223, 159);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(191, 104);
            this.btnProduto.TabIndex = 2;
            this.btnProduto.TabStop = false;
            this.btnProduto.Text = "Produtos";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.Transparent;
            this.btnVenda.FlatAppearance.BorderSize = 2;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenda.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnVenda.Image")));
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenda.Location = new System.Drawing.Point(420, 159);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(191, 104);
            this.btnVenda.TabIndex = 4;
            this.btnVenda.TabStop = false;
            this.btnVenda.Text = "Venda";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.BtnVenda_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.Color.Transparent;
            this.btnPagamento.FlatAppearance.BorderSize = 2;
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagamento.Font = new System.Drawing.Font("Gadugi", 14F);
            this.btnPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamento.Image")));
            this.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagamento.Location = new System.Drawing.Point(617, 159);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(191, 104);
            this.btnPagamento.TabIndex = 5;
            this.btnPagamento.TabStop = false;
            this.btnPagamento.Text = "Pagamentos";
            this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagamento.UseVisualStyleBackColor = false;
            this.btnPagamento.Click += new System.EventHandler(this.BtnPagamento_Click);
            // 
            // UCRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnProduto);
            this.Name = "UCRegistro";
            this.Size = new System.Drawing.Size(833, 452);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnPagamento;
    }
}
