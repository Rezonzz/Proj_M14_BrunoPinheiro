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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_administracao));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_abertofechado = new System.Windows.Forms.Label();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_instalacoes = new System.Windows.Forms.Button();
            this.pnl_ginastica = new System.Windows.Forms.Panel();
            this.pnl_instalacoes = new System.Windows.Forms.Panel();
            this.btn_turmas = new System.Windows.Forms.Button();
            this.pnl_modalidades = new System.Windows.Forms.Panel();
            this.btn_modalidades = new System.Windows.Forms.Button();
            this.pnl_treinadores = new System.Windows.Forms.Panel();
            this.btn_treinadores = new System.Windows.Forms.Button();
            this.pnl_socios = new System.Windows.Forms.Panel();
            this.btn_socios = new System.Windows.Forms.Button();
            this.pnl_fundo = new System.Windows.Forms.Panel();
            this.tmr_data = new System.Windows.Forms.Timer(this.components);
            this.pnl_selected1 = new System.Windows.Forms.Panel();
            this.pnl_selected2 = new System.Windows.Forms.Panel();
            this.pnl_selected3 = new System.Windows.Forms.Panel();
            this.pnl_selected4 = new System.Windows.Forms.Panel();
            this.pnl_selected5 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnl_selected6 = new System.Windows.Forms.Panel();
            this.btn_quotas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_selected7 = new System.Windows.Forms.Panel();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnl_selected8 = new System.Windows.Forms.Panel();
            this.btn_reservas = new System.Windows.Forms.Button();
            this.pic_ginastica = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.pnl_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_ginastica.SuspendLayout();
            this.pnl_instalacoes.SuspendLayout();
            this.pnl_modalidades.SuspendLayout();
            this.pnl_treinadores.SuspendLayout();
            this.pnl_socios.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ginastica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.pnl_top.Controls.Add(this.lbl_abertofechado);
            this.pnl_top.Controls.Add(this.lbl_horas);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Controls.Add(this.lbl_name);
            this.pnl_top.Controls.Add(this.pic_close);
            this.pnl_top.Controls.Add(this.pic_logo);
            this.pnl_top.Controls.Add(this.pic_minimize);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1045, 51);
            this.pnl_top.TabIndex = 67;
            this.pnl_top.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_top_Paint);
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
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
            this.lbl_abertofechado.Click += new System.EventHandler(this.lbl_abertofechado_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(470, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 103;
            this.label1.Text = "ADMINISTRADOR";
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnl_ginastica);
            this.panel1.Controls.Add(this.pnl_instalacoes);
            this.panel1.Controls.Add(this.pnl_modalidades);
            this.panel1.Controls.Add(this.pnl_treinadores);
            this.panel1.Controls.Add(this.pnl_socios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 465);
            this.panel1.TabIndex = 69;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_selected5);
            this.panel2.Controls.Add(this.btn_instalacoes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 100);
            this.panel2.TabIndex = 7;
            // 
            // btn_instalacoes
            // 
            this.btn_instalacoes.FlatAppearance.BorderSize = 0;
            this.btn_instalacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_instalacoes.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instalacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_instalacoes.Location = new System.Drawing.Point(3, -1);
            this.btn_instalacoes.Name = "btn_instalacoes";
            this.btn_instalacoes.Size = new System.Drawing.Size(165, 101);
            this.btn_instalacoes.TabIndex = 1;
            this.btn_instalacoes.Text = "Instalações";
            this.btn_instalacoes.UseVisualStyleBackColor = true;
            this.btn_instalacoes.Click += new System.EventHandler(this.btn_instalacoes_Click);
            // 
            // pnl_ginastica
            // 
            this.pnl_ginastica.Controls.Add(this.pic_ginastica);
            this.pnl_ginastica.Enabled = false;
            this.pnl_ginastica.Location = new System.Drawing.Point(0, 2586);
            this.pnl_ginastica.Name = "pnl_ginastica";
            this.pnl_ginastica.Size = new System.Drawing.Size(165, 97);
            this.pnl_ginastica.TabIndex = 6;
            this.pnl_ginastica.Visible = false;
            // 
            // pnl_instalacoes
            // 
            this.pnl_instalacoes.Controls.Add(this.pnl_selected4);
            this.pnl_instalacoes.Controls.Add(this.btn_turmas);
            this.pnl_instalacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_instalacoes.Location = new System.Drawing.Point(0, 300);
            this.pnl_instalacoes.Name = "pnl_instalacoes";
            this.pnl_instalacoes.Size = new System.Drawing.Size(168, 100);
            this.pnl_instalacoes.TabIndex = 3;
            // 
            // btn_turmas
            // 
            this.btn_turmas.FlatAppearance.BorderSize = 0;
            this.btn_turmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_turmas.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_turmas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_turmas.Location = new System.Drawing.Point(2, 1);
            this.btn_turmas.Name = "btn_turmas";
            this.btn_turmas.Size = new System.Drawing.Size(165, 98);
            this.btn_turmas.TabIndex = 7;
            this.btn_turmas.Text = "Turmas";
            this.btn_turmas.UseVisualStyleBackColor = true;
            this.btn_turmas.Click += new System.EventHandler(this.btn_turmas_Click);
            // 
            // pnl_modalidades
            // 
            this.pnl_modalidades.Controls.Add(this.pnl_selected3);
            this.pnl_modalidades.Controls.Add(this.btn_modalidades);
            this.pnl_modalidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_modalidades.Location = new System.Drawing.Point(0, 200);
            this.pnl_modalidades.Name = "pnl_modalidades";
            this.pnl_modalidades.Size = new System.Drawing.Size(168, 100);
            this.pnl_modalidades.TabIndex = 2;
            // 
            // btn_modalidades
            // 
            this.btn_modalidades.FlatAppearance.BorderSize = 0;
            this.btn_modalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modalidades.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modalidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_modalidades.Location = new System.Drawing.Point(3, 2);
            this.btn_modalidades.Name = "btn_modalidades";
            this.btn_modalidades.Size = new System.Drawing.Size(165, 98);
            this.btn_modalidades.TabIndex = 1;
            this.btn_modalidades.Text = "Modalidades";
            this.btn_modalidades.UseVisualStyleBackColor = true;
            this.btn_modalidades.Click += new System.EventHandler(this.btn_modalidades_Click);
            // 
            // pnl_treinadores
            // 
            this.pnl_treinadores.Controls.Add(this.pnl_selected2);
            this.pnl_treinadores.Controls.Add(this.btn_treinadores);
            this.pnl_treinadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_treinadores.Location = new System.Drawing.Point(0, 100);
            this.pnl_treinadores.Name = "pnl_treinadores";
            this.pnl_treinadores.Size = new System.Drawing.Size(168, 100);
            this.pnl_treinadores.TabIndex = 1;
            // 
            // btn_treinadores
            // 
            this.btn_treinadores.FlatAppearance.BorderSize = 0;
            this.btn_treinadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_treinadores.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_treinadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_treinadores.Location = new System.Drawing.Point(3, 2);
            this.btn_treinadores.Name = "btn_treinadores";
            this.btn_treinadores.Size = new System.Drawing.Size(165, 98);
            this.btn_treinadores.TabIndex = 1;
            this.btn_treinadores.Text = "Treinadores";
            this.btn_treinadores.UseVisualStyleBackColor = true;
            this.btn_treinadores.Click += new System.EventHandler(this.btn_treinadores_Click);
            // 
            // pnl_socios
            // 
            this.pnl_socios.Controls.Add(this.pnl_selected1);
            this.pnl_socios.Controls.Add(this.btn_socios);
            this.pnl_socios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_socios.Location = new System.Drawing.Point(0, 0);
            this.pnl_socios.Name = "pnl_socios";
            this.pnl_socios.Size = new System.Drawing.Size(168, 100);
            this.pnl_socios.TabIndex = 0;
            // 
            // btn_socios
            // 
            this.btn_socios.FlatAppearance.BorderSize = 0;
            this.btn_socios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_socios.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_socios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_socios.Location = new System.Drawing.Point(3, 0);
            this.btn_socios.Name = "btn_socios";
            this.btn_socios.Size = new System.Drawing.Size(165, 100);
            this.btn_socios.TabIndex = 0;
            this.btn_socios.Text = "Sócios";
            this.btn_socios.UseVisualStyleBackColor = true;
            this.btn_socios.Click += new System.EventHandler(this.btn_socios_Click);
            // 
            // pnl_fundo
            // 
            this.pnl_fundo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_fundo.Location = new System.Drawing.Point(185, 51);
            this.pnl_fundo.Name = "pnl_fundo";
            this.pnl_fundo.Size = new System.Drawing.Size(860, 465);
            this.pnl_fundo.TabIndex = 70;
            // 
            // tmr_data
            // 
            this.tmr_data.Enabled = true;
            this.tmr_data.Interval = 1000;
            this.tmr_data.Tick += new System.EventHandler(this.tmr_data_Tick);
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
            // pnl_selected4
            // 
            this.pnl_selected4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(81)))));
            this.pnl_selected4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_selected4.Enabled = false;
            this.pnl_selected4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pnl_selected4.Location = new System.Drawing.Point(0, 0);
            this.pnl_selected4.Name = "pnl_selected4";
            this.pnl_selected4.Size = new System.Drawing.Size(10, 100);
            this.pnl_selected4.TabIndex = 8;
            this.pnl_selected4.Visible = false;
            // 
            // pnl_selected5
            // 
            this.pnl_selected5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(81)))));
            this.pnl_selected5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_selected5.Enabled = false;
            this.pnl_selected5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pnl_selected5.Location = new System.Drawing.Point(0, 0);
            this.pnl_selected5.Name = "pnl_selected5";
            this.pnl_selected5.Size = new System.Drawing.Size(10, 100);
            this.pnl_selected5.TabIndex = 2;
            this.pnl_selected5.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnl_selected6);
            this.panel5.Controls.Add(this.btn_quotas);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 500);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(168, 100);
            this.panel5.TabIndex = 9;
            // 
            // pnl_selected6
            // 
            this.pnl_selected6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(81)))));
            this.pnl_selected6.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_selected6.Enabled = false;
            this.pnl_selected6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pnl_selected6.Location = new System.Drawing.Point(0, 0);
            this.pnl_selected6.Name = "pnl_selected6";
            this.pnl_selected6.Size = new System.Drawing.Size(10, 100);
            this.pnl_selected6.TabIndex = 2;
            this.pnl_selected6.Visible = false;
            // 
            // btn_quotas
            // 
            this.btn_quotas.FlatAppearance.BorderSize = 0;
            this.btn_quotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quotas.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_quotas.Location = new System.Drawing.Point(3, -1);
            this.btn_quotas.Name = "btn_quotas";
            this.btn_quotas.Size = new System.Drawing.Size(165, 101);
            this.btn_quotas.TabIndex = 1;
            this.btn_quotas.Text = "Quotas";
            this.btn_quotas.UseVisualStyleBackColor = true;
            this.btn_quotas.Click += new System.EventHandler(this.btn_quotas_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnl_selected7);
            this.panel3.Controls.Add(this.btn_consultas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 600);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 100);
            this.panel3.TabIndex = 9;
            // 
            // pnl_selected7
            // 
            this.pnl_selected7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(81)))));
            this.pnl_selected7.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_selected7.Enabled = false;
            this.pnl_selected7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pnl_selected7.Location = new System.Drawing.Point(0, 0);
            this.pnl_selected7.Name = "pnl_selected7";
            this.pnl_selected7.Size = new System.Drawing.Size(10, 100);
            this.pnl_selected7.TabIndex = 2;
            this.pnl_selected7.Visible = false;
            // 
            // btn_consultas
            // 
            this.btn_consultas.FlatAppearance.BorderSize = 0;
            this.btn_consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultas.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_consultas.Location = new System.Drawing.Point(3, 0);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(165, 100);
            this.btn_consultas.TabIndex = 1;
            this.btn_consultas.Text = "Consultas";
            this.btn_consultas.UseVisualStyleBackColor = true;
            this.btn_consultas.Click += new System.EventHandler(this.btn_consultas_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnl_selected8);
            this.panel7.Controls.Add(this.btn_reservas);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 700);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(168, 100);
            this.panel7.TabIndex = 10;
            // 
            // pnl_selected8
            // 
            this.pnl_selected8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(81)))));
            this.pnl_selected8.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_selected8.Enabled = false;
            this.pnl_selected8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pnl_selected8.Location = new System.Drawing.Point(0, 0);
            this.pnl_selected8.Name = "pnl_selected8";
            this.pnl_selected8.Size = new System.Drawing.Size(10, 100);
            this.pnl_selected8.TabIndex = 2;
            this.pnl_selected8.Visible = false;
            // 
            // btn_reservas
            // 
            this.btn_reservas.FlatAppearance.BorderSize = 0;
            this.btn_reservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservas.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_reservas.Location = new System.Drawing.Point(3, 0);
            this.btn_reservas.Name = "btn_reservas";
            this.btn_reservas.Size = new System.Drawing.Size(165, 100);
            this.btn_reservas.TabIndex = 1;
            this.btn_reservas.Text = "Reservas";
            this.btn_reservas.UseVisualStyleBackColor = true;
            this.btn_reservas.Click += new System.EventHandler(this.btn_reservas_Click);
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
            this.pic_minimize.Location = new System.Drawing.Point(980, 16);
            this.pic_minimize.Name = "pic_minimize";
            this.pic_minimize.Size = new System.Drawing.Size(18, 18);
            this.pic_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minimize.TabIndex = 100;
            this.pic_minimize.TabStop = false;
            this.pic_minimize.Click += new System.EventHandler(this.pic_minimize_Click);
            // 
            // frm_administracao
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
            this.Name = "frm_administracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Lock - Administração";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_administracao_FormClosed);
            this.Load += new System.EventHandler(this.frm_administracao_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_ginastica.ResumeLayout(false);
            this.pnl_instalacoes.ResumeLayout(false);
            this.pnl_modalidades.ResumeLayout(false);
            this.pnl_treinadores.ResumeLayout(false);
            this.pnl_socios.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ginastica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
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
        private System.Windows.Forms.Panel pnl_instalacoes;
        private System.Windows.Forms.Panel pnl_modalidades;
        private System.Windows.Forms.Panel pnl_treinadores;
        private System.Windows.Forms.Panel pnl_socios;
        private System.Windows.Forms.Button btn_socios;
        private System.Windows.Forms.Button btn_instalacoes;
        private System.Windows.Forms.Button btn_modalidades;
        private System.Windows.Forms.Button btn_treinadores;
        private System.Windows.Forms.Panel pnl_fundo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_abertofechado;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.Timer tmr_data;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_turmas;
        private System.Windows.Forms.Panel pnl_selected1;
        private System.Windows.Forms.Panel pnl_selected5;
        private System.Windows.Forms.Panel pnl_selected4;
        private System.Windows.Forms.Panel pnl_selected3;
        private System.Windows.Forms.Panel pnl_selected2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnl_selected6;
        private System.Windows.Forms.Button btn_quotas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_selected7;
        private System.Windows.Forms.Button btn_consultas;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnl_selected8;
        private System.Windows.Forms.Button btn_reservas;
    }
}