
namespace EntityUrunProje
{
    partial class FrmUrun
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdurum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(116, 29);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Urun Ad:";
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(116, 55);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(100, 20);
            this.txturunad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marka:";
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(116, 81);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(100, 20);
            this.txtmarka.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stok:";
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(116, 107);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(100, 20);
            this.txtstok.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fiyat:";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(116, 133);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Durum:";
            // 
            // txtdurum
            // 
            this.txtdurum.Location = new System.Drawing.Point(116, 159);
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(100, 20);
            this.txtdurum.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kategori:";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(388, 70);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(95, 34);
            this.btnguncelle.TabIndex = 3;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(388, 110);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(95, 34);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(388, 150);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(95, 37);
            this.btnekle.TabIndex = 5;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(388, 32);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(95, 32);
            this.btnlistele.TabIndex = 6;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 386);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txturunad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUrun";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdurum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}