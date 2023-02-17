
namespace EntityUrunProje
{
    partial class FrmGiris
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
            this.btnkategori = new System.Windows.Forms.Button();
            this.btnurun = new System.Windows.Forms.Button();
            this.btnistatislik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkategori
            // 
            this.btnkategori.BackColor = System.Drawing.Color.White;
            this.btnkategori.Location = new System.Drawing.Point(16, 34);
            this.btnkategori.Name = "btnkategori";
            this.btnkategori.Size = new System.Drawing.Size(157, 86);
            this.btnkategori.TabIndex = 1;
            this.btnkategori.Text = "KATEGORİ İŞLEMLERİ";
            this.btnkategori.UseVisualStyleBackColor = false;
            this.btnkategori.Click += new System.EventHandler(this.btnkategori_Click);
            // 
            // btnurun
            // 
            this.btnurun.BackColor = System.Drawing.Color.White;
            this.btnurun.Location = new System.Drawing.Point(200, 34);
            this.btnurun.Name = "btnurun";
            this.btnurun.Size = new System.Drawing.Size(157, 86);
            this.btnurun.TabIndex = 2;
            this.btnurun.Text = "ÜRÜN İŞMELERİ";
            this.btnurun.UseVisualStyleBackColor = false;
            this.btnurun.Click += new System.EventHandler(this.btnurun_Click);
            // 
            // btnistatislik
            // 
            this.btnistatislik.BackColor = System.Drawing.Color.White;
            this.btnistatislik.Location = new System.Drawing.Point(383, 34);
            this.btnistatislik.Name = "btnistatislik";
            this.btnistatislik.Size = new System.Drawing.Size(157, 86);
            this.btnistatislik.TabIndex = 3;
            this.btnistatislik.Text = "İSTATİSLİKLER";
            this.btnistatislik.UseVisualStyleBackColor = false;
            this.btnistatislik.Click += new System.EventHandler(this.btnistatislik_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(557, 150);
            this.Controls.Add(this.btnistatislik);
            this.Controls.Add(this.btnurun);
            this.Controls.Add(this.btnkategori);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkategori;
        private System.Windows.Forms.Button btnurun;
        private System.Windows.Forms.Button btnistatislik;
    }
}