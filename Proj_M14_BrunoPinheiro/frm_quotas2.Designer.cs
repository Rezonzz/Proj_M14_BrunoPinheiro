namespace Proj_M14_BrunoPinheiro
{
    partial class frm_quotas2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_quotas2));
            this.dtp_quota = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_dataquota = new System.Windows.Forms.Label();
            this.lbl_idsocio = new System.Windows.Forms.Label();
            this.lbl_datapagamento = new System.Windows.Forms.Label();
            this.lbl_datapag = new System.Windows.Forms.Label();
            this.btn_pagarquota = new System.Windows.Forms.Button();
            this.lbl_quota = new System.Windows.Forms.Label();
            this.lbl_vq = new System.Windows.Forms.Label();
            this.lbl_socio = new System.Windows.Forms.Label();
            this.lbl_soc = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_meses = new System.Windows.Forms.DataGridView();
            this.Janeiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fevereiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Março = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abril = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Junho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Julho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Novembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dezembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_quotas = new System.Windows.Forms.DataGridView();
            this.lbl_inscricao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_meses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_quota
            // 
            this.dtp_quota.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_quota.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.dtp_quota.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.dtp_quota.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_quota.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dtp_quota.CustomFormat = "MM/yyyy";
            this.dtp_quota.Enabled = false;
            this.dtp_quota.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_quota.Location = new System.Drawing.Point(285, 424);
            this.dtp_quota.Name = "dtp_quota";
            this.dtp_quota.ShowUpDown = true;
            this.dtp_quota.Size = new System.Drawing.Size(191, 20);
            this.dtp_quota.TabIndex = 352;
            this.dtp_quota.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(145, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 351;
            this.label2.Text = "€";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // lbl_dataquota
            // 
            this.lbl_dataquota.AutoSize = true;
            this.lbl_dataquota.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataquota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_dataquota.Location = new System.Drawing.Point(316, 394);
            this.lbl_dataquota.Name = "lbl_dataquota";
            this.lbl_dataquota.Size = new System.Drawing.Size(126, 18);
            this.lbl_dataquota.TabIndex = 350;
            this.lbl_dataquota.Text = "Data da Quota";
            this.lbl_dataquota.Visible = false;
            // 
            // lbl_idsocio
            // 
            this.lbl_idsocio.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idsocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_idsocio.Location = new System.Drawing.Point(671, 325);
            this.lbl_idsocio.Name = "lbl_idsocio";
            this.lbl_idsocio.Size = new System.Drawing.Size(40, 23);
            this.lbl_idsocio.TabIndex = 349;
            this.lbl_idsocio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_idsocio.Visible = false;
            // 
            // lbl_datapagamento
            // 
            this.lbl_datapagamento.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datapagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_datapagamento.Location = new System.Drawing.Point(261, 352);
            this.lbl_datapagamento.Name = "lbl_datapagamento";
            this.lbl_datapagamento.Size = new System.Drawing.Size(237, 23);
            this.lbl_datapagamento.TabIndex = 348;
            this.lbl_datapagamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_datapagamento.Visible = false;
            // 
            // lbl_datapag
            // 
            this.lbl_datapag.AutoSize = true;
            this.lbl_datapag.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datapag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_datapag.Location = new System.Drawing.Point(300, 325);
            this.lbl_datapag.Name = "lbl_datapag";
            this.lbl_datapag.Size = new System.Drawing.Size(170, 18);
            this.lbl_datapag.TabIndex = 347;
            this.lbl_datapag.Text = "Data de Pagamento";
            this.lbl_datapag.Visible = false;
            // 
            // btn_pagarquota
            // 
            this.btn_pagarquota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagarquota.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagarquota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_pagarquota.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pagarquota.Location = new System.Drawing.Point(558, 363);
            this.btn_pagarquota.Name = "btn_pagarquota";
            this.btn_pagarquota.Size = new System.Drawing.Size(239, 37);
            this.btn_pagarquota.TabIndex = 346;
            this.btn_pagarquota.Text = "Pagar quota";
            this.btn_pagarquota.UseVisualStyleBackColor = true;
            this.btn_pagarquota.Click += new System.EventHandler(this.btn_pagarquota_Click);
            // 
            // lbl_quota
            // 
            this.lbl_quota.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_quota.Location = new System.Drawing.Point(63, 423);
            this.lbl_quota.Name = "lbl_quota";
            this.lbl_quota.Size = new System.Drawing.Size(147, 23);
            this.lbl_quota.TabIndex = 345;
            this.lbl_quota.Text = "10";
            this.lbl_quota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_quota.Visible = false;
            // 
            // lbl_vq
            // 
            this.lbl_vq.AutoSize = true;
            this.lbl_vq.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_vq.Location = new System.Drawing.Point(75, 394);
            this.lbl_vq.Name = "lbl_vq";
            this.lbl_vq.Size = new System.Drawing.Size(129, 18);
            this.lbl_vq.TabIndex = 344;
            this.lbl_vq.Text = "Valor da Quota";
            this.lbl_vq.Visible = false;
            // 
            // lbl_socio
            // 
            this.lbl_socio.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_socio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_socio.Location = new System.Drawing.Point(19, 352);
            this.lbl_socio.Name = "lbl_socio";
            this.lbl_socio.Size = new System.Drawing.Size(237, 23);
            this.lbl_socio.TabIndex = 343;
            this.lbl_socio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_socio.Visible = false;
            // 
            // lbl_soc
            // 
            this.lbl_soc.AutoSize = true;
            this.lbl_soc.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_soc.Location = new System.Drawing.Point(114, 325);
            this.lbl_soc.Name = "lbl_soc";
            this.lbl_soc.Size = new System.Drawing.Size(49, 18);
            this.lbl_soc.TabIndex = 342;
            this.lbl_soc.Text = "Sócio";
            this.lbl_soc.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel4.Location = new System.Drawing.Point(17, 196);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(831, 1);
            this.panel4.TabIndex = 341;
            // 
            // dgv_meses
            // 
            this.dgv_meses.AllowUserToAddRows = false;
            this.dgv_meses.AllowUserToDeleteRows = false;
            this.dgv_meses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_meses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_meses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.dgv_meses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_meses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_meses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_meses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_meses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_meses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Janeiro,
            this.Fevereiro,
            this.Março,
            this.Abril,
            this.Maio,
            this.Junho,
            this.Julho,
            this.Agosto,
            this.Setembro,
            this.Outubro,
            this.Novembro,
            this.Dezembro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_meses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_meses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dgv_meses.Location = new System.Drawing.Point(12, 209);
            this.dgv_meses.Name = "dgv_meses";
            this.dgv_meses.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_meses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dgv_meses.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_meses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_meses.Size = new System.Drawing.Size(836, 97);
            this.dgv_meses.TabIndex = 340;
            this.dgv_meses.SelectionChanged += new System.EventHandler(this.dgv_meses_SelectionChanged);
            // 
            // Janeiro
            // 
            this.Janeiro.HeaderText = "Janeiro";
            this.Janeiro.Name = "Janeiro";
            this.Janeiro.ReadOnly = true;
            this.Janeiro.Width = 92;
            // 
            // Fevereiro
            // 
            this.Fevereiro.HeaderText = "Fevereiro";
            this.Fevereiro.Name = "Fevereiro";
            this.Fevereiro.ReadOnly = true;
            this.Fevereiro.Width = 110;
            // 
            // Março
            // 
            this.Março.HeaderText = "Março";
            this.Março.Name = "Março";
            this.Março.ReadOnly = true;
            this.Março.Width = 81;
            // 
            // Abril
            // 
            this.Abril.HeaderText = "Abril";
            this.Abril.Name = "Abril";
            this.Abril.ReadOnly = true;
            this.Abril.Width = 69;
            // 
            // Maio
            // 
            this.Maio.HeaderText = "Maio";
            this.Maio.Name = "Maio";
            this.Maio.ReadOnly = true;
            this.Maio.Width = 70;
            // 
            // Junho
            // 
            this.Junho.HeaderText = "Junho";
            this.Junho.Name = "Junho";
            this.Junho.ReadOnly = true;
            this.Junho.Width = 81;
            // 
            // Julho
            // 
            this.Julho.HeaderText = "Julho";
            this.Julho.Name = "Julho";
            this.Julho.ReadOnly = true;
            this.Julho.Width = 75;
            // 
            // Agosto
            // 
            this.Agosto.HeaderText = "Agosto";
            this.Agosto.Name = "Agosto";
            this.Agosto.ReadOnly = true;
            this.Agosto.Width = 91;
            // 
            // Setembro
            // 
            this.Setembro.HeaderText = "Setembro";
            this.Setembro.Name = "Setembro";
            this.Setembro.ReadOnly = true;
            this.Setembro.Width = 112;
            // 
            // Outubro
            // 
            this.Outubro.HeaderText = "Outubro";
            this.Outubro.Name = "Outubro";
            this.Outubro.ReadOnly = true;
            this.Outubro.Width = 99;
            // 
            // Novembro
            // 
            this.Novembro.HeaderText = "Novembro";
            this.Novembro.Name = "Novembro";
            this.Novembro.ReadOnly = true;
            this.Novembro.Width = 116;
            // 
            // Dezembro
            // 
            this.Dezembro.HeaderText = "Dezembro";
            this.Dezembro.Name = "Dezembro";
            this.Dezembro.ReadOnly = true;
            this.Dezembro.Width = 114;
            // 
            // dgv_quotas
            // 
            this.dgv_quotas.AllowUserToAddRows = false;
            this.dgv_quotas.AllowUserToDeleteRows = false;
            this.dgv_quotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_quotas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_quotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.dgv_quotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_quotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_quotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_quotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_quotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_quotas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_quotas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dgv_quotas.Location = new System.Drawing.Point(356, 12);
            this.dgv_quotas.Name = "dgv_quotas";
            this.dgv_quotas.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_quotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dgv_quotas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_quotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_quotas.Size = new System.Drawing.Size(492, 170);
            this.dgv_quotas.TabIndex = 338;
            this.dgv_quotas.SelectionChanged += new System.EventHandler(this.dgv_quotas_SelectionChanged);
            // 
            // lbl_inscricao
            // 
            this.lbl_inscricao.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inscricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_inscricao.Location = new System.Drawing.Point(114, 94);
            this.lbl_inscricao.Name = "lbl_inscricao";
            this.lbl_inscricao.Size = new System.Drawing.Size(147, 23);
            this.lbl_inscricao.TabIndex = 337;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(114, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 336;
            this.label1.Text = "Data de Inscrição";
            // 
            // frm_quotas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(860, 465);
            this.Controls.Add(this.dtp_quota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_dataquota);
            this.Controls.Add(this.lbl_idsocio);
            this.Controls.Add(this.lbl_datapagamento);
            this.Controls.Add(this.lbl_datapag);
            this.Controls.Add(this.btn_pagarquota);
            this.Controls.Add(this.lbl_quota);
            this.Controls.Add(this.lbl_vq);
            this.Controls.Add(this.lbl_socio);
            this.Controls.Add(this.lbl_soc);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgv_meses);
            this.Controls.Add(this.dgv_quotas);
            this.Controls.Add(this.lbl_inscricao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_quotas2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Lock - Quotas";
            this.Load += new System.EventHandler(this.frm_quotas2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_meses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_quota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_dataquota;
        private System.Windows.Forms.Label lbl_idsocio;
        private System.Windows.Forms.Label lbl_datapagamento;
        private System.Windows.Forms.Label lbl_datapag;
        private System.Windows.Forms.Button btn_pagarquota;
        private System.Windows.Forms.Label lbl_quota;
        private System.Windows.Forms.Label lbl_vq;
        private System.Windows.Forms.Label lbl_socio;
        private System.Windows.Forms.Label lbl_soc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_meses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Janeiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fevereiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Março;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abril;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Junho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Julho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setembro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Novembro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dezembro;
        private System.Windows.Forms.DataGridView dgv_quotas;
        private System.Windows.Forms.Label lbl_inscricao;
        private System.Windows.Forms.Label label1;
    }
}