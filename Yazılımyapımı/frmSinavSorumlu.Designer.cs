﻿
namespace Yazılımyapımı
{
    partial class frmSinavSorumlu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxpuan = new System.Windows.Forms.TextBox();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soruphotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.sorucevapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorupuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorutblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazılımyapımıDataSet1 = new Yazılımyapımı.yazılımyapımıDataSet1();
            this.soru_tblTableAdapter = new Yazılımyapımı.yazılımyapımıDataSet1TableAdapters.soru_tblTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorutblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazılımyapımıDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1442, 772);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxpuan);
            this.tabPage1.Controls.Add(this.radioButtonD);
            this.tabPage1.Controls.Add(this.radioButtonC);
            this.tabPage1.Controls.Add(this.radioButtonB);
            this.tabPage1.Controls.Add(this.radioButtonA);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1434, 743);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SORU EKLE";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "KONU SEÇ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. MEVSİMLER VE İKLİM",
            "2. DNA VE GENETİK KOD",
            "3. BASINÇ",
            "4. BASİT MAKİNELER",
            "5. ENERJİ DÖNÜŞÜMLERİ VE ÇEVRE BİLİMİ",
            "6. ELEKTRİK YÜKLERİ VE ELEKTRİK ENERJİSİ"});
            this.comboBox1.Location = new System.Drawing.Point(413, 557);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "SORU PUANI";
            // 
            // textBoxpuan
            // 
            this.textBoxpuan.Location = new System.Drawing.Point(245, 559);
            this.textBoxpuan.Name = "textBoxpuan";
            this.textBoxpuan.Size = new System.Drawing.Size(100, 24);
            this.textBoxpuan.TabIndex = 18;
            this.textBoxpuan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(144, 616);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(39, 21);
            this.radioButtonD.TabIndex = 17;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "D";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(43, 616);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(38, 21);
            this.radioButtonC.TabIndex = 16;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(144, 560);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(37, 21);
            this.radioButtonB.TabIndex = 15;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(43, 560);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(37, 21);
            this.radioButtonA.TabIndex = 14;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "SORU RESMİ SEÇ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "GÖZAT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1158, 472);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "DOĞRU CEVABI SEÇ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.radioButton4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1434, 743);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SORU GÜNCELLE";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1070, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "KONU YENİDEN SEÇ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1. MEVSİMLER VE İKLİM",
            "2. DNA VE GENETİK KOD",
            "3. BASINÇ",
            "4. BASİT MAKİNELER",
            "5. ENERJİ DÖNÜŞÜMLERİ VE ÇEVRE BİLİMİ",
            "6. ELEKTRİK YÜKLERİ VE ELEKTRİK ENERJİSİ"});
            this.comboBox2.Location = new System.Drawing.Point(1082, 628);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(946, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "SORU PUANI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(932, 628);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 29;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(865, 687);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 21);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "D";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(787, 687);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 21);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "C";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(867, 628);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 21);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "B";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(787, 628);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 21);
            this.radioButton4.TabIndex = 25;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "A";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1212, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "SORU RESMİ ENİDEN SEÇ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1274, 629);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "GÖZAT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(771, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "DOĞRU CEVABI SEÇ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1425, 494);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.konuadiDataGridViewTextBoxColumn,
            this.soruphotoDataGridViewImageColumn,
            this.sorucevapDataGridViewTextBoxColumn,
            this.sorupuanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sorutblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 506);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(737, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // konuadiDataGridViewTextBoxColumn
            // 
            this.konuadiDataGridViewTextBoxColumn.DataPropertyName = "konu_adi";
            this.konuadiDataGridViewTextBoxColumn.HeaderText = "konu_adi";
            this.konuadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.konuadiDataGridViewTextBoxColumn.Name = "konuadiDataGridViewTextBoxColumn";
            this.konuadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.konuadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soruphotoDataGridViewImageColumn
            // 
            this.soruphotoDataGridViewImageColumn.DataPropertyName = "soru_photo";
            this.soruphotoDataGridViewImageColumn.HeaderText = "soru_photo";
            this.soruphotoDataGridViewImageColumn.MinimumWidth = 6;
            this.soruphotoDataGridViewImageColumn.Name = "soruphotoDataGridViewImageColumn";
            this.soruphotoDataGridViewImageColumn.ReadOnly = true;
            this.soruphotoDataGridViewImageColumn.Width = 125;
            // 
            // sorucevapDataGridViewTextBoxColumn
            // 
            this.sorucevapDataGridViewTextBoxColumn.DataPropertyName = "soru_cevap";
            this.sorucevapDataGridViewTextBoxColumn.HeaderText = "soru_cevap";
            this.sorucevapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sorucevapDataGridViewTextBoxColumn.Name = "sorucevapDataGridViewTextBoxColumn";
            this.sorucevapDataGridViewTextBoxColumn.ReadOnly = true;
            this.sorucevapDataGridViewTextBoxColumn.Width = 125;
            // 
            // sorupuanDataGridViewTextBoxColumn
            // 
            this.sorupuanDataGridViewTextBoxColumn.DataPropertyName = "soru_puan";
            this.sorupuanDataGridViewTextBoxColumn.HeaderText = "soru_puan";
            this.sorupuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sorupuanDataGridViewTextBoxColumn.Name = "sorupuanDataGridViewTextBoxColumn";
            this.sorupuanDataGridViewTextBoxColumn.ReadOnly = true;
            this.sorupuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // sorutblBindingSource
            // 
            this.sorutblBindingSource.DataMember = "soru_tbl";
            this.sorutblBindingSource.DataSource = this.yazılımyapımıDataSet1;
            // 
            // yazılımyapımıDataSet1
            // 
            this.yazılımyapımıDataSet1.DataSetName = "yazılımyapımıDataSet1";
            this.yazılımyapımıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soru_tblTableAdapter
            // 
            this.soru_tblTableAdapter.ClearBeforeFill = true;
            // 
            // frmSinavSorumlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 783);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmSinavSorumlu";
            this.Text = "frmSinavSorumlu";
            this.Load += new System.EventHandler(this.frmSinavSorumlu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorutblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazılımyapımıDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxpuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yazılımyapımıDataSet1 yazılımyapımıDataSet1;
        private System.Windows.Forms.BindingSource sorutblBindingSource;
        private yazılımyapımıDataSet1TableAdapters.soru_tblTableAdapter soru_tblTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn soruphotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorucevapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorupuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
    }
}