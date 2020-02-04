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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Aut1 = new System.Windows.Forms.PictureBox();
            this.Aut2 = new System.Windows.Forms.PictureBox();
            this.Aus2 = new System.Windows.Forms.PictureBox();
            this.Disp1 = new System.Windows.Forms.PictureBox();
            this.Disp2 = new System.Windows.Forms.PictureBox();
            this.lblAlternar = new System.Windows.Forms.Label();
            this.Aus1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aut1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aut2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aus1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(696, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = " ! ";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.lblRelogioMinuto.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogioMinuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRelogioMinuto.Location = new System.Drawing.Point(385, 18);
            this.lblRelogioMinuto.Name = "lblRelogioMinuto";
            this.lblRelogioMinuto.Size = new System.Drawing.Size(86, 77);
            this.lblRelogioMinuto.TabIndex = 16;
            this.lblRelogioMinuto.Text = "00";
            // 
            // lblRelogioHora
            // 
            this.lblRelogioHora.AutoSize = true;
            this.lblRelogioHora.BackColor = System.Drawing.Color.Transparent;
            this.lblRelogioHora.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogioHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRelogioHora.Location = new System.Drawing.Point(312, 18);
            this.lblRelogioHora.Name = "lblRelogioHora";
            this.lblRelogioHora.Size = new System.Drawing.Size(86, 77);
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
            this.label2.Location = new System.Drawing.Point(375, 42);
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
            this.pictureBox1.Location = new System.Drawing.Point(664, 37);
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
            this.pictureBox2.Location = new System.Drawing.Point(676, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // piclogo2
            // 
            this.piclogo2.Image = ((System.Drawing.Image)(resources.GetObject("piclogo2.Image")));
            this.piclogo2.Location = new System.Drawing.Point(664, 37);
            this.piclogo2.Name = "piclogo2";
            this.piclogo2.Size = new System.Drawing.Size(114, 113);
            this.piclogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo2.TabIndex = 20;
            this.piclogo2.TabStop = false;
            this.piclogo2.Click += new System.EventHandler(this.piclogo2_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(676, 174);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPerfil.Location = new System.Drawing.Point(551, 50);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(107, 25);
            this.lblPerfil.TabIndex = 22;
            this.lblPerfil.Text = "Meu Perfil";
            // 
            // lblNoti
            // 
            this.lblNoti.AutoSize = true;
            this.lblNoti.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNoti.Location = new System.Drawing.Point(544, 174);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(126, 25);
            this.lblNoti.TabIndex = 23;
            this.lblNoti.Text = "Notificações";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(18, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(104, 95);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(18, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(104, 95);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(18, 18);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(104, 95);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(128, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Autônomo";
            // 
            // Aut1
            // 
            this.Aut1.Image = ((System.Drawing.Image)(resources.GetObject("Aut1.Image")));
            this.Aut1.Location = new System.Drawing.Point(-1, 300);
            this.Aut1.Name = "Aut1";
            this.Aut1.Size = new System.Drawing.Size(289, 65);
            this.Aut1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Aut1.TabIndex = 30;
            this.Aut1.TabStop = false;
            this.Aut1.Click += new System.EventHandler(this.Aut1_Click_1);
            this.Aut1.MouseLeave += new System.EventHandler(this.pictureBox7_MouseLeave);
            this.Aut1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Aut1_MouseMove);
            // 
            // Aut2
            // 
            this.Aut2.Image = ((System.Drawing.Image)(resources.GetObject("Aut2.Image")));
            this.Aut2.Location = new System.Drawing.Point(-1, 300);
            this.Aut2.Name = "Aut2";
            this.Aut2.Size = new System.Drawing.Size(289, 63);
            this.Aut2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Aut2.TabIndex = 31;
            this.Aut2.TabStop = false;
            this.Aut2.Click += new System.EventHandler(this.Aut2_Click);
            this.Aut2.MouseLeave += new System.EventHandler(this.Aut2_MouseLeave);
            this.Aut2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Aut2_MouseMove);
            // 
            // Aus2
            // 
            this.Aus2.Image = ((System.Drawing.Image)(resources.GetObject("Aus2.Image")));
            this.Aus2.Location = new System.Drawing.Point(260, 300);
            this.Aus2.Name = "Aus2";
            this.Aus2.Size = new System.Drawing.Size(275, 65);
            this.Aus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Aus2.TabIndex = 33;
            this.Aus2.TabStop = false;
            this.Aus2.Click += new System.EventHandler(this.Aus2_Click);
            this.Aus2.MouseLeave += new System.EventHandler(this.Aus2_MouseLeave);
            // 
            // Disp1
            // 
            this.Disp1.Image = ((System.Drawing.Image)(resources.GetObject("Disp1.Image")));
            this.Disp1.Location = new System.Drawing.Point(531, 300);
            this.Disp1.Name = "Disp1";
            this.Disp1.Size = new System.Drawing.Size(289, 65);
            this.Disp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Disp1.TabIndex = 34;
            this.Disp1.TabStop = false;
            this.Disp1.MouseLeave += new System.EventHandler(this.Disp1_MouseLeave);
            this.Disp1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Disp1_MouseMove);
            // 
            // Disp2
            // 
            this.Disp2.Image = ((System.Drawing.Image)(resources.GetObject("Disp2.Image")));
            this.Disp2.Location = new System.Drawing.Point(531, 298);
            this.Disp2.Name = "Disp2";
            this.Disp2.Size = new System.Drawing.Size(289, 65);
            this.Disp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Disp2.TabIndex = 35;
            this.Disp2.TabStop = false;
            this.Disp2.Click += new System.EventHandler(this.Disp2_Click);
            // 
            // lblAlternar
            // 
            this.lblAlternar.AutoSize = true;
            this.lblAlternar.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlternar.ForeColor = System.Drawing.Color.Black;
            this.lblAlternar.Location = new System.Drawing.Point(321, 157);
            this.lblAlternar.Name = "lblAlternar";
            this.lblAlternar.Size = new System.Drawing.Size(131, 23);
            this.lblAlternar.TabIndex = 29;
            this.lblAlternar.Text = "Alternar Modo";
            this.lblAlternar.Click += new System.EventHandler(this.lblAlternar_Click);
            this.lblAlternar.DoubleClick += new System.EventHandler(this.lblAlternar_DoubleClick);
            this.lblAlternar.MouseLeave += new System.EventHandler(this.lblAlternar_MouseLeave);
            this.lblAlternar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAlternar_MouseMove);
            // 
            // Aus1
            // 
            this.Aus1.Image = ((System.Drawing.Image)(resources.GetObject("Aus1.Image")));
            this.Aus1.Location = new System.Drawing.Point(260, 298);
            this.Aus1.Name = "Aus1";
            this.Aus1.Size = new System.Drawing.Size(275, 65);
            this.Aus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Aus1.TabIndex = 32;
            this.Aus1.TabStop = false;
            this.Aus1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Aus1_MouseMove);
            // 
            // UCPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Disp1);
            this.Controls.Add(this.Aus1);
            this.Controls.Add(this.Aut1);
            this.Controls.Add(this.lblAlternar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblNoti);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRelogioMinuto);
            this.Controls.Add(this.piclogo2);
            this.Controls.Add(this.Aut2);
            this.Controls.Add(this.Aus2);
            this.Controls.Add(this.Disp2);
            this.Controls.Add(this.lblRelogioHora);
            this.Name = "UCPrincipal";
            this.Size = new System.Drawing.Size(836, 420);
            this.Load += new System.EventHandler(this.UCPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aut1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aut2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aus1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Aut1;
        private System.Windows.Forms.PictureBox Aut2;
        private System.Windows.Forms.PictureBox Aus2;
        private System.Windows.Forms.PictureBox Disp1;
        private System.Windows.Forms.PictureBox Disp2;
        private System.Windows.Forms.Label lblAlternar;
        private System.Windows.Forms.PictureBox Aus1;
    }
}
