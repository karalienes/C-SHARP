
namespace WindowsFormsApp1
{
    partial class ÇALIŞAN
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textAD = new System.Windows.Forms.TextBox();
            this.textGÖREV = new System.Windows.Forms.TextBox();
            this.textBSMALİ = new System.Windows.Forms.TextBox();
            this.textAYLIKMALİ = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonEKLE = new System.Windows.Forms.Button();
            this.buttonGÜNCEL = new System.Windows.Forms.Button();
            this.buttonSİL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "GÖREV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "B.S.MALİYETİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "AYLIK MALİYET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "AD SOYAD";
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.Color.Fuchsia;
            this.textID.Location = new System.Drawing.Point(201, 28);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 22);
            this.textID.TabIndex = 5;
            // 
            // textAD
            // 
            this.textAD.BackColor = System.Drawing.Color.Fuchsia;
            this.textAD.Location = new System.Drawing.Point(201, 68);
            this.textAD.Name = "textAD";
            this.textAD.Size = new System.Drawing.Size(100, 22);
            this.textAD.TabIndex = 6;
            // 
            // textGÖREV
            // 
            this.textGÖREV.BackColor = System.Drawing.Color.Fuchsia;
            this.textGÖREV.Location = new System.Drawing.Point(201, 103);
            this.textGÖREV.Name = "textGÖREV";
            this.textGÖREV.Size = new System.Drawing.Size(100, 22);
            this.textGÖREV.TabIndex = 7;
            // 
            // textBSMALİ
            // 
            this.textBSMALİ.BackColor = System.Drawing.Color.Fuchsia;
            this.textBSMALİ.Location = new System.Drawing.Point(201, 145);
            this.textBSMALİ.Name = "textBSMALİ";
            this.textBSMALİ.Size = new System.Drawing.Size(100, 22);
            this.textBSMALİ.TabIndex = 8;
            // 
            // textAYLIKMALİ
            // 
            this.textAYLIKMALİ.BackColor = System.Drawing.Color.Fuchsia;
            this.textAYLIKMALİ.Location = new System.Drawing.Point(201, 185);
            this.textAYLIKMALİ.Name = "textAYLIKMALİ";
            this.textAYLIKMALİ.Size = new System.Drawing.Size(100, 22);
            this.textAYLIKMALİ.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // buttonEKLE
            // 
            this.buttonEKLE.BackColor = System.Drawing.Color.Red;
            this.buttonEKLE.Location = new System.Drawing.Point(542, 152);
            this.buttonEKLE.Name = "buttonEKLE";
            this.buttonEKLE.Size = new System.Drawing.Size(146, 55);
            this.buttonEKLE.TabIndex = 11;
            this.buttonEKLE.Text = "EKLE";
            this.buttonEKLE.UseVisualStyleBackColor = false;
            this.buttonEKLE.Click += new System.EventHandler(this.buttonEKLE_Click);
            // 
            // buttonGÜNCEL
            // 
            this.buttonGÜNCEL.BackColor = System.Drawing.Color.Red;
            this.buttonGÜNCEL.Location = new System.Drawing.Point(542, 90);
            this.buttonGÜNCEL.Name = "buttonGÜNCEL";
            this.buttonGÜNCEL.Size = new System.Drawing.Size(146, 56);
            this.buttonGÜNCEL.TabIndex = 12;
            this.buttonGÜNCEL.Text = "GÜNCELLE";
            this.buttonGÜNCEL.UseVisualStyleBackColor = false;
            this.buttonGÜNCEL.Click += new System.EventHandler(this.buttonGÜNCEL_Click);
            // 
            // buttonSİL
            // 
            this.buttonSİL.BackColor = System.Drawing.Color.Red;
            this.buttonSİL.Location = new System.Drawing.Point(542, 28);
            this.buttonSİL.Name = "buttonSİL";
            this.buttonSİL.Size = new System.Drawing.Size(146, 56);
            this.buttonSİL.TabIndex = 13;
            this.buttonSİL.Text = "SİL";
            this.buttonSİL.UseVisualStyleBackColor = false;
            this.buttonSİL.Click += new System.EventHandler(this.buttonSİL_Click);
            // 
            // ÇALIŞAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSİL);
            this.Controls.Add(this.buttonGÜNCEL);
            this.Controls.Add(this.buttonEKLE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textAYLIKMALİ);
            this.Controls.Add(this.textBSMALİ);
            this.Controls.Add(this.textGÖREV);
            this.Controls.Add(this.textAD);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ÇALIŞAN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textAD;
        private System.Windows.Forms.TextBox textGÖREV;
        private System.Windows.Forms.TextBox textBSMALİ;
        private System.Windows.Forms.TextBox textAYLIKMALİ;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonEKLE;
        private System.Windows.Forms.Button buttonGÜNCEL;
        private System.Windows.Forms.Button buttonSİL;
    }
}

