namespace Proj_M14_BrunoPinheiro
{
    partial class frm_administracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_administracao));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_ginastica = new System.Windows.Forms.Panel();
            this.pic_ginastica = new System.Windows.Forms.PictureBox();
            this.pnl_natacao = new System.Windows.Forms.Panel();
            this.pnl_tenis = new System.Windows.Forms.Panel();
            this.pnl_badminton = new System.Windows.Forms.Panel();
            this.pnl_volei = new System.Windows.Forms.Panel();
            this.pnl_basquetebol = new System.Windows.Forms.Panel();
            this.pnl_futebol = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_ginastica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ginastica)).BeginInit();
            this.pnl_futebol.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.pnl_top.Controls.Add(this.lbl_name);
            this.pnl_top.Controls.Add(this.pic_close);
            this.pnl_top.Controls.Add(this.pic_logo);
            this.pnl_top.Controls.Add(this.pic_minimize);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(902, 51);
            this.pnl_top.TabIndex = 67;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_name.Location = new System.Drawing.Point(50, 15);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(105, 22);
            this.lbl_name.TabIndex = 101;
            this.lbl_name.Text = "BLUE LOCK";
            // 
            // pic_close
            // 
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Image = global::Proj_M14_BrunoPinheiro.Properties.Resources.close;
            this.pic_close.Location = new System.Drawing.Point(871, 16);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(18, 18);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 99;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::Proj_M14_BrunoPinheiro.Properties.Resources.logo;
            this.pic_logo.Location = new System.Drawing.Point(12, 9);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(32, 32);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 102;
            this.pic_logo.TabStop = false;
            // 
            // pic_minimize
            // 
            this.pic_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_minimize.Image = global::Proj_M14_BrunoPinheiro.Properties.Resources.minus_sign;
            this.pic_minimize.Location = new System.Drawing.Point(836, 16);
            this.pic_minimize.Name = "pic_minimize";
            this.pic_minimize.Size = new System.Drawing.Size(18, 18);
            this.pic_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minimize.TabIndex = 100;
            this.pic_minimize.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pnl_ginastica);
            this.panel1.Controls.Add(this.pnl_natacao);
            this.panel1.Controls.Add(this.pnl_tenis);
            this.panel1.Controls.Add(this.pnl_badminton);
            this.panel1.Controls.Add(this.pnl_volei);
            this.panel1.Controls.Add(this.pnl_basquetebol);
            this.panel1.Controls.Add(this.pnl_futebol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 465);
            this.panel1.TabIndex = 69;
            // 
            // pnl_ginastica
            // 
            this.pnl_ginastica.Controls.Add(this.pic_ginastica);
            this.pnl_ginastica.Enabled = false;
            this.pnl_ginastica.Location = new System.Drawing.Point(0, 906);
            this.pnl_ginastica.Name = "pnl_ginastica";
            this.pnl_ginastica.Size = new System.Drawing.Size(171, 100);
            this.pnl_ginastica.TabIndex = 6;
            this.pnl_ginastica.Visible = false;
            // 
            // pic_ginastica
            // 
            this.pic_ginastica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_ginastica.Image = global::Proj_M14_BrunoPinheiro.Properties.Resources.acrobat;
            this.pic_ginastica.Location = new System.Drawing.Point(0, 5);
            this.pic_ginastica.Name = "pic_ginastica";
            this.pic_ginastica.Size = new System.Drawing.Size(168, 90);
            this.pic_ginastica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ginastica.TabIndex = 70;
            this.pic_ginastica.TabStop = false;
            // 
            // pnl_natacao
            // 
            this.pnl_natacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_natacao.Enabled = false;
            this.pnl_natacao.Location = new System.Drawing.Point(0, 500);
            this.pnl_natacao.Name = "pnl_natacao";
            this.pnl_natacao.Size = new System.Drawing.Size(171, 100);
            this.pnl_natacao.TabIndex = 5;
            this.pnl_natacao.Visible = false;
            // 
            // pnl_tenis
            // 
            this.pnl_tenis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_tenis.Enabled = false;
            this.pnl_tenis.Location = new System.Drawing.Point(0, 400);
            this.pnl_tenis.Name = "pnl_tenis";
            this.pnl_tenis.Size = new System.Drawing.Size(171, 100);
            this.pnl_tenis.TabIndex = 4;
            this.pnl_tenis.Visible = false;
            // 
            // pnl_badminton
            // 
            this.pnl_badminton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_badminton.Enabled = false;
            this.pnl_badminton.Location = new System.Drawing.Point(0, 300);
            this.pnl_badminton.Name = "pnl_badminton";
            this.pnl_badminton.Size = new System.Drawing.Size(171, 100);
            this.pnl_badminton.TabIndex = 3;
            this.pnl_badminton.Visible = false;
            // 
            // pnl_volei
            // 
            this.pnl_volei.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_volei.Enabled = false;
            this.pnl_volei.Location = new System.Drawing.Point(0, 200);
            this.pnl_volei.Name = "pnl_volei";
            this.pnl_volei.Size = new System.Drawing.Size(171, 100);
            this.pnl_volei.TabIndex = 2;
            this.pnl_volei.Visible = false;
            // 
            // pnl_basquetebol
            // 
            this.pnl_basquetebol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_basquetebol.Enabled = false;
            this.pnl_basquetebol.Location = new System.Drawing.Point(0, 100);
            this.pnl_basquetebol.Name = "pnl_basquetebol";
            this.pnl_basquetebol.Size = new System.Drawing.Size(171, 100);
            this.pnl_basquetebol.TabIndex = 1;
            this.pnl_basquetebol.Visible = false;
            // 
            // pnl_futebol
            // 
            this.pnl_futebol.Controls.Add(this.button1);
            this.pnl_futebol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_futebol.Enabled = false;
            this.pnl_futebol.Location = new System.Drawing.Point(0, 0);
            this.pnl_futebol.Name = "pnl_futebol";
            this.pnl_futebol.Size = new System.Drawing.Size(171, 100);
            this.pnl_futebol.TabIndex = 0;
            this.pnl_futebol.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sócios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_administracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(902, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_administracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Lock - Administração";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_administracao_FormClosed);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnl_ginastica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ginastica)).EndInit();
            this.pnl_futebol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_ginastica;
        private System.Windows.Forms.PictureBox pic_ginastica;
        private System.Windows.Forms.Panel pnl_natacao;
        private System.Windows.Forms.Panel pnl_tenis;
        private System.Windows.Forms.Panel pnl_badminton;
        private System.Windows.Forms.Panel pnl_volei;
        private System.Windows.Forms.Panel pnl_basquetebol;
        private System.Windows.Forms.Panel pnl_futebol;
        private System.Windows.Forms.Button button1;
    }
}