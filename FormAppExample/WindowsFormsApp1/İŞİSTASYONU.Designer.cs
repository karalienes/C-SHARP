
namespace WindowsFormsApp1
{
    partial class İŞİSTASYONU
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textMaliyeti = new System.Windows.Forms.TextBox();
            this.textAmbarı = new System.Windows.Forms.TextBox();
            this.textAçıklama = new System.Windows.Forms.TextBox();
            this.textKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(590, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "EKLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 161);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // textMaliyeti
            // 
            this.textMaliyeti.BackColor = System.Drawing.Color.Maroon;
            this.textMaliyeti.Location = new System.Drawing.Point(252, 199);
            this.textMaliyeti.Name = "textMaliyeti";
            this.textMaliyeti.Size = new System.Drawing.Size(165, 22);
            this.textMaliyeti.TabIndex = 4;
            // 
            // textAmbarı
            // 
            this.textAmbarı.BackColor = System.Drawing.Color.Maroon;
            this.textAmbarı.Location = new System.Drawing.Point(252, 145);
            this.textAmbarı.Name = "textAmbarı";
            this.textAmbarı.Size = new System.Drawing.Size(165, 22);
            this.textAmbarı.TabIndex = 5;
            // 
            // textAçıklama
            // 
            this.textAçıklama.BackColor = System.Drawing.Color.Maroon;
            this.textAçıklama.Location = new System.Drawing.Point(252, 105);
            this.textAçıklama.Name = "textAçıklama";
            this.textAçıklama.Size = new System.Drawing.Size(165, 22);
            this.textAçıklama.TabIndex = 6;
            // 
            // textKodu
            // 
            this.textKodu.BackColor = System.Drawing.Color.Maroon;
            this.textKodu.Location = new System.Drawing.Point(252, 64);
            this.textKodu.Name = "textKodu";
            this.textKodu.Size = new System.Drawing.Size(165, 22);
            this.textKodu.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "İş İstasyonu Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "İş İstasyon Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hammadde Ambarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "İstasyon Maliyeti";
            // 
            // İŞİSTASYONU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textKodu);
            this.Controls.Add(this.textAçıklama);
            this.Controls.Add(this.textAmbarı);
            this.Controls.Add(this.textMaliyeti);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "İŞİSTASYONU";
            this.Text = "İŞİSTASYONU";
            this.Load += new System.EventHandler(this.İŞİSTASYONU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textMaliyeti;
        private System.Windows.Forms.TextBox textAmbarı;
        private System.Windows.Forms.TextBox textAçıklama;
        private System.Windows.Forms.TextBox textKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}