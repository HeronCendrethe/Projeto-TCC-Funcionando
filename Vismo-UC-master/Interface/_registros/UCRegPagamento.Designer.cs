namespace Vismo._registros
{
    partial class UCRegPagamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPagamento = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioPendente = new System.Windows.Forms.RadioButton();
            this.radioRealizado = new System.Windows.Forms.RadioButton();
            this.radioAtrasado = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnDesc = new System.Windows.Forms.Button();
            this.txtPrazo = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dgvDescricao = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescricao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registro de Pagamentos";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.Red;
            this.lblRegistro.Location = new System.Drawing.Point(506, 62);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(170, 16);
            this.lblRegistro.TabIndex = 21;
            this.lblRegistro.Text = "Nenhum registro encontrado";
            this.lblRegistro.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisar.FlatAppearance.BorderSize = 2;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.Location = new System.Drawing.Point(694, 85);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 38);
            this.btnPesquisar.TabIndex = 19;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(474, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(198, 29);
            this.txtNome.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fornecedor:";
            // 
            // dgvPagamento
            // 
            this.dgvPagamento.AllowUserToAddRows = false;
            this.dgvPagamento.AllowUserToDeleteRows = false;
            this.dgvPagamento.AllowUserToResizeColumns = false;
            this.dgvPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Prazo,
            this.Valor,
            this.Descricao,
            this.Fornecedor,
            this.Status});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagamento.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPagamento.Location = new System.Drawing.Point(33, 133);
            this.dgvPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPagamento.MultiSelect = false;
            this.dgvPagamento.Name = "dgvPagamento";
            this.dgvPagamento.ReadOnly = true;
            this.dgvPagamento.RowHeadersWidth = 62;
            this.dgvPagamento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPagamento.RowTemplate.Height = 28;
            this.dgvPagamento.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagamento.Size = new System.Drawing.Size(754, 230);
            this.dgvPagamento.TabIndex = 13;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 90;
            // 
            // Prazo
            // 
            this.Prazo.DataPropertyName = "prazo";
            this.Prazo.HeaderText = "Prazo";
            this.Prazo.Name = "Prazo";
            this.Prazo.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 8;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "descr";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "nome";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            this.Fornecedor.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // radioPendente
            // 
            this.radioPendente.AutoSize = true;
            this.radioPendente.Checked = true;
            this.radioPendente.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.radioPendente.Location = new System.Drawing.Point(37, 372);
            this.radioPendente.Name = "radioPendente";
            this.radioPendente.Size = new System.Drawing.Size(86, 20);
            this.radioPendente.TabIndex = 22;
            this.radioPendente.TabStop = true;
            this.radioPendente.Text = "Pendentes";
            this.radioPendente.UseVisualStyleBackColor = true;
            this.radioPendente.CheckedChanged += new System.EventHandler(this.RadioPendente_CheckedChanged);
            // 
            // radioRealizado
            // 
            this.radioRealizado.AutoSize = true;
            this.radioRealizado.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.radioRealizado.Location = new System.Drawing.Point(132, 372);
            this.radioRealizado.Name = "radioRealizado";
            this.radioRealizado.Size = new System.Drawing.Size(89, 20);
            this.radioRealizado.TabIndex = 23;
            this.radioRealizado.Text = "Realizados";
            this.radioRealizado.UseVisualStyleBackColor = true;
            this.radioRealizado.CheckedChanged += new System.EventHandler(this.RadioRealizado_CheckedChanged);
            // 
            // radioAtrasado
            // 
            this.radioAtrasado.AutoSize = true;
            this.radioAtrasado.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.radioAtrasado.Location = new System.Drawing.Point(224, 372);
            this.radioAtrasado.Name = "radioAtrasado";
            this.radioAtrasado.Size = new System.Drawing.Size(85, 20);
            this.radioAtrasado.TabIndex = 24;
            this.radioAtrasado.Text = "Atrasados";
            this.radioAtrasado.UseVisualStyleBackColor = true;
            this.radioAtrasado.CheckedChanged += new System.EventHandler(this.RadioAtrasado_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 44);
            this.label3.TabIndex = 26;
            this.label3.Text = "Prazo de\r\npagamento:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatAppearance.BorderSize = 2;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(484, 372);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(93, 38);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemover.FlatAppearance.BorderSize = 2;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.Location = new System.Drawing.Point(583, 372);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(93, 38);
            this.btnRemover.TabIndex = 28;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFinalizar.FlatAppearance.BorderSize = 2;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.Location = new System.Drawing.Point(385, 372);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(93, 38);
            this.btnFinalizar.TabIndex = 29;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // btnDesc
            // 
            this.btnDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnDesc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDesc.FlatAppearance.BorderSize = 2;
            this.btnDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesc.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesc.ForeColor = System.Drawing.Color.White;
            this.btnDesc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesc.Location = new System.Drawing.Point(689, 372);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(98, 59);
            this.btnDesc.TabIndex = 30;
            this.btnDesc.Text = "Visualizar Descrição";
            this.btnDesc.UseVisualStyleBackColor = false;
            this.btnDesc.Click += new System.EventHandler(this.BtnDesc_Click);
            // 
            // txtPrazo
            // 
            this.txtPrazo.Font = new System.Drawing.Font("Gadugi", 12F);
            this.txtPrazo.Location = new System.Drawing.Point(232, 90);
            this.txtPrazo.Mask = "99/99/9999";
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(103, 29);
            this.txtPrazo.TabIndex = 31;
            this.txtPrazo.Leave += new System.EventHandler(this.TxtPrazo_Leave);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Red;
            this.lblData.Location = new System.Drawing.Point(231, 62);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(145, 16);
            this.lblData.TabIndex = 38;
            this.lblData.Text = "Formato de data inválido";
            this.lblData.Visible = false;
            // 
            // dgvDescricao
            // 
            this.dgvDescricao.AllowUserToAddRows = false;
            this.dgvDescricao.AllowUserToDeleteRows = false;
            this.dgvDescricao.AllowUserToResizeColumns = false;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1);
            this.dgvDescricao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDescricao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDescricao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescricao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDescricao.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDescricao.Location = new System.Drawing.Point(33, 133);
            this.dgvDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDescricao.MultiSelect = false;
            this.dgvDescricao.Name = "dgvDescricao";
            this.dgvDescricao.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDescricao.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDescricao.RowHeadersWidth = 62;
            this.dgvDescricao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDescricao.RowTemplate.Height = 28;
            this.dgvDescricao.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDescricao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDescricao.Size = new System.Drawing.Size(754, 230);
            this.dgvDescricao.TabIndex = 39;
            this.dgvDescricao.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descr";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 685;
            // 
            // UCRegPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDescricao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtPrazo);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioAtrasado);
            this.Controls.Add(this.radioRealizado);
            this.Controls.Add(this.radioPendente);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPagamento);
            this.Controls.Add(this.label1);
            this.Name = "UCRegPagamento";
            this.Size = new System.Drawing.Size(833, 452);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescricao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPagamento;
        private System.Windows.Forms.RadioButton radioPendente;
        private System.Windows.Forms.RadioButton radioRealizado;
        private System.Windows.Forms.RadioButton radioAtrasado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.MaskedTextBox txtPrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataGridView dgvDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
