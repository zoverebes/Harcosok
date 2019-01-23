namespace HarcosokApplication
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
            this.harcosNeveTextBox = new System.Windows.Forms.TextBox();
            this.letrehozas = new System.Windows.Forms.Button();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.hozzaad = new System.Windows.Forms.Button();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.kepessegLeirasaTextBox = new System.Windows.Forms.TextBox();
            this.modosit = new System.Windows.Forms.Button();
            this.torles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // harcosNeveTextBox
            // 
            this.harcosNeveTextBox.Location = new System.Drawing.Point(51, 28);
            this.harcosNeveTextBox.Name = "harcosNeveTextBox";
            this.harcosNeveTextBox.Size = new System.Drawing.Size(100, 20);
            this.harcosNeveTextBox.TabIndex = 0;
            // 
            // letrehozas
            // 
            this.letrehozas.Location = new System.Drawing.Point(200, 25);
            this.letrehozas.Name = "letrehozas";
            this.letrehozas.Size = new System.Drawing.Size(75, 23);
            this.letrehozas.TabIndex = 1;
            this.letrehozas.Text = "Létrehozás";
            this.letrehozas.UseVisualStyleBackColor = true;
            this.letrehozas.Click += new System.EventHandler(this.letrehozas_Click);
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(75, 107);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(121, 21);
            this.hasznaloComboBox.TabIndex = 2;
            // 
            // kepessegNeveTextBox
            // 
            this.kepessegNeveTextBox.Location = new System.Drawing.Point(75, 134);
            this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
            this.kepessegNeveTextBox.Size = new System.Drawing.Size(100, 20);
            this.kepessegNeveTextBox.TabIndex = 3;
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(321, 104);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(467, 50);
            this.leirasTextBox.TabIndex = 4;
            // 
            // hozzaad
            // 
            this.hozzaad.Location = new System.Drawing.Point(18, 170);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(75, 23);
            this.hozzaad.TabIndex = 5;
            this.hozzaad.Text = "Hozzáad";
            this.hozzaad.UseVisualStyleBackColor = true;
            this.hozzaad.Click += new System.EventHandler(this.hozzaad_Click_1);
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.Location = new System.Drawing.Point(18, 258);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(120, 147);
            this.harcosokListBox.TabIndex = 6;
            this.harcosokListBox.SelectedIndexChanged += new System.EventHandler(this.harcosokListBox_SelectedIndexChanged);
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.Location = new System.Drawing.Point(200, 258);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(120, 147);
            this.kepessegekListBox.TabIndex = 7;
            this.kepessegekListBox.SelectedIndexChanged += new System.EventHandler(this.kepessegekListBox_SelectedIndexChanged);
            // 
            // kepessegLeirasaTextBox
            // 
            this.kepessegLeirasaTextBox.Location = new System.Drawing.Point(436, 258);
            this.kepessegLeirasaTextBox.Multiline = true;
            this.kepessegLeirasaTextBox.Name = "kepessegLeirasaTextBox";
            this.kepessegLeirasaTextBox.Size = new System.Drawing.Size(352, 95);
            this.kepessegLeirasaTextBox.TabIndex = 8;
            this.kepessegLeirasaTextBox.TextChanged += new System.EventHandler(this.kepessegLeirasaTextBox_TextChanged);
            // 
            // modosit
            // 
            this.modosit.Location = new System.Drawing.Point(713, 359);
            this.modosit.Name = "modosit";
            this.modosit.Size = new System.Drawing.Size(75, 23);
            this.modosit.TabIndex = 9;
            this.modosit.Text = "Módosít";
            this.modosit.UseVisualStyleBackColor = true;
            // 
            // torles
            // 
            this.torles.Location = new System.Drawing.Point(200, 415);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(75, 23);
            this.torles.TabIndex = 10;
            this.torles.Text = "Törlés";
            this.torles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Harcos létrehozása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Képesség hozzáadása";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Használó:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Név:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Leírás:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Harcosok:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Képességei:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Képesség leírása";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.torles);
            this.Controls.Add(this.modosit);
            this.Controls.Add(this.kepessegLeirasaTextBox);
            this.Controls.Add(this.kepessegekListBox);
            this.Controls.Add(this.harcosokListBox);
            this.Controls.Add(this.hozzaad);
            this.Controls.Add(this.leirasTextBox);
            this.Controls.Add(this.kepessegNeveTextBox);
            this.Controls.Add(this.hasznaloComboBox);
            this.Controls.Add(this.letrehozas);
            this.Controls.Add(this.harcosNeveTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox harcosNeveTextBox;
        private System.Windows.Forms.Button letrehozas;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.TextBox kepessegNeveTextBox;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.TextBox kepessegLeirasaTextBox;
        private System.Windows.Forms.Button modosit;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

