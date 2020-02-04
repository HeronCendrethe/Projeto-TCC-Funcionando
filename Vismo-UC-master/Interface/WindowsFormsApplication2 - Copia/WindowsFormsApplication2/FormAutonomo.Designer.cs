namespace WindowsFormsApplication2
{
    partial class FormAutonomo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutonomo));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVendas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Totalvenda = new System.Windows.Forms.Label();
            this.totalvendamanha = new System.Windows.Forms.Label();
            this.totalvendatarde = new System.Windows.Forms.Label();
            this.totalvendanoite = new System.Windows.Forms.Label();
            this.lblCancelamentoNoite = new System.Windows.Forms.Label();
            this.lblTotalCancelamentoTarde = new System.Windows.Forms.Label();
            this.lblTotalCancelamentoManha = new System.Windows.Forms.Label();
            this.lblTotalCancelamento = new System.Windows.Forms.Label();
            this.lblcancelamentos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picvoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(106, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boa tarde,(nome).";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 438);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblVendas.Location = new System.Drawing.Point(109, 170);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(274, 16);
            this.lblVendas.TabIndex = 4;
            this.lblVendas.Text = "Olá, (nome) essas são suas vendas de hoje.";
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(113, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Vendas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(385, 108);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelamentos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(656, 108);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "Estastísticas\r\n\r\n";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Totalvenda
            // 
            this.Totalvenda.AutoSize = true;
            this.Totalvenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Totalvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totalvenda.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Totalvenda.Location = new System.Drawing.Point(109, 204);
            this.Totalvenda.Name = "Totalvenda";
            this.Totalvenda.Size = new System.Drawing.Size(114, 16);
            this.Totalvenda.TabIndex = 8;
            this.Totalvenda.Text = "(Total de vendas)";
            // 
            // totalvendamanha
            // 
            this.totalvendamanha.AutoSize = true;
            this.totalvendamanha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.totalvendamanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalvendamanha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.totalvendamanha.Location = new System.Drawing.Point(109, 244);
            this.totalvendamanha.Name = "totalvendamanha";
            this.totalvendamanha.Size = new System.Drawing.Size(176, 16);
            this.totalvendamanha.TabIndex = 9;
            this.totalvendamanha.Text = "(Total de venda na manhãs)";
            // 
            // totalvendatarde
            // 
            this.totalvendatarde.AutoSize = true;
            this.totalvendatarde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.totalvendatarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalvendatarde.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.totalvendatarde.Location = new System.Drawing.Point(109, 280);
            this.totalvendatarde.Name = "totalvendatarde";
            this.totalvendatarde.Size = new System.Drawing.Size(159, 16);
            this.totalvendatarde.TabIndex = 10;
            this.totalvendatarde.Text = "(Total de venda na tarde)";
            // 
            // totalvendanoite
            // 
            this.totalvendanoite.AutoSize = true;
            this.totalvendanoite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.totalvendanoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalvendanoite.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.totalvendanoite.Location = new System.Drawing.Point(109, 318);
            this.totalvendanoite.Name = "totalvendanoite";
            this.totalvendanoite.Size = new System.Drawing.Size(157, 16);
            this.totalvendanoite.TabIndex = 11;
            this.totalvendanoite.Text = "(Total de venda na noite)";
            // 
            // lblCancelamentoNoite
            // 
            this.lblCancelamentoNoite.AutoSize = true;
            this.lblCancelamentoNoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelamentoNoite.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCancelamentoNoite.Location = new System.Drawing.Point(381, 318);
            this.lblCancelamentoNoite.Name = "lblCancelamentoNoite";
            this.lblCancelamentoNoite.Size = new System.Drawing.Size(211, 16);
            this.lblCancelamentoNoite.TabIndex = 16;
            this.lblCancelamentoNoite.Text = "(Total de cancelamentos na noite)";
            // 
            // lblTotalCancelamentoTarde
            // 
            this.lblTotalCancelamentoTarde.AutoSize = true;
            this.lblTotalCancelamentoTarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCancelamentoTarde.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTotalCancelamentoTarde.Location = new System.Drawing.Point(381, 280);
            this.lblTotalCancelamentoTarde.Name = "lblTotalCancelamentoTarde";
            this.lblTotalCancelamentoTarde.Size = new System.Drawing.Size(213, 16);
            this.lblTotalCancelamentoTarde.TabIndex = 15;
            this.lblTotalCancelamentoTarde.Text = "(Total de cancelamentos na tarde)";
            // 
            // lblTotalCancelamentoManha
            // 
            this.lblTotalCancelamentoManha.AutoSize = true;
            this.lblTotalCancelamentoManha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCancelamentoManha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTotalCancelamentoManha.Location = new System.Drawing.Point(381, 244);
            this.lblTotalCancelamentoManha.Name = "lblTotalCancelamentoManha";
            this.lblTotalCancelamentoManha.Size = new System.Drawing.Size(223, 16);
            this.lblTotalCancelamentoManha.TabIndex = 14;
            this.lblTotalCancelamentoManha.Text = "(Total de cancelamentos na manhã)";
            // 
            // lblTotalCancelamento
            // 
            this.lblTotalCancelamento.AutoSize = true;
            this.lblTotalCancelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCancelamento.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTotalCancelamento.Location = new System.Drawing.Point(381, 204);
            this.lblTotalCancelamento.Name = "lblTotalCancelamento";
            this.lblTotalCancelamento.Size = new System.Drawing.Size(161, 16);
            this.lblTotalCancelamento.TabIndex = 13;
            this.lblTotalCancelamento.Text = "(Total de cancelamentos)";
            // 
            // lblcancelamentos
            // 
            this.lblcancelamentos.AutoSize = true;
            this.lblcancelamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcancelamentos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblcancelamentos.Location = new System.Drawing.Point(381, 170);
            this.lblcancelamentos.Name = "lblcancelamentos";
            this.lblcancelamentos.Size = new System.Drawing.Size(317, 16);
            this.lblcancelamentos.TabIndex = 12;
            this.lblcancelamentos.Text = "Olá, (nome) estes são seus cancelamentos de hoje.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(109, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Modo Autônomo";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picvoltar
            // 
            this.picvoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picvoltar.BackgroundImage")));
            this.picvoltar.Image = ((System.Drawing.Image)(resources.GetObject("picvoltar.Image")));
            this.picvoltar.Location = new System.Drawing.Point(0, 0);
            this.picvoltar.Name = "picvoltar";
            this.picvoltar.Size = new System.Drawing.Size(100, 50);
            this.picvoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picvoltar.TabIndex = 18;
            this.picvoltar.TabStop = false;
            this.picvoltar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormAutonomo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(869, 438);
            this.Controls.Add(this.picvoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCancelamentoNoite);
            this.Controls.Add(this.lblTotalCancelamentoTarde);
            this.Controls.Add(this.lblTotalCancelamentoManha);
            this.Controls.Add(this.lblTotalCancelamento);
            this.Controls.Add(this.lblcancelamentos);
            this.Controls.Add(this.totalvendanoite);
            this.Controls.Add(this.totalvendatarde);
            this.Controls.Add(this.totalvendamanha);
            this.Controls.Add(this.Totalvenda);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblVendas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "FormAutonomo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Totalvenda;
        private System.Windows.Forms.Label totalvendamanha;
        private System.Windows.Forms.Label totalvendatarde;
        private System.Windows.Forms.Label totalvendanoite;
        private System.Windows.Forms.Label lblCancelamentoNoite;
        private System.Windows.Forms.Label lblTotalCancelamentoTarde;
        private System.Windows.Forms.Label lblTotalCancelamentoManha;
        private System.Windows.Forms.Label lblTotalCancelamento;
        private System.Windows.Forms.Label lblcancelamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picvoltar;
    }
}

