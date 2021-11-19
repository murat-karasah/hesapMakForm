
namespace hesapMakForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.artı = new System.Windows.Forms.Button();
            this.bol = new System.Windows.Forms.Button();
            this.carp = new System.Windows.Forms.Button();
            this.cıkar = new System.Windows.Forms.Button();
            this.kok = new System.Windows.Forms.Button();
            this.kare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "4 İşlem",
            "Karesini Alma",
            "Karekök"});
            this.comboBox1.Location = new System.Drawing.Point(42, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sonuç";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(227, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // artı
            // 
            this.artı.Location = new System.Drawing.Point(31, 101);
            this.artı.Name = "artı";
            this.artı.Size = new System.Drawing.Size(27, 23);
            this.artı.TabIndex = 8;
            this.artı.Text = "+";
            this.artı.UseVisualStyleBackColor = true;
            this.artı.Visible = false;
            this.artı.Click += new System.EventHandler(this.artı_Click);
            // 
            // bol
            // 
            this.bol.Location = new System.Drawing.Point(130, 101);
            this.bol.Name = "bol";
            this.bol.Size = new System.Drawing.Size(27, 23);
            this.bol.TabIndex = 9;
            this.bol.Text = "/";
            this.bol.UseVisualStyleBackColor = true;
            this.bol.Visible = false;
            this.bol.Click += new System.EventHandler(this.bol_Click);
            // 
            // carp
            // 
            this.carp.Location = new System.Drawing.Point(97, 101);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(27, 23);
            this.carp.TabIndex = 10;
            this.carp.Text = "*";
            this.carp.UseVisualStyleBackColor = true;
            this.carp.Visible = false;
            this.carp.Click += new System.EventHandler(this.carp_Click);
            // 
            // cıkar
            // 
            this.cıkar.Location = new System.Drawing.Point(64, 101);
            this.cıkar.Name = "cıkar";
            this.cıkar.Size = new System.Drawing.Size(27, 23);
            this.cıkar.TabIndex = 11;
            this.cıkar.Text = "-";
            this.cıkar.UseVisualStyleBackColor = true;
            this.cıkar.Visible = false;
            this.cıkar.Click += new System.EventHandler(this.cıkar_Click);
            // 
            // kok
            // 
            this.kok.Location = new System.Drawing.Point(227, 46);
            this.kok.Name = "kok";
            this.kok.Size = new System.Drawing.Size(100, 39);
            this.kok.TabIndex = 12;
            this.kok.Text = "Hesapla";
            this.kok.UseVisualStyleBackColor = true;
            this.kok.Visible = false;
            this.kok.Click += new System.EventHandler(this.kok_Click);
            // 
            // kare
            // 
            this.kare.Location = new System.Drawing.Point(227, 46);
            this.kare.Name = "kare";
            this.kare.Size = new System.Drawing.Size(100, 39);
            this.kare.TabIndex = 13;
            this.kare.Text = "Hesapla";
            this.kare.UseVisualStyleBackColor = true;
            this.kare.Visible = false;
            this.kare.Click += new System.EventHandler(this.kare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 132);
            this.Controls.Add(this.kare);
            this.Controls.Add(this.kok);
            this.Controls.Add(this.cıkar);
            this.Controls.Add(this.carp);
            this.Controls.Add(this.bol);
            this.Controls.Add(this.artı);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button artı;
        private System.Windows.Forms.Button bol;
        private System.Windows.Forms.Button carp;
        private System.Windows.Forms.Button cıkar;
        private System.Windows.Forms.Button kok;
        private System.Windows.Forms.Button kare;
    }
}

