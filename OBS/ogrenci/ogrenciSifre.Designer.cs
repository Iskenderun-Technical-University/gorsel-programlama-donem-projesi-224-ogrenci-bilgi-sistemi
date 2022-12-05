namespace OBS.ogrenci
{
    partial class ogrenciSifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciSifre));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTekrar = new System.Windows.Forms.TextBox();
            this.textBoxYeniSifre = new System.Windows.Forms.TextBox();
            this.textBoxEskiSifre = new System.Windows.Forms.TextBox();
            this.labelCaptcha = new System.Windows.Forms.Label();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eski Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yeni Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yeni Şifre (tekrar):";
            // 
            // textBoxTekrar
            // 
            this.textBoxTekrar.Location = new System.Drawing.Point(220, 385);
            this.textBoxTekrar.Name = "textBoxTekrar";
            this.textBoxTekrar.PasswordChar = '*';
            this.textBoxTekrar.Size = new System.Drawing.Size(235, 27);
            this.textBoxTekrar.TabIndex = 3;
            // 
            // textBoxYeniSifre
            // 
            this.textBoxYeniSifre.Location = new System.Drawing.Point(220, 278);
            this.textBoxYeniSifre.Name = "textBoxYeniSifre";
            this.textBoxYeniSifre.PasswordChar = '*';
            this.textBoxYeniSifre.Size = new System.Drawing.Size(235, 27);
            this.textBoxYeniSifre.TabIndex = 2;
            // 
            // textBoxEskiSifre
            // 
            this.textBoxEskiSifre.Location = new System.Drawing.Point(220, 177);
            this.textBoxEskiSifre.Name = "textBoxEskiSifre";
            this.textBoxEskiSifre.PasswordChar = '*';
            this.textBoxEskiSifre.Size = new System.Drawing.Size(235, 27);
            this.textBoxEskiSifre.TabIndex = 1;
            // 
            // labelCaptcha
            // 
            this.labelCaptcha.AutoSize = true;
            this.labelCaptcha.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCaptcha.Location = new System.Drawing.Point(220, 450);
            this.labelCaptcha.Name = "labelCaptcha";
            this.labelCaptcha.Size = new System.Drawing.Size(91, 24);
            this.labelCaptcha.TabIndex = 11;
            this.labelCaptcha.Text = "captcha";
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Location = new System.Drawing.Point(317, 450);
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(138, 27);
            this.textBoxCaptcha.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Şifre Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "bilgi";
            // 
            // ogrenciSifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 655);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCaptcha);
            this.Controls.Add(this.labelCaptcha);
            this.Controls.Add(this.textBoxEskiSifre);
            this.Controls.Add(this.textBoxYeniSifre);
            this.Controls.Add(this.textBoxTekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ogrenciSifre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştirme Ekranı";
            this.Load += new System.EventHandler(this.ogrenciSifre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxTekrar;
        private TextBox textBoxYeniSifre;
        private TextBox textBoxEskiSifre;
        private Label labelCaptcha;
        private TextBox textBoxCaptcha;
        private Button button1;
        private Label label4;
    }
}