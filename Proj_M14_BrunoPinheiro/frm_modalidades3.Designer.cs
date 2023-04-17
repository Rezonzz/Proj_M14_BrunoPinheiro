namespace Proj_M14_BrunoPinheiro
{
    partial class frm_modalidades3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_modalidades3));
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_desassociar = new System.Windows.Forms.Button();
            this.btn_associar = new System.Windows.Forms.Button();
            this.cbo_modalidade = new System.Windows.Forms.ComboBox();
            this.lbl_modalidade = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_detalhesocio = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalhesocio)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_info
            // 
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_info.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_info.Location = new System.Drawing.Point(12, 17);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(506, 37);
            this.btn_info.TabIndex = 316;
            this.btn_info.Text = "Info - Modalidades Disponíveis";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_desassociar
            // 
            this.btn_desassociar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desassociar.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desassociar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_desassociar.Image = global::Proj_M14_BrunoPinheiro.Properties.Resources.cancel;
            this.btn_desassociar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_desassociar.Location = new System.Drawing.Point(274, 234);
            this.btn_desassociar.Name = "btn_desassociar";
            this.btn_desassociar.Size = new System.Drawing.Size(115, 63);
            this.btn_desassociar.TabIndex = 327;
            this.btn_desassociar.Text = "Desinscrever";
            this.btn_desassociar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_desassociar.UseVisualStyleBackColor = true;
            this.btn_desassociar.Click += new System.EventHandler(this.btn_desassociar_Click);
            // 
            // btn_associar
            // 
            this.btn_associar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_associar.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_associar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btn_associar.Image = global::Proj_M14_BrunoPinheiro.Properties.Resources.add;
            this.btn_associar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_associar.Location = new System.Drawing.Point(152, 234);
            this.btn_associar.Name = "btn_associar";
            this.btn_associar.Size = new System.Drawing.Size(114, 63);
            this.btn_associar.TabIndex = 326;
            this.btn_associar.Text = "Inscrever";
            this.btn_associar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_associar.UseVisualStyleBackColor = true;
            this.btn_associar.Click += new System.EventHandler(this.btn_associar_Click);
            // 
            // cbo_modalidade
            // 
            this.cbo_modalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.cbo_modalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_modalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_modalidade.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_modalidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.cbo_modalidade.FormattingEnabled = true;
            this.cbo_modalidade.Location = new System.Drawing.Point(195, 170);
            this.cbo_modalidade.Name = "cbo_modalidade";
            this.cbo_modalidade.Size = new System.Drawing.Size(193, 23);
            this.cbo_modalidade.TabIndex = 321;
            // 
            // lbl_modalidade
            // 
            this.lbl_modalidade.AutoSize = true;
            this.lbl_modalidade.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modalidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lbl_modalidade.Location = new System.Drawing.Point(192, 150);
            this.lbl_modalidade.Name = "lbl_modalidade";
            this.lbl_modalidade.Size = new System.Drawing.Size(91, 17);
            this.lbl_modalidade.TabIndex = 320;
            this.lbl_modalidade.Text = "Modalidade";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel6.Location = new System.Drawing.Point(153, 203);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 1);
            this.panel6.TabIndex = 319;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proj_M14_BrunoPinheiro.Properties.Resources.jogos_de_desporto;
            this.pictureBox1.Location = new System.Drawing.Point(153, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 318;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_detalhesocio
            // 
            this.dgv_detalhesocio.AllowUserToAddRows = false;
            this.dgv_detalhesocio.AllowUserToDeleteRows = false;
            this.dgv_detalhesocio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_detalhesocio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_detalhesocio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.dgv_detalhesocio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_detalhesocio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_detalhesocio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalhesocio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_detalhesocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detalhesocio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_detalhesocio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dgv_detalhesocio.Location = new System.Drawing.Point(573, 61);
            this.dgv_detalhesocio.Name = "dgv_detalhesocio";
            this.dgv_detalhesocio.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalhesocio.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.dgv_detalhesocio.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_detalhesocio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalhesocio.Size = new System.Drawing.Size(260, 392);
            this.dgv_detalhesocio.TabIndex = 317;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel5.Location = new System.Drawing.Point(546, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 430);
            this.panel5.TabIndex = 328;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CCElephantmenAged-Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(573, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 27);
            this.label1.TabIndex = 329;
            this.label1.Text = "Modalidades Inscritas";
            // 
            // frm_modalidades3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(860, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btn_desassociar);
            this.Controls.Add(this.btn_associar);
            this.Controls.Add(this.cbo_modalidade);
            this.Controls.Add(this.lbl_modalidade);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_detalhesocio);
            this.Controls.Add(this.btn_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_modalidades3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blue Lock - Modalidades";
            this.Load += new System.EventHandler(this.frm_modalidades3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalhesocio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_desassociar;
        private System.Windows.Forms.Button btn_associar;
        private System.Windows.Forms.ComboBox cbo_modalidade;
        private System.Windows.Forms.Label lbl_modalidade;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_detalhesocio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}