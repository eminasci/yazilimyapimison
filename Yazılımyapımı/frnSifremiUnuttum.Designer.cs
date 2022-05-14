
namespace Yazılımyapımı
{
    partial class sifremiunuttumFrm
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
            this.cikisBttn = new System.Windows.Forms.Button();
            this.uyeolBttn = new System.Windows.Forms.Button();
            this.cevapTxtbox = new System.Windows.Forms.TextBox();
            this.emailTxtbox = new System.Windows.Forms.TextBox();
            this.cevapLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.sifreTxtbox = new System.Windows.Forms.TextBox();
            this.sifreLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yazılımyapımıDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // yazılımyapımıDataSet1
            // 
            this.yazılımyapımıDataSet1.DataSetName = "yazılımyapımıDataSet";
            this.yazılımyapımıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cikisBttn
            // 
            this.cikisBttn.Location = new System.Drawing.Point(183, 216);
            this.cikisBttn.Name = "cikisBttn";
            this.cikisBttn.Size = new System.Drawing.Size(257, 41);
            this.cikisBttn.TabIndex = 19;
            this.cikisBttn.Text = "ÇIKIŞ";
            this.cikisBttn.UseVisualStyleBackColor = true;
            this.cikisBttn.Click += new System.EventHandler(this.cikisBttn_Click);
            // 
            // uyeolBttn
            // 
            this.uyeolBttn.Location = new System.Drawing.Point(183, 169);
            this.uyeolBttn.Name = "uyeolBttn";
            this.uyeolBttn.Size = new System.Drawing.Size(257, 41);
            this.uyeolBttn.TabIndex = 18;
            this.uyeolBttn.Text = "ŞİFRE SIFIRLA";
            this.uyeolBttn.UseVisualStyleBackColor = true;
            this.uyeolBttn.Click += new System.EventHandler(this.uyeolBttn_Click);
            // 
            // cevapTxtbox
            // 
            this.cevapTxtbox.Location = new System.Drawing.Point(183, 94);
            this.cevapTxtbox.Name = "cevapTxtbox";
            this.cevapTxtbox.Size = new System.Drawing.Size(271, 20);
            this.cevapTxtbox.TabIndex = 16;
            // 
            // emailTxtbox
            // 
            this.emailTxtbox.Location = new System.Drawing.Point(183, 58);
            this.emailTxtbox.Name = "emailTxtbox";
            this.emailTxtbox.Size = new System.Drawing.Size(271, 20);
            this.emailTxtbox.TabIndex = 14;
            // 
            // cevapLbl
            // 
            this.cevapLbl.AutoSize = true;
            this.cevapLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapLbl.Location = new System.Drawing.Point(97, 88);
            this.cevapLbl.Name = "cevapLbl";
            this.cevapLbl.Size = new System.Drawing.Size(80, 25);
            this.cevapLbl.TabIndex = 13;
            this.cevapLbl.Text = "Cevap:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailLbl.Location = new System.Drawing.Point(106, 52);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(71, 25);
            this.emailLbl.TabIndex = 10;
            this.emailLbl.Text = "Email:";
            // 
            // sifreTxtbox
            // 
            this.sifreTxtbox.Location = new System.Drawing.Point(183, 131);
            this.sifreTxtbox.Name = "sifreTxtbox";
            this.sifreTxtbox.Size = new System.Drawing.Size(271, 20);
            this.sifreTxtbox.TabIndex = 21;
            // 
            // sifreLbl
            // 
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLbl.Location = new System.Drawing.Point(65, 125);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(112, 25);
            this.sifreLbl.TabIndex = 20;
            this.sifreLbl.Text = "Yeni Şifre:";
            // 
            // sifremiunuttumFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sifreTxtbox);
            this.Controls.Add(this.sifreLbl);
            this.Controls.Add(this.cikisBttn);
            this.Controls.Add(this.uyeolBttn);
            this.Controls.Add(this.cevapTxtbox);
            this.Controls.Add(this.emailTxtbox);
            this.Controls.Add(this.cevapLbl);
            this.Controls.Add(this.emailLbl);
            this.Name = "sifremiunuttumFrm";
            this.Text = "şifremi unuttum";
            ((System.ComponentModel.ISupportInitialize)(this.yazılımyapımıDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private yazılımyapımıDataSet yazılımyapımıDataSet1;
        private System.Windows.Forms.Button cikisBttn;
        private System.Windows.Forms.Button uyeolBttn;
        private System.Windows.Forms.TextBox cevapTxtbox;
        private System.Windows.Forms.TextBox emailTxtbox;
        private System.Windows.Forms.Label cevapLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox sifreTxtbox;
        private System.Windows.Forms.Label sifreLbl;
    }
}