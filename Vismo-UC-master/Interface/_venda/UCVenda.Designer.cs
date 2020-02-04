namespace Vismo._venda
{
    partial class UCVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCVenda));
            this.btnVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.Transparent;
            this.btnVenda.FlatAppearance.BorderSize = 2;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenda.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnVenda.Image")));
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenda.Location = new System.Drawing.Point(127, 58);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(191, 104);
            this.btnVenda.TabIndex = 2;
            this.btnVenda.TabStop = false;
            this.btnVenda.Text = "Nova Venda";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.BtnVenda_Click);
            // 
            // UCVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVenda);
            this.Name = "UCVenda";
            this.Size = new System.Drawing.Size(833, 452);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVenda;
    }
}
