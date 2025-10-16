namespace ödev_5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.panelOyun = new System.Windows.Forms.Panel();
            this.listBoxKayit = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(29, 169);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 50);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "OYUNA BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.Location = new System.Drawing.Point(703, 169);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(75, 50);
            this.btnBitir.TabIndex = 0;
            this.btnBitir.Text = "OYUNU BİTİR";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // panelOyun
            // 
            this.panelOyun.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelOyun.Location = new System.Drawing.Point(110, 12);
            this.panelOyun.Name = "panelOyun";
            this.panelOyun.Size = new System.Drawing.Size(461, 354);
            this.panelOyun.TabIndex = 2;
            // 
            // listBoxKayit
            // 
            this.listBoxKayit.FormattingEnabled = true;
            this.listBoxKayit.Location = new System.Drawing.Point(577, 11);
            this.listBoxKayit.Name = "listBoxKayit";
            this.listBoxKayit.Size = new System.Drawing.Size(120, 355);
            this.listBoxKayit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SÜRE";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(703, 275);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(37, 13);
            this.lblSure.TabIndex = 4;
            this.lblSure.Text = "60 SN";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxKayit);
            this.Controls.Add(this.panelOyun);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnBasla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Panel panelOyun;
        private System.Windows.Forms.ListBox listBoxKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer timer1;
    }
}

