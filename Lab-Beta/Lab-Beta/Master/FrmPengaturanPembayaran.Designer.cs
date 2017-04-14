namespace Lab_Beta.Master
{
    partial class FrmPengaturanPembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPengaturanPembayaran));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAkun = new System.Windows.Forms.TabPage();
            this.tabMetode = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNamaAkun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdAkun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCariAkun = new System.Windows.Forms.Button();
            this.txtCariAkun = new System.Windows.Forms.TextBox();
            this.dgvAkun = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKeluarAkun = new System.Windows.Forms.Button();
            this.btnHapusAkun = new System.Windows.Forms.Button();
            this.btnBatalAkun = new System.Windows.Forms.Button();
            this.btnEditAkun = new System.Windows.Forms.Button();
            this.btnSimpanAkun = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMetode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdMetode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCariMetode = new System.Windows.Forms.Button();
            this.txtCariMetode = new System.Windows.Forms.TextBox();
            this.dgvMetode = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnKeluarMetode = new System.Windows.Forms.Button();
            this.btnHapusMetode = new System.Windows.Forms.Button();
            this.btnBatalMetode = new System.Windows.Forms.Button();
            this.btnEditMetode = new System.Windows.Forms.Button();
            this.btnSimpanMetode = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAkun.SuspendLayout();
            this.tabMetode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkun)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetode)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAkun);
            this.tabControl1.Controls.Add(this.tabMetode);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 375);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAkun
            // 
            this.tabAkun.BackColor = System.Drawing.SystemColors.Control;
            this.tabAkun.Controls.Add(this.panel2);
            this.tabAkun.Controls.Add(this.dgvAkun);
            this.tabAkun.Controls.Add(this.groupBox2);
            this.tabAkun.Controls.Add(this.panel1);
            this.tabAkun.Location = new System.Drawing.Point(4, 22);
            this.tabAkun.Name = "tabAkun";
            this.tabAkun.Padding = new System.Windows.Forms.Padding(3);
            this.tabAkun.Size = new System.Drawing.Size(762, 349);
            this.tabAkun.TabIndex = 0;
            this.tabAkun.Text = "Akun Bank";
            // 
            // tabMetode
            // 
            this.tabMetode.BackColor = System.Drawing.SystemColors.Control;
            this.tabMetode.Controls.Add(this.panel4);
            this.tabMetode.Controls.Add(this.dgvMetode);
            this.tabMetode.Controls.Add(this.groupBox1);
            this.tabMetode.Controls.Add(this.panel3);
            this.tabMetode.Location = new System.Drawing.Point(4, 22);
            this.tabMetode.Name = "tabMetode";
            this.tabMetode.Padding = new System.Windows.Forms.Padding(3);
            this.tabMetode.Size = new System.Drawing.Size(762, 349);
            this.tabMetode.TabIndex = 1;
            this.tabMetode.Text = "Metode Pembayaran";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNamaAkun);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIdAkun);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 70);
            this.panel1.TabIndex = 0;
            // 
            // txtNamaAkun
            // 
            this.txtNamaAkun.Location = new System.Drawing.Point(98, 34);
            this.txtNamaAkun.Name = "txtNamaAkun";
            this.txtNamaAkun.Size = new System.Drawing.Size(214, 20);
            this.txtNamaAkun.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama Akun Bank";
            // 
            // txtIdAkun
            // 
            this.txtIdAkun.Location = new System.Drawing.Point(98, 8);
            this.txtIdAkun.Name = "txtIdAkun";
            this.txtIdAkun.Size = new System.Drawing.Size(100, 20);
            this.txtIdAkun.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCariAkun);
            this.groupBox2.Controls.Add(this.txtCariAkun);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 53);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pencarian Data";
            // 
            // btnCariAkun
            // 
            this.btnCariAkun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCariAkun.Image = ((System.Drawing.Image)(resources.GetObject("btnCariAkun.Image")));
            this.btnCariAkun.Location = new System.Drawing.Point(430, 10);
            this.btnCariAkun.Name = "btnCariAkun";
            this.btnCariAkun.Size = new System.Drawing.Size(75, 36);
            this.btnCariAkun.TabIndex = 176;
            this.btnCariAkun.UseVisualStyleBackColor = true;
            // 
            // txtCariAkun
            // 
            this.txtCariAkun.Location = new System.Drawing.Point(8, 19);
            this.txtCariAkun.Name = "txtCariAkun";
            this.txtCariAkun.Size = new System.Drawing.Size(416, 20);
            this.txtCariAkun.TabIndex = 176;
            // 
            // dgvAkun
            // 
            this.dgvAkun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAkun.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAkun.Location = new System.Drawing.Point(3, 126);
            this.dgvAkun.Name = "dgvAkun";
            this.dgvAkun.Size = new System.Drawing.Size(756, 165);
            this.dgvAkun.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnKeluarAkun);
            this.panel2.Controls.Add(this.btnHapusAkun);
            this.panel2.Controls.Add(this.btnBatalAkun);
            this.panel2.Controls.Add(this.btnEditAkun);
            this.panel2.Controls.Add(this.btnSimpanAkun);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 57);
            this.panel2.TabIndex = 6;
            // 
            // btnKeluarAkun
            // 
            this.btnKeluarAkun.Image = ((System.Drawing.Image)(resources.GetObject("btnKeluarAkun.Image")));
            this.btnKeluarAkun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluarAkun.Location = new System.Drawing.Point(386, 5);
            this.btnKeluarAkun.Name = "btnKeluarAkun";
            this.btnKeluarAkun.Size = new System.Drawing.Size(87, 39);
            this.btnKeluarAkun.TabIndex = 4;
            this.btnKeluarAkun.Text = "Keluar";
            this.btnKeluarAkun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKeluarAkun.UseVisualStyleBackColor = true;
            // 
            // btnHapusAkun
            // 
            this.btnHapusAkun.Image = ((System.Drawing.Image)(resources.GetObject("btnHapusAkun.Image")));
            this.btnHapusAkun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapusAkun.Location = new System.Drawing.Point(293, 5);
            this.btnHapusAkun.Name = "btnHapusAkun";
            this.btnHapusAkun.Size = new System.Drawing.Size(87, 39);
            this.btnHapusAkun.TabIndex = 3;
            this.btnHapusAkun.Text = "Hapus";
            this.btnHapusAkun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHapusAkun.UseVisualStyleBackColor = true;
            // 
            // btnBatalAkun
            // 
            this.btnBatalAkun.Image = ((System.Drawing.Image)(resources.GetObject("btnBatalAkun.Image")));
            this.btnBatalAkun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatalAkun.Location = new System.Drawing.Point(200, 5);
            this.btnBatalAkun.Name = "btnBatalAkun";
            this.btnBatalAkun.Size = new System.Drawing.Size(87, 39);
            this.btnBatalAkun.TabIndex = 2;
            this.btnBatalAkun.Text = "Batal";
            this.btnBatalAkun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBatalAkun.UseVisualStyleBackColor = true;
            // 
            // btnEditAkun
            // 
            this.btnEditAkun.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAkun.Image")));
            this.btnEditAkun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAkun.Location = new System.Drawing.Point(107, 5);
            this.btnEditAkun.Name = "btnEditAkun";
            this.btnEditAkun.Size = new System.Drawing.Size(87, 39);
            this.btnEditAkun.TabIndex = 1;
            this.btnEditAkun.Text = "Edit";
            this.btnEditAkun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditAkun.UseVisualStyleBackColor = true;
            // 
            // btnSimpanAkun
            // 
            this.btnSimpanAkun.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpanAkun.Image")));
            this.btnSimpanAkun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpanAkun.Location = new System.Drawing.Point(14, 5);
            this.btnSimpanAkun.Name = "btnSimpanAkun";
            this.btnSimpanAkun.Size = new System.Drawing.Size(87, 39);
            this.btnSimpanAkun.TabIndex = 0;
            this.btnSimpanAkun.Text = "Simpan";
            this.btnSimpanAkun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpanAkun.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtMetode);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtIdMetode);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 68);
            this.panel3.TabIndex = 1;
            // 
            // txtMetode
            // 
            this.txtMetode.Location = new System.Drawing.Point(122, 39);
            this.txtMetode.Name = "txtMetode";
            this.txtMetode.Size = new System.Drawing.Size(214, 20);
            this.txtMetode.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Metode Pembayaran";
            // 
            // txtIdMetode
            // 
            this.txtIdMetode.Location = new System.Drawing.Point(122, 13);
            this.txtIdMetode.Name = "txtIdMetode";
            this.txtIdMetode.Size = new System.Drawing.Size(100, 20);
            this.txtIdMetode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCariMetode);
            this.groupBox1.Controls.Add(this.txtCariMetode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian Data";
            // 
            // btnCariMetode
            // 
            this.btnCariMetode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCariMetode.Image = ((System.Drawing.Image)(resources.GetObject("btnCariMetode.Image")));
            this.btnCariMetode.Location = new System.Drawing.Point(430, 10);
            this.btnCariMetode.Name = "btnCariMetode";
            this.btnCariMetode.Size = new System.Drawing.Size(75, 36);
            this.btnCariMetode.TabIndex = 176;
            this.btnCariMetode.UseVisualStyleBackColor = true;
            // 
            // txtCariMetode
            // 
            this.txtCariMetode.Location = new System.Drawing.Point(8, 19);
            this.txtCariMetode.Name = "txtCariMetode";
            this.txtCariMetode.Size = new System.Drawing.Size(416, 20);
            this.txtCariMetode.TabIndex = 176;
            // 
            // dgvMetode
            // 
            this.dgvMetode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetode.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMetode.Location = new System.Drawing.Point(3, 124);
            this.dgvMetode.Name = "dgvMetode";
            this.dgvMetode.Size = new System.Drawing.Size(756, 165);
            this.dgvMetode.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnKeluarMetode);
            this.panel4.Controls.Add(this.btnHapusMetode);
            this.panel4.Controls.Add(this.btnBatalMetode);
            this.panel4.Controls.Add(this.btnEditMetode);
            this.panel4.Controls.Add(this.btnSimpanMetode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 289);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 57);
            this.panel4.TabIndex = 7;
            // 
            // btnKeluarMetode
            // 
            this.btnKeluarMetode.Image = ((System.Drawing.Image)(resources.GetObject("btnKeluarMetode.Image")));
            this.btnKeluarMetode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluarMetode.Location = new System.Drawing.Point(386, 5);
            this.btnKeluarMetode.Name = "btnKeluarMetode";
            this.btnKeluarMetode.Size = new System.Drawing.Size(87, 39);
            this.btnKeluarMetode.TabIndex = 4;
            this.btnKeluarMetode.Text = "Keluar";
            this.btnKeluarMetode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKeluarMetode.UseVisualStyleBackColor = true;
            // 
            // btnHapusMetode
            // 
            this.btnHapusMetode.Image = ((System.Drawing.Image)(resources.GetObject("btnHapusMetode.Image")));
            this.btnHapusMetode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapusMetode.Location = new System.Drawing.Point(293, 5);
            this.btnHapusMetode.Name = "btnHapusMetode";
            this.btnHapusMetode.Size = new System.Drawing.Size(87, 39);
            this.btnHapusMetode.TabIndex = 3;
            this.btnHapusMetode.Text = "Hapus";
            this.btnHapusMetode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHapusMetode.UseVisualStyleBackColor = true;
            // 
            // btnBatalMetode
            // 
            this.btnBatalMetode.Image = ((System.Drawing.Image)(resources.GetObject("btnBatalMetode.Image")));
            this.btnBatalMetode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatalMetode.Location = new System.Drawing.Point(200, 5);
            this.btnBatalMetode.Name = "btnBatalMetode";
            this.btnBatalMetode.Size = new System.Drawing.Size(87, 39);
            this.btnBatalMetode.TabIndex = 2;
            this.btnBatalMetode.Text = "Batal";
            this.btnBatalMetode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBatalMetode.UseVisualStyleBackColor = true;
            // 
            // btnEditMetode
            // 
            this.btnEditMetode.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMetode.Image")));
            this.btnEditMetode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMetode.Location = new System.Drawing.Point(107, 5);
            this.btnEditMetode.Name = "btnEditMetode";
            this.btnEditMetode.Size = new System.Drawing.Size(87, 39);
            this.btnEditMetode.TabIndex = 1;
            this.btnEditMetode.Text = "Edit";
            this.btnEditMetode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditMetode.UseVisualStyleBackColor = true;
            // 
            // btnSimpanMetode
            // 
            this.btnSimpanMetode.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpanMetode.Image")));
            this.btnSimpanMetode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpanMetode.Location = new System.Drawing.Point(14, 5);
            this.btnSimpanMetode.Name = "btnSimpanMetode";
            this.btnSimpanMetode.Size = new System.Drawing.Size(87, 39);
            this.btnSimpanMetode.TabIndex = 0;
            this.btnSimpanMetode.Text = "Simpan";
            this.btnSimpanMetode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpanMetode.UseVisualStyleBackColor = true;
            // 
            // FrmPengaturanPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 375);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPengaturanPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengaturan Pembayaran";
            this.tabControl1.ResumeLayout(false);
            this.tabAkun.ResumeLayout(false);
            this.tabMetode.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkun)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetode)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAkun;
        private System.Windows.Forms.TabPage tabMetode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNamaAkun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdAkun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCariAkun;
        internal System.Windows.Forms.TextBox txtCariAkun;
        private System.Windows.Forms.DataGridView dgvAkun;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKeluarAkun;
        private System.Windows.Forms.Button btnHapusAkun;
        private System.Windows.Forms.Button btnBatalAkun;
        private System.Windows.Forms.Button btnEditAkun;
        private System.Windows.Forms.Button btnSimpanAkun;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMetode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdMetode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnKeluarMetode;
        private System.Windows.Forms.Button btnHapusMetode;
        private System.Windows.Forms.Button btnBatalMetode;
        private System.Windows.Forms.Button btnEditMetode;
        private System.Windows.Forms.Button btnSimpanMetode;
        private System.Windows.Forms.DataGridView dgvMetode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCariMetode;
        internal System.Windows.Forms.TextBox txtCariMetode;
    }
}