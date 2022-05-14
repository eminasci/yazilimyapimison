
namespace Yazılımyapımı
{
    partial class frmUyeol
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
            this.yazılımyapımıDataSet1 = new Yazılımyapımı.yazılımyapımıDataSet();
            this.yazılımyapımıDataSet2 = new Yazılımyapımı.yazılımyapımıDataSet();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.emailLbl = new System.Windows.Forms.Label();
            this.sifreLbl = new System.Windows.Forms.Label();
            this.soruLbl = new System.Windows.Forms.Label();
            this.cevapLbl = new System.Windows.Forms.Label();
            this.emailTxtbox = new System.Windows.Forms.TextBox();
            this.sifreTxtbox = new System.Windows.Forms.TextBox();
            this.cevapTxtbox = new System.Windows.Forms.TextBox();
            this.soruCmbbox = new System.Windows.Forms.ComboBox();
            this.uyeolBttn = new System.Windows.Forms.Button();
            this.cikisBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yazılımyapımıDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazılımyapımıDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // yazılımyapımıDataSet1
            // 
            this.yazılımyapımıDataSet1.DataSetName = "yazılımyapımıDataSet";
            this.yazılımyapımıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yazılımyapımıDataSet2
            // 
            this.yazılımyapımıDataSet2.DataSetName = "yazılımyapımıDataSet";
            this.yazılımyapımıDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailLbl.Location = new System.Drawing.Point(93, 69);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(71, 25);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "Email:";
            // 
            // sifreLbl
            // 
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLbl.Location = new System.Drawing.Point(102, 101);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(62, 25);
            this.sifreLbl.TabIndex = 1;
            this.sifreLbl.Text = "Şifre:";
            // 
            // soruLbl
            // 
            this.soruLbl.AutoSize = true;
            this.soruLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruLbl.Location = new System.Drawing.Point(101, 133);
            this.soruLbl.Name = "soruLbl";
            this.soruLbl.Size = new System.Drawing.Size(63, 25);
            this.soruLbl.TabIndex = 2;
            this.soruLbl.Text = "Soru:";
            // 
            // cevapLbl
            // 
            this.cevapLbl.AutoSize = true;
            this.cevapLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapLbl.Location = new System.Drawing.Point(84, 165);
            this.cevapLbl.Name = "cevapLbl";
            this.cevapLbl.Size = new System.Drawing.Size(80, 25);
            this.cevapLbl.TabIndex = 3;
            this.cevapLbl.Text = "Cevap:";
            // 
            // emailTxtbox
            // 
            this.emailTxtbox.Location = new System.Drawing.Point(184, 69);
            this.emailTxtbox.Name = "emailTxtbox";
            this.emailTxtbox.Size = new System.Drawing.Size(257, 20);
            this.emailTxtbox.TabIndex = 4;
            // 
            // sifreTxtbox
            // 
            this.sifreTxtbox.Location = new System.Drawing.Point(184, 101);
            this.sifreTxtbox.Name = "sifreTxtbox";
            this.sifreTxtbox.Size = new System.Drawing.Size(257, 20);
            this.sifreTxtbox.TabIndex = 5;
            // 
            // cevapTxtbox
            // 
            this.cevapTxtbox.Location = new System.Drawing.Point(184, 170);
            this.cevapTxtbox.Name = "cevapTxtbox";
            this.cevapTxtbox.Size = new System.Drawing.Size(257, 20);
            this.cevapTxtbox.TabIndex = 6;
            // 
            // soruCmbbox
            // 
            this.soruCmbbox.FormattingEnabled = true;
            this.soruCmbbox.Items.AddRange(new object[] {
            "1)İlkokul öğretmeninizin adı?",
            "2)Öğrenci nonuz?",
            "3)En sevdiğiniz öğretmeninizin adı?"});
            this.soruCmbbox.Location = new System.Drawing.Point(184, 137);
            this.soruCmbbox.Name = "soruCmbbox";
            this.soruCmbbox.Size = new System.Drawing.Size(257, 21);
            this.soruCmbbox.TabIndex = 7;
            // 
            // uyeolBttn
            // 
            this.uyeolBttn.Location = new System.Drawing.Point(184, 215);
            this.uyeolBttn.Name = "uyeolBttn";
            this.uyeolBttn.Size = new System.Drawing.Size(257, 41);
            this.uyeolBttn.TabIndex = 8;
            this.uyeolBttn.Text = "ÜYE OL";
            this.uyeolBttn.UseVisualStyleBackColor = true;
            this.uyeolBttn.Click += new System.EventHandler(this.uyeolBttn_Click);
            // 
            // cikisBttn
            // 
            this.cikisBttn.Location = new System.Drawing.Point(184, 275);
            this.cikisBttn.Name = "cikisBttn";
            this.cikisBttn.Size = new System.Drawing.Size(257, 41);
            this.cikisBttn.TabIndex = 9;
            this.cikisBttn.Text = "ÇIKIŞ";
            this.cikisBttn.UseVisualStyleBackColor = true;
            this.cikisBttn.Click += new System.EventHandler(this.cikisBttn_Click);
            // 
            // frmUyeol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cikisBttn);
            this.Controls.Add(this.uyeolBttn);
            this.Controls.Add(this.soruCmbbox);
            this.Controls.Add(this.cevapTxtbox);
            this.Controls.Add(this.sifreTxtbox);
            this.Controls.Add(this.emailTxtbox);
            this.Controls.Add(this.cevapLbl);
            this.Controls.Add(this.soruLbl);
            this.Controls.Add(this.sifreLbl);
            this.Controls.Add(this.emailLbl);
            this.Name = "frmUyeol";
            this.Text = "Üye Ol";
            ((System.ComponentModel.ISupportInitialize)(this.yazılımyapımıDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazılımyapımıDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private yazılımyapımıDataSet yazılımyapımıDataSet1;
        private yazılımyapımıDataSet yazılımyapımıDataSet2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label sifreLbl;
        private System.Windows.Forms.Label soruLbl;
        private System.Windows.Forms.Label cevapLbl;
        private System.Windows.Forms.TextBox emailTxtbox;
        private System.Windows.Forms.TextBox sifreTxtbox;
        private System.Windows.Forms.TextBox cevapTxtbox;
        private System.Windows.Forms.ComboBox soruCmbbox;
        private System.Windows.Forms.Button uyeolBttn;
        private System.Windows.Forms.Button cikisBttn;
    }
}