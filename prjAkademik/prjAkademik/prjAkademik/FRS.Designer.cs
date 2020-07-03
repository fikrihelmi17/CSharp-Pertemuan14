namespace prjAkademik
{
    partial class FRS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbNpm = new System.Windows.Forms.ComboBox();
            this.cmbFakultas = new System.Windows.Forms.ComboBox();
            this.cmbProdi = new System.Windows.Forms.ComboBox();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtTahun = new System.Windows.Forms.TextBox();
            this.txtFakultas = new System.Windows.Forms.TextBox();
            this.txtProdi = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.dgMatkul = new System.Windows.Forms.DataGridView();
            this.btnKirim = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatkul)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode FRS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tahun Akademik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NPM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nama Mahasiswa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fakultas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Program Studi";
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbSemester.Location = new System.Drawing.Point(141, 66);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(57, 21);
            this.cmbSemester.TabIndex = 7;
            this.cmbSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSemester_SelectedIndexChanged);
            // 
            // cmbNpm
            // 
            this.cmbNpm.FormattingEnabled = true;
            this.cmbNpm.Location = new System.Drawing.Point(141, 93);
            this.cmbNpm.Name = "cmbNpm";
            this.cmbNpm.Size = new System.Drawing.Size(130, 21);
            this.cmbNpm.TabIndex = 8;
            this.cmbNpm.SelectedIndexChanged += new System.EventHandler(this.cmbNpm_SelectedIndexChanged);
            // 
            // cmbFakultas
            // 
            this.cmbFakultas.FormattingEnabled = true;
            this.cmbFakultas.Location = new System.Drawing.Point(141, 146);
            this.cmbFakultas.Name = "cmbFakultas";
            this.cmbFakultas.Size = new System.Drawing.Size(121, 21);
            this.cmbFakultas.TabIndex = 9;
            this.cmbFakultas.SelectedIndexChanged += new System.EventHandler(this.cmbFakultas_SelectedIndexChanged);
            // 
            // cmbProdi
            // 
            this.cmbProdi.FormattingEnabled = true;
            this.cmbProdi.Location = new System.Drawing.Point(141, 177);
            this.cmbProdi.Name = "cmbProdi";
            this.cmbProdi.Size = new System.Drawing.Size(121, 21);
            this.cmbProdi.TabIndex = 10;
            this.cmbProdi.SelectedIndexChanged += new System.EventHandler(this.cmbProdi_SelectedIndexChanged);
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(141, 13);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(100, 20);
            this.txtKode.TabIndex = 11;
            // 
            // txtTahun
            // 
            this.txtTahun.Location = new System.Drawing.Point(141, 40);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.Size = new System.Drawing.Size(100, 20);
            this.txtTahun.TabIndex = 12;
            // 
            // txtFakultas
            // 
            this.txtFakultas.Location = new System.Drawing.Point(277, 146);
            this.txtFakultas.Name = "txtFakultas";
            this.txtFakultas.Size = new System.Drawing.Size(185, 20);
            this.txtFakultas.TabIndex = 13;
            // 
            // txtProdi
            // 
            this.txtProdi.Location = new System.Drawing.Point(277, 178);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.Size = new System.Drawing.Size(185, 20);
            this.txtProdi.TabIndex = 14;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(141, 120);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(189, 20);
            this.txtNama.TabIndex = 15;
            // 
            // dgMatkul
            // 
            this.dgMatkul.AllowUserToAddRows = false;
            this.dgMatkul.AllowUserToDeleteRows = false;
            this.dgMatkul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatkul.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgMatkul.Location = new System.Drawing.Point(37, 219);
            this.dgMatkul.Name = "dgMatkul";
            this.dgMatkul.Size = new System.Drawing.Size(464, 150);
            this.dgMatkul.TabIndex = 16;
            this.dgMatkul.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMatkul_CellContentClick);
            // 
            // btnKirim
            // 
            this.btnKirim.Location = new System.Drawing.Point(196, 386);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(75, 23);
            this.btnKirim.TabIndex = 17;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No.";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kode Matakuliah";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nama Matakuliah";
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SKS";
            this.Column4.Name = "Column4";
            this.Column4.Width = 40;
            // 
            // Column5
            // 
            this.Column5.FalseValue = "0";
            this.Column5.HeaderText = "Pilih";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.TrueValue = "1";
            this.Column5.Width = 40;
            // 
            // FRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.dgMatkul);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtFakultas);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.cmbProdi);
            this.Controls.Add(this.cmbFakultas);
            this.Controls.Add(this.cmbNpm);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRS";
            this.Text = "NPM";
            this.Load += new System.EventHandler(this.FRS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMatkul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ComboBox cmbNpm;
        private System.Windows.Forms.ComboBox cmbFakultas;
        private System.Windows.Forms.ComboBox cmbProdi;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtTahun;
        private System.Windows.Forms.TextBox txtFakultas;
        private System.Windows.Forms.TextBox txtProdi;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.DataGridView dgMatkul;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}