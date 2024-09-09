namespace ResimDosyaIslemleri
{
    partial class Form1
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
            this.btnRENKSEC = new System.Windows.Forms.Button();
            this.btnRESIMSEC = new System.Windows.Forms.Button();
            this.btnYAZDIR = new System.Windows.Forms.Button();
            this.btnKAYDET = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMetin = new System.Windows.Forms.TextBox();
            this.textBoxBoyut = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRENKSEC
            // 
            this.btnRENKSEC.Location = new System.Drawing.Point(33, 86);
            this.btnRENKSEC.Name = "btnRENKSEC";
            this.btnRENKSEC.Size = new System.Drawing.Size(158, 34);
            this.btnRENKSEC.TabIndex = 5;
            this.btnRENKSEC.Text = "Renk Seç";
            this.btnRENKSEC.UseVisualStyleBackColor = true;
            this.btnRENKSEC.Click += new System.EventHandler(this.btnRENKSEC_Click);
            // 
            // btnRESIMSEC
            // 
            this.btnRESIMSEC.Location = new System.Drawing.Point(33, 37);
            this.btnRESIMSEC.Name = "btnRESIMSEC";
            this.btnRESIMSEC.Size = new System.Drawing.Size(158, 34);
            this.btnRESIMSEC.TabIndex = 1;
            this.btnRESIMSEC.Text = "Resim Seç";
            this.btnRESIMSEC.UseVisualStyleBackColor = true;
            this.btnRESIMSEC.Click += new System.EventHandler(this.btnRESIMSEC_Click);
            // 
            // btnYAZDIR
            // 
            this.btnYAZDIR.Location = new System.Drawing.Point(33, 135);
            this.btnYAZDIR.Name = "btnYAZDIR";
            this.btnYAZDIR.Size = new System.Drawing.Size(158, 34);
            this.btnYAZDIR.TabIndex = 2;
            this.btnYAZDIR.Text = "Yazdır";
            this.btnYAZDIR.UseVisualStyleBackColor = true;
            this.btnYAZDIR.Click += new System.EventHandler(this.btnYAZDIR_Click);
            // 
            // btnKAYDET
            // 
            this.btnKAYDET.Location = new System.Drawing.Point(33, 185);
            this.btnKAYDET.Name = "btnKAYDET";
            this.btnKAYDET.Size = new System.Drawing.Size(158, 34);
            this.btnKAYDET.TabIndex = 3;
            this.btnKAYDET.Text = "Kaydet";
            this.btnKAYDET.UseVisualStyleBackColor = true;
            this.btnKAYDET.Click += new System.EventHandler(this.btnKAYDET_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Boyut:";
            // 
            // textBoxMetin
            // 
            this.textBoxMetin.Location = new System.Drawing.Point(90, 248);
            this.textBoxMetin.Name = "textBoxMetin";
            this.textBoxMetin.Size = new System.Drawing.Size(101, 30);
            this.textBoxMetin.TabIndex = 6;
            // 
            // textBoxBoyut
            // 
            this.textBoxBoyut.Location = new System.Drawing.Point(90, 295);
            this.textBoxBoyut.Name = "textBoxBoyut";
            this.textBoxBoyut.Size = new System.Drawing.Size(101, 30);
            this.textBoxBoyut.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(235, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnKAYDET;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxBoyut);
            this.Controls.Add(this.textBoxMetin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKAYDET);
            this.Controls.Add(this.btnYAZDIR);
            this.Controls.Add(this.btnRESIMSEC);
            this.Controls.Add(this.btnRENKSEC);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Dosya Resim İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRENKSEC;
        private System.Windows.Forms.Button btnRESIMSEC;
        private System.Windows.Forms.Button btnYAZDIR;
        private System.Windows.Forms.Button btnKAYDET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMetin;
        private System.Windows.Forms.TextBox textBoxBoyut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

