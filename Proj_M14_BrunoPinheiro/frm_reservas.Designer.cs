namespace Proj_M14_BrunoPinheiro
{
    partial class frm_reservas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reservas));
            this.txt_totalsocios = new System.Windows.Forms.TextBox();
            this.lbl_datareserva = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_detalhereserva = new System.Windows.Forms.DataGridView();
            this.txt_idturma = new System.Windows.Forms.TextBox();
            this.cbo_diasemana = new System.Windows.Forms.ComboBox();
            this.lbl_socio = new System.Windows.Forms.Label();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.pic_username = new System.Windows.Forms.PictureBox();
            this.cbo_instalacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_fim = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_efetuar = new System.Windows.Forms.Button();
            this.btn_concluir = new System.Windows.Forms.Button();
            this.dgv_ocupacao = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtp_nasc = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fim = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalhereserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ocupacao)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_totalsocios
            // 
            this.txt_totalsocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.txt_totalsocios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_totalsocios.Enabled = false;
            this.txt_totalsocios.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalsocios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.txt_totalsocios.Location = new System.Drawing.Point(517, 23);
            this.txt_totalsocios.Multiline = true;
            this.txt_totalsocios.Name = "txt_totalsocios";
            this.txt_totalsocios.Size = new System.Drawing.Size(38, 27);
            this.txt_totalsocios.TabIndex = 302;
            this.txt_totalsocios.Visible = false;
            this.txt_totalsocios.TextChanged += new System.EventHandler(this.txt_totalsocios_TextChanged);
            // 
            // lbl_datareserva
            // 
            this.lbl_datareserva.AutoSize = true;
            this.lbl_datareserva.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datareserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_datareserva.Location = new System.Drawing.Point(322, 12);
            this.lbl_datareserva.Name = "lbl_datareserva";
            this.lbl_datareserva.Size = new System.Drawing.Size(130, 17);
            this.lbl_datareserva.TabIndex = 294;
            this.lbl_datareserva.Text = "Data de Reserva";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel6.Location = new System.Drawing.Point(283, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 1);
            this.panel6.TabIndex = 293;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proj_M14_BrunoPinheiro.Properties.Resources.calendario;
            this.pictureBox1.Location = new System.Drawing.Point(283, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 292;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_detalhereserva
            // 
            this.dgv_detalhereserva.AllowUserToAddRows = false;
            this.dgv_detalhereserva.AllowUserToDeleteRows = false;
            this.dgv_detalhereserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_detalhereserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_detalhereserva.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.dgv_detalhereserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_detalhereserva.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_detalhereserva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalhereserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_detalhereserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detalhereserva.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_detalhereserva.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dgv_detalhereserva.Location = new System.Drawing.Point(17, 158);
            this.dgv_detalhereserva.Name = "dgv_detalhereserva";
            this.dgv_detalhereserva.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalhereserva.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dgv_detalhereserva.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_detalhereserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalhereserva.Size = new System.Drawing.Size(820, 95);
            this.dgv_detalhereserva.TabIndex = 291;
            // 
            // txt_idturma
            // 
            this.txt_idturma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.txt_idturma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idturma.Enabled = false;
            this.txt_idturma.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idturma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.txt_idturma.Location = new System.Drawing.Point(284, 96);
            this.txt_idturma.Multiline = true;
            this.txt_idturma.Name = "txt_idturma";
            this.txt_idturma.Size = new System.Drawing.Size(38, 27);
            this.txt_idturma.TabIndex = 289;
            this.txt_idturma.Visible = false;
            // 
            // cbo_diasemana
            // 
            this.cbo_diasemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.cbo_diasemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_diasemana.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_diasemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.cbo_diasemana.FormattingEnabled = true;
            this.cbo_diasemana.Items.AddRange(new object[] {
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sábado",
            "Domingo"});
            this.cbo_diasemana.Location = new System.Drawing.Point(59, 32);
            this.cbo_diasemana.Name = "cbo_diasemana";
            this.cbo_diasemana.Size = new System.Drawing.Size(193, 23);
            this.cbo_diasemana.TabIndex = 286;
            // 
            // lbl_socio
            // 
            this.lbl_socio.AutoSize = true;
            this.lbl_socio.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_socio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_socio.Location = new System.Drawing.Point(55, 12);
            this.lbl_socio.Name = "lbl_socio";
            this.lbl_socio.Size = new System.Drawing.Size(47, 17);
            this.lbl_socio.TabIndex = 271;
            this.lbl_socio.Text = "Sócio";
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.pnl_1.Location = new System.Drawing.Point(16, 65);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(234, 1);
            this.pnl_1.TabIndex = 270;
            // 
            // pic_username
            // 
            this.pic_username.Image = global::Proj_M14_BrunoPinheiro.Properties.Resources.user;
            this.pic_username.Location = new System.Drawing.Point(16, 23);
            this.pic_username.Name = "pic_username";
            this.pic_username.Size = new System.Drawing.Size(37, 36);
            this.pic_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_username.TabIndex = 269;
            this.pic_username.TabStop = false;
            // 
            // cbo_instalacao
            // 
            this.cbo_instalacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.cbo_instalacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_instalacao.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_instalacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.cbo_instalacao.FormattingEnabled = true;
            this.cbo_instalacao.Location = new System.Drawing.Point(57, 94);
            this.cbo_instalacao.Name = "cbo_instalacao";
            this.cbo_instalacao.Size = new System.Drawing.Size(193, 23);
            this.cbo_instalacao.TabIndex = 306;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(54, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 305;
            this.label3.Text = "Instalação";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel1.Location = new System.Drawing.Point(15, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 304;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proj_M14_BrunoPinheiro.Properties.Resources.campo_de_futebol;
            this.pictureBox2.Location = new System.Drawing.Point(15, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 303;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_inicio.Location = new System.Drawing.Point(298, 76);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(85, 17);
            this.lbl_inicio.TabIndex = 309;
            this.lbl_inicio.Text = "Hora Ínicio";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel3.Location = new System.Drawing.Point(282, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 1);
            this.panel3.TabIndex = 308;
            // 
            // lbl_fim
            // 
            this.lbl_fim.AutoSize = true;
            this.lbl_fim.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_fim.Location = new System.Drawing.Point(427, 76);
            this.lbl_fim.Name = "lbl_fim";
            this.lbl_fim.Size = new System.Drawing.Size(73, 17);
            this.lbl_fim.TabIndex = 312;
            this.lbl_fim.Text = "Hora Fim";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel8.Location = new System.Drawing.Point(413, 129);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(110, 1);
            this.panel8.TabIndex = 311;
            // 
            // btn_efetuar
            // 
            this.btn_efetuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_efetuar.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_efetuar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_efetuar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_efetuar.Location = new System.Drawing.Point(572, 56);
            this.btn_efetuar.Name = "btn_efetuar";
            this.btn_efetuar.Size = new System.Drawing.Size(239, 37);
            this.btn_efetuar.TabIndex = 313;
            this.btn_efetuar.Text = "Efetuar Reserva";
            this.btn_efetuar.UseVisualStyleBackColor = true;
            // 
            // btn_concluir
            // 
            this.btn_concluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_concluir.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_concluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_concluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_concluir.Location = new System.Drawing.Point(17, 253);
            this.btn_concluir.Name = "btn_concluir";
            this.btn_concluir.Size = new System.Drawing.Size(820, 37);
            this.btn_concluir.TabIndex = 314;
            this.btn_concluir.Text = "Concluir Reserva";
            this.btn_concluir.UseVisualStyleBackColor = true;
            // 
            // dgv_ocupacao
            // 
            this.dgv_ocupacao.AllowUserToAddRows = false;
            this.dgv_ocupacao.AllowUserToDeleteRows = false;
            this.dgv_ocupacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ocupacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ocupacao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.dgv_ocupacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ocupacao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_ocupacao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ocupacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ocupacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ocupacao.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ocupacao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dgv_ocupacao.Location = new System.Drawing.Point(10, 312);
            this.dgv_ocupacao.Name = "dgv_ocupacao";
            this.dgv_ocupacao.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ocupacao.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dgv_ocupacao.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_ocupacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ocupacao.Size = new System.Drawing.Size(836, 144);
            this.dgv_ocupacao.TabIndex = 315;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel2.Location = new System.Drawing.Point(13, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 1);
            this.panel2.TabIndex = 316;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel4.Location = new System.Drawing.Point(12, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(831, 1);
            this.panel4.TabIndex = 317;
            // 
            // dtp_nasc
            // 
            this.dtp_nasc.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_nasc.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.dtp_nasc.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.dtp_nasc.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_nasc.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_nasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nasc.Location = new System.Drawing.Point(328, 33);
            this.dtp_nasc.Name = "dtp_nasc";
            this.dtp_nasc.Size = new System.Drawing.Size(191, 20);
            this.dtp_nasc.TabIndex = 318;
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CalendarFont = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_inicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.dtp_inicio.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_inicio.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_inicio.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_inicio.CustomFormat = "HH:mm";
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inicio.Location = new System.Drawing.Point(284, 100);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.ShowUpDown = true;
            this.dtp_inicio.Size = new System.Drawing.Size(108, 20);
            this.dtp_inicio.TabIndex = 319;
            this.dtp_inicio.Value = new System.DateTime(2023, 4, 4, 0, 0, 0, 0);
            // 
            // dtp_fim
            // 
            this.dtp_fim.CalendarFont = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fim.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_fim.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.dtp_fim.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_fim.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_fim.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_fim.CustomFormat = "HH:mm";
            this.dtp_fim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fim.Location = new System.Drawing.Point(414, 101);
            this.dtp_fim.Name = "dtp_fim";
            this.dtp_fim.ShowUpDown = true;
            this.dtp_fim.Size = new System.Drawing.Size(108, 20);
            this.dtp_fim.TabIndex = 320;
            this.dtp_fim.Value = new System.DateTime(2023, 4, 4, 0, 0, 0, 0);
            // 
            // frm_reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(860, 465);
            this.Controls.Add(this.dtp_fim);
            this.Controls.Add(this.dtp_inicio);
            this.Controls.Add(this.dtp_nasc);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_ocupacao);
            this.Controls.Add(this.btn_concluir);
            this.Controls.Add(this.btn_efetuar);
            this.Controls.Add(this.lbl_fim);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lbl_inicio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbo_instalacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_totalsocios);
            this.Controls.Add(this.lbl_datareserva);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_detalhereserva);
            this.Controls.Add(this.txt_idturma);
            this.Controls.Add(this.cbo_diasemana);
            this.Controls.Add(this.lbl_socio);
            this.Controls.Add(this.pnl_1);
            this.Controls.Add(this.pic_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_reservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Lock - Reservas";
            this.Load += new System.EventHandler(this.frm_reservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalhereserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ocupacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_totalsocios;
        private System.Windows.Forms.Label lbl_datareserva;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_detalhereserva;
        private System.Windows.Forms.TextBox txt_idturma;
        private System.Windows.Forms.ComboBox cbo_diasemana;
        private System.Windows.Forms.Label lbl_socio;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.PictureBox pic_username;
        private System.Windows.Forms.ComboBox cbo_instalacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_fim;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_efetuar;
        private System.Windows.Forms.Button btn_concluir;
        private System.Windows.Forms.DataGridView dgv_ocupacao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtp_nasc;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fim;
    }
}