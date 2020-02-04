namespace Vismo
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnTema = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.lblSobre = new System.Windows.Forms.Label();
            this.lblConf = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DimGray;
            this.panelLeft.Controls.Add(this.logo1);
            this.panelLeft.Controls.Add(this.btnEstoque);
            this.panelLeft.Controls.Add(this.btnRegistro);
            this.panelLeft.Controls.Add(this.btnVenda);
            this.panelLeft.Controls.Add(this.btnCadastro);
            this.panelLeft.Controls.Add(this.logo2);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(189, 559);
            this.panelLeft.TabIndex = 0;
            // 
            // logo1
            // 
            this.logo1.Image = ((System.Drawing.Image)(resources.GetObject("logo1.Image")));
            this.logo1.Location = new System.Drawing.Point(0, -5);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(176, 166);
            this.logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo1.TabIndex = 11;
            this.logo1.TabStop = false;
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Gadugi", 14F);
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(0, 409);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(186, 53);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.TabStop = false;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstoque.UseVisualStyleBackColor = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Gadugi", 14F);
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistro.Image")));
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(0, 262);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(186, 53);
            this.btnRegistro.TabIndex = 3;
            this.btnRegistro.TabStop = false;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.Transparent;
            this.btnVenda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Font = new System.Drawing.Font("Gadugi", 14F);
            this.btnVenda.ForeColor = System.Drawing.Color.White;
            this.btnVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnVenda.Image")));
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenda.Location = new System.Drawing.Point(0, 335);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(186, 53);
            this.btnVenda.TabIndex = 2;
            this.btnVenda.TabStop = false;
            this.btnVenda.Text = "Venda";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.BtnVenda_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Gadugi", 14F);
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastro.Image")));
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(0, 191);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(186, 53);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.TabStop = false;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // logo2
            // 
            this.logo2.Image = ((System.Drawing.Image)(resources.GetObject("logo2.Image")));
            this.logo2.Location = new System.Drawing.Point(0, 3);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(176, 158);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo2.TabIndex = 12;
            this.logo2.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DimGray;
            this.panelTop.Controls.Add(this.btnTema);
            this.panelTop.Controls.Add(this.btnHome);
            this.panelTop.Controls.Add(this.lblAjuda);
            this.panelTop.Controls.Add(this.lblSobre);
            this.panelTop.Controls.Add(this.lblConf);
            this.panelTop.Controls.Add(this.lblSair);
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnFechar);
            this.panelTop.Location = new System.Drawing.Point(174, -5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(834, 105);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseUp);
            // 
            // btnTema
            // 
            this.btnTema.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTema.BackgroundImage")));
            this.btnTema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTema.ForeColor = System.Drawing.Color.DimGray;
            this.btnTema.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTema.Location = new System.Drawing.Point(21, 18);
            this.btnTema.Name = "btnTema";
            this.btnTema.Size = new System.Drawing.Size(55, 52);
            this.btnTema.TabIndex = 12;
            this.btnTema.UseVisualStyleBackColor = true;
            this.btnTema.Click += new System.EventHandler(this.BtnTema_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(372, 24);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(40, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.BackColor = System.Drawing.Color.Transparent;
            this.lblAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAjuda.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.Location = new System.Drawing.Point(278, 74);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(39, 16);
            this.lblAjuda.TabIndex = 4;
            this.lblAjuda.Text = "Ajuda";
            this.lblAjuda.Click += new System.EventHandler(this.LblAjuda_Click);
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.BackColor = System.Drawing.Color.Transparent;
            this.lblSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSobre.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.Location = new System.Drawing.Point(339, 74);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(38, 16);
            this.lblSobre.TabIndex = 3;
            this.lblSobre.Text = "Sobre";
            // 
            // lblConf
            // 
            this.lblConf.AutoSize = true;
            this.lblConf.BackColor = System.Drawing.Color.Transparent;
            this.lblConf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConf.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConf.Location = new System.Drawing.Point(391, 74);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(85, 16);
            this.lblConf.TabIndex = 2;
            this.lblConf.Text = "Configurações";
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.BackColor = System.Drawing.Color.Transparent;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.Location = new System.Drawing.Point(490, 74);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(27, 16);
            this.lblSair.TabIndex = 0;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.LblSair_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(720, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(43, 35);
            this.btnMin.TabIndex = 1;
            this.btnMin.TabStop = false;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(772, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 35);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // panelFill
            // 
            this.panelFill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFill.Location = new System.Drawing.Point(182, 88);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(813, 458);
            this.panelFill.TabIndex = 2;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // piclogo
            // 
            this.piclogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(0, 0);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(993, 545);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 0;
            this.piclogo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(993, 545);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.piclogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label lblConf;
        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox piclogo;
        public System.Windows.Forms.Button btnTema;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel panelTop;
    }
}