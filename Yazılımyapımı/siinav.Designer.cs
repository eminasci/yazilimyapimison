
namespace Yazılımyapımı
{
    partial class siinav
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
            this.nextbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cevapA = new System.Windows.Forms.RadioButton();
            this.cevapB = new System.Windows.Forms.RadioButton();
            this.cevapC = new System.Windows.Forms.RadioButton();
            this.cevapD = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(596, 391);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(133, 38);
            this.nextbutton.TabIndex = 0;
            this.nextbutton.Text = "NEXT SORU";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 318);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cevapA
            // 
            this.cevapA.AutoSize = true;
            this.cevapA.Location = new System.Drawing.Point(64, 337);
            this.cevapA.Name = "cevapA";
            this.cevapA.Size = new System.Drawing.Size(37, 21);
            this.cevapA.TabIndex = 2;
            this.cevapA.TabStop = true;
            this.cevapA.Text = "A";
            this.cevapA.UseVisualStyleBackColor = true;
            // 
            // cevapB
            // 
            this.cevapB.AutoSize = true;
            this.cevapB.Location = new System.Drawing.Point(179, 337);
            this.cevapB.Name = "cevapB";
            this.cevapB.Size = new System.Drawing.Size(37, 21);
            this.cevapB.TabIndex = 3;
            this.cevapB.TabStop = true;
            this.cevapB.Text = "B";
            this.cevapB.UseVisualStyleBackColor = true;
            // 
            // cevapC
            // 
            this.cevapC.AutoSize = true;
            this.cevapC.Location = new System.Drawing.Point(63, 400);
            this.cevapC.Name = "cevapC";
            this.cevapC.Size = new System.Drawing.Size(38, 21);
            this.cevapC.TabIndex = 4;
            this.cevapC.TabStop = true;
            this.cevapC.Text = "C";
            this.cevapC.UseVisualStyleBackColor = true;
            // 
            // cevapD
            // 
            this.cevapD.AutoSize = true;
            this.cevapD.Location = new System.Drawing.Point(177, 400);
            this.cevapD.Name = "cevapD";
            this.cevapD.Size = new System.Drawing.Size(39, 21);
            this.cevapD.TabIndex = 5;
            this.cevapD.TabStop = true;
            this.cevapD.Text = "D";
            this.cevapD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // siinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cevapD);
            this.Controls.Add(this.cevapC);
            this.Controls.Add(this.cevapB);
            this.Controls.Add(this.cevapA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nextbutton);
            this.Name = "siinav";
            this.Text = "siinav";
            this.Load += new System.EventHandler(this.siinav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton cevapA;
        private System.Windows.Forms.RadioButton cevapB;
        private System.Windows.Forms.RadioButton cevapC;
        private System.Windows.Forms.RadioButton cevapD;
        private System.Windows.Forms.Label label1;
    }
}