namespace Proj_M14_BrunoPinheiro
{
    partial class frm_areacliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_areacliente));
            this.pnl_fundo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_modalidades = new System.Windows.Forms.Panel();
            this.pnl_selected3 = new System.Windows.Forms.Panel();
            this.btn_modalidades = new System.Windows.Forms.Button();
            this.pnl_treinadores = new System.Windows.Forms.Panel();
            this.pnl_selected2 = new System.Windows.Forms.Panel();
            this.btn_quotas = new System.Windows.Forms.Button();
            this.pnl_socios = new System.Windows.Forms.Panel();
            this.pnl_selected1 = new System.Windows.Forms.Panel();
            this.btn_dados = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.lbl_abertofechado = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tmr_data = new System.Windows.Forms.Timer(this.components);
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_modalidades.SuspendLayout();
            this.pnl_treinadores.SuspendLayout();
            this.pnl_socios.SuspendLayout();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_fundo
            // 
            this.pnl_fundo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_fundo.Location = new System.Drawing.Point(185, 51);
            this.pnl_fundo.Name = "pnl_fundo";
            this.pnl_fundo.Size = new System.Drawing.Size(860, 465);
            this.pnl_fundo.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.pnl_modalidades);
            this.panel1.Controls.Add(this.pnl_treinadores);
            this.panel1.Controls.Add(this.pnl_socios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 465);
            this.panel1.TabIndex = 72;
            // 
            // pnl_modalidades
            // 
            this.pnl_modalidades.Controls.Add(this.pnl_selected3);
            this.pnl_modalidades.Controls.Add(this.btn_modalidades);
            this.pnl_modalidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_modalidades.Location = new System.Drawing.Point(0, 200);
            this.pnl_modalidades.Name = "pnl_modalidades";
            this.pnl_modalidades.Size = new System.Drawing.Size(185, 100);
            this.pnl_modalidades.TabIndex = 2;
            // 
            // pnl_selected3
            // 
            this.pnl_selected3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(81)))));
            this.pnl_selected3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_selected3.Enabled = false;
            this.pnl_selected3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pnl_selected3.Location = new System.Drawing.Point(0, 0);
            this.pnl_selected3.Name = "pnl_selected3";
            this.pnl_selected3.Size = new System.Drawing.Size(10, 100);
            this.pnl_selected3.TabIndex = 2;
            this.pnl_selected3.Visible = false;
            // 
            // btn_modalidades
            // 
            this.btn_modalidades.FlatAppearance.BorderSize = 0;
            this.btn_modalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modalidades.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modalidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_modalidades.Location = new System.Drawing.Point(3, 2);
            this.btn_modalidades.Name = "btn_modalidades";
            this.btn_modalidades.Size = new System.Drawing.Size(182, 98);
            this.btn_modalidades.TabIndex = 1;
            this.btn_modalidades.Text = "Modalidades";
            this.btn_modalidades.UseVisualStyleBackColor = true;
            this.btn_modalidades.Click += new System.EventHandler(this.btn_modalidades_Click);
            // 
            // pnl_treinadores
            // 
            this.pnl_treinadores.Controls.Add(this.pnl_selected2);
            this.pnl_treinadores.Controls.Add(this.btn_quotas);
            this.pnl_treinadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_treinadores.Location = new System.Drawing.Point(0, 100);
            this.pnl_treinadores.Name = "pnl_treinadores";
            this.pnl_treinadores.Size = new System.Drawing.Size(185, 100);
            this.pnl_treinadores.TabIndex = 1;
            // 
            // pnl_selected2
            // 
            this.pnl_selected2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(81)))));
            this.pnl_selected2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_selected2.Enabled = false;
            this.pnl_selected2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pnl_selected2.Location = new System.Drawing.Point(0, 0);
            this.pnl_selected2.Name = "pnl_selected2";
            this.pnl_selected2.Size = new System.Drawing.Size(10, 100);
            this.pnl_selected2.TabIndex = 2;
            this.pnl_selected2.Visible = false;
            // 
            // btn_quotas
            // 
            this.btn_quotas.FlatAppearance.BorderSize = 0;
            this.btn_quotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quotas.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_quotas.Location = new System.Drawing.Point(3, 2);
            this.btn_quotas.Name = "btn_quotas";
            this.btn_quotas.Size = new System.Drawing.Size(182, 98);
            this.btn_quotas.TabIndex = 1;
            this.btn_quotas.Text = "Quotas";
            this.btn_quotas.UseVisualStyleBackColor = true;
            this.btn_quotas.Click += new System.EventHandler(this.btn_quotas_Click);
            // 
            // pnl_socios
            // 
            this.pnl_socios.Controls.Add(this.pnl_selected1);
            this.pnl_socios.Controls.Add(this.btn_dados);
            this.pnl_socios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_socios.Location = new System.Drawing.Point(0, 0);
            this.pnl_socios.Name = "pnl_socios";
            this.pnl_socios.Size = new System.Drawing.Size(185, 100);
            this.pnl_socios.TabIndex = 0;
            // 
            // pnl_selected1
            // 
            this.pnl_selected1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(81)))));
            this.pnl_selected1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_selected1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pnl_selected1.Location = new System.Drawing.Point(0, 0);
            this.pnl_selected1.Name = "pnl_selected1";
            this.pnl_selected1.Size = new System.Drawing.Size(10, 100);
            this.pnl_selected1.TabIndex = 1;
            // 
            // btn_dados
            // 
            this.btn_dados.FlatAppearance.BorderSize = 0;
            this.btn_dados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dados.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_dados.Location = new System.Drawing.Point(3, 0);
            this.btn_dados.Name = "btn_dados";
            this.btn_dados.Size = new System.Drawing.Size(182, 100);
            this.btn_dados.TabIndex = 0;
            this.btn_dados.Text = "Dados Pessoais";
            this.btn_dados.UseVisualStyleBackColor = true;
            this.btn_dados.Click += new System.EventHandler(this.btn_dados_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.pnl_top.Controls.Add(this.lbl_horas);
            this.pnl_top.Controls.Add(this.lbl_abertofechado);
            this.pnl_top.Controls.Add(this.lbl_nome);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Controls.Add(this.lbl_name);
            this.pnl_top.Controls.Add(this.pic_close);
            this.pnl_top.Controls.Add(this.pic_logo);
            this.pnl_top.Controls.Add(this.pic_minimize);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1045, 51);
            this.pnl_top.TabIndex = 71;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            // 
            // lbl_horas
            // 
            this.lbl_horas.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_horas.Location = new System.Drawing.Point(822, 28);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(139, 23);
            this.lbl_horas.TabIndex = 104;
            this.lbl_horas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_abertofechado
            // 
            this.lbl_abertofechado.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_abertofechado.ForeColor = System.Drawing.Color.Red;
            this.lbl_abertofechado.Location = new System.Drawing.Point(823, 3);
            this.lbl_abertofechado.Name = "lbl_abertofechado";
            this.lbl_abertofechado.Size = new System.Drawing.Size(136, 23);
            this.lbl_abertofechado.TabIndex = 105;
            this.lbl_abertofechado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nome
            // 
            this.lbl_nome.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_nome.Location = new System.Drawing.Point(647, 15);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(312, 22);
            this.lbl_nome.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(470, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 103;
            this.label1.Text = "ÁREA DE CLIENTE";
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
            // tmr_data
            // 
            this.tmr_data.Enabled = true;
            this.tmr_data.Interval = 1000;
            this.tmr_data.Tick += new System.EventHandler(this.tmr_data_Tick);
            // 
            // pic_close
            // 
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Image = global::Proj_M14_BrunoPinheiro.Properties.Resources.close;
            this.pic_close.Location = new System.Drawing.Point(1015, 16);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(18, 18);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 99;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click_1);
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
            this.pic_minimize.Location = new System.Drawing.Point(980, 16);
            this.pic_minimize.Name = "pic_minimize";
            this.pic_minimize.Size = new System.Drawing.Size(18, 18);
            this.pic_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minimize.TabIndex = 100;
            this.pic_minimize.TabStop = false;
            this.pic_minimize.Click += new System.EventHandler(this.pic_minimize_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_logout.Location = new System.Drawing.Point(0, 300);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(185, 96);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // frm_areacliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1045, 516);
            this.Controls.Add(this.pnl_fundo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_areacliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Lock - Área de Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_areacliente_FormClosed);
            this.Load += new System.EventHandler(this.frm_areacliente_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_modalidades.ResumeLayout(false);
            this.pnl_treinadores.ResumeLayout(false);
            this.pnl_socios.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_fundo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_modalidades;
        private System.Windows.Forms.Panel pnl_selected3;
        private System.Windows.Forms.Button btn_modalidades;
        private System.Windows.Forms.Panel pnl_treinadores;
        private System.Windows.Forms.Panel pnl_selected2;
        private System.Windows.Forms.Button btn_quotas;
        private System.Windows.Forms.Panel pnl_socios;
        private System.Windows.Forms.Panel pnl_selected1;
        private System.Windows.Forms.Button btn_dados;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_abertofechado;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.Timer tmr_data;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_logout;
    }
}