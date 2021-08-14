
namespace bayram
{
    partial class formMain
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.cbKurban = new System.Windows.Forms.CheckBox();
            this.cbRamazan = new System.Windows.Forms.CheckBox();
            this.cbCumh = new System.Windows.Forms.CheckBox();
            this.cb23 = new System.Windows.Forms.CheckBox();
            this.cbYilbasi = new System.Windows.Forms.CheckBox();
            this.lblGonderen = new System.Windows.Forms.Label();
            this.tboxEposta = new System.Windows.Forms.TextBox();
            this.tboxAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBaslik.Location = new System.Drawing.Point(66, 27);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(568, 31);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "TOPLU MÜBAREKLEME\'YE HOŞ GELDİNİZ!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(67, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bayram Seçiniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAd.Location = new System.Drawing.Point(213, 58);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(0, 31);
            this.lblAd.TabIndex = 4;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(219, 353);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(228, 23);
            this.btnGonder.TabIndex = 5;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(219, 382);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(228, 23);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // cbKurban
            // 
            this.cbKurban.AutoSize = true;
            this.cbKurban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKurban.Location = new System.Drawing.Point(72, 139);
            this.cbKurban.Name = "cbKurban";
            this.cbKurban.Size = new System.Drawing.Size(79, 24);
            this.cbKurban.TabIndex = 7;
            this.cbKurban.Text = "Kurban";
            this.cbKurban.UseVisualStyleBackColor = true;
            this.cbKurban.CheckedChanged += new System.EventHandler(this.cbKurban_CheckedChanged);
            // 
            // cbRamazan
            // 
            this.cbRamazan.AutoSize = true;
            this.cbRamazan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbRamazan.Location = new System.Drawing.Point(72, 169);
            this.cbRamazan.Name = "cbRamazan";
            this.cbRamazan.Size = new System.Drawing.Size(97, 24);
            this.cbRamazan.TabIndex = 8;
            this.cbRamazan.Text = "Ramazan";
            this.cbRamazan.UseVisualStyleBackColor = true;
            this.cbRamazan.CheckedChanged += new System.EventHandler(this.cbRamazan_CheckedChanged);
            // 
            // cbCumh
            // 
            this.cbCumh.AutoSize = true;
            this.cbCumh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCumh.Location = new System.Drawing.Point(72, 199);
            this.cbCumh.Name = "cbCumh";
            this.cbCumh.Size = new System.Drawing.Size(108, 24);
            this.cbCumh.TabIndex = 9;
            this.cbCumh.Text = "Cumhuriyet";
            this.cbCumh.UseVisualStyleBackColor = true;
            this.cbCumh.CheckedChanged += new System.EventHandler(this.cbCumh_CheckedChanged);
            // 
            // cb23
            // 
            this.cb23.AutoSize = true;
            this.cb23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb23.Location = new System.Drawing.Point(72, 229);
            this.cb23.Name = "cb23";
            this.cb23.Size = new System.Drawing.Size(90, 24);
            this.cb23.TabIndex = 10;
            this.cb23.Text = "23 Nisan";
            this.cb23.UseVisualStyleBackColor = true;
            this.cb23.CheckedChanged += new System.EventHandler(this.cb23_CheckedChanged);
            // 
            // cbYilbasi
            // 
            this.cbYilbasi.AutoSize = true;
            this.cbYilbasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbYilbasi.Location = new System.Drawing.Point(72, 259);
            this.cbYilbasi.Name = "cbYilbasi";
            this.cbYilbasi.Size = new System.Drawing.Size(74, 24);
            this.cbYilbasi.TabIndex = 11;
            this.cbYilbasi.Text = "Yılbaşı";
            this.cbYilbasi.UseVisualStyleBackColor = true;
            this.cbYilbasi.CheckedChanged += new System.EventHandler(this.cbYilbasi_CheckedChanged);
            // 
            // lblGonderen
            // 
            this.lblGonderen.AutoSize = true;
            this.lblGonderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGonderen.Location = new System.Drawing.Point(322, 173);
            this.lblGonderen.Name = "lblGonderen";
            this.lblGonderen.Size = new System.Drawing.Size(256, 20);
            this.lblGonderen.TabIndex = 12;
            this.lblGonderen.Text = "Gönderilecek Kişinin Eposta Adresi";
            // 
            // tboxEposta
            // 
            this.tboxEposta.Location = new System.Drawing.Point(326, 197);
            this.tboxEposta.Name = "tboxEposta";
            this.tboxEposta.Size = new System.Drawing.Size(252, 20);
            this.tboxEposta.TabIndex = 13;
            // 
            // tboxAd
            // 
            this.tboxAd.Location = new System.Drawing.Point(401, 246);
            this.tboxAd.Name = "tboxAd";
            this.tboxAd.Size = new System.Drawing.Size(100, 20);
            this.tboxAd.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(410, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gönderen";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxAd);
            this.Controls.Add(this.tboxEposta);
            this.Controls.Add(this.lblGonderen);
            this.Controls.Add(this.cbYilbasi);
            this.Controls.Add(this.cb23);
            this.Controls.Add(this.cbCumh);
            this.Controls.Add(this.cbRamazan);
            this.Controls.Add(this.cbKurban);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBaslik);
            this.Name = "formMain";
            this.Text = "Toplu Mübarekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMain_FormClosed);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.CheckBox cbKurban;
        private System.Windows.Forms.CheckBox cbRamazan;
        private System.Windows.Forms.CheckBox cbCumh;
        private System.Windows.Forms.CheckBox cb23;
        private System.Windows.Forms.CheckBox cbYilbasi;
        private System.Windows.Forms.Label lblGonderen;
        private System.Windows.Forms.TextBox tboxEposta;
        private System.Windows.Forms.TextBox tboxAd;
        private System.Windows.Forms.Label label2;
    }
}