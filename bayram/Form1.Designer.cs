
namespace bayram
{
    partial class formGiris
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.tboxKadi = new System.Windows.Forms.TextBox();
            this.tboxSifre = new System.Windows.Forms.TextBox();
            this.lblKadi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnkayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(164, 131);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(153, 23);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(237, 160);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(153, 23);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // tboxKadi
            // 
            this.tboxKadi.Location = new System.Drawing.Point(216, 61);
            this.tboxKadi.Name = "tboxKadi";
            this.tboxKadi.Size = new System.Drawing.Size(135, 20);
            this.tboxKadi.TabIndex = 2;
            // 
            // tboxSifre
            // 
            this.tboxSifre.Location = new System.Drawing.Point(216, 87);
            this.tboxSifre.Name = "tboxSifre";
            this.tboxSifre.PasswordChar = '•';
            this.tboxSifre.Size = new System.Drawing.Size(135, 20);
            this.tboxSifre.TabIndex = 3;
            // 
            // lblKadi
            // 
            this.lblKadi.AutoSize = true;
            this.lblKadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKadi.Location = new System.Drawing.Point(109, 59);
            this.lblKadi.Name = "lblKadi";
            this.lblKadi.Size = new System.Drawing.Size(101, 20);
            this.lblKadi.TabIndex = 4;
            this.lblKadi.Text = "Kullanıcı Adı :";
            this.lblKadi.Click += new System.EventHandler(this.lblKadi_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(160, 85);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(50, 20);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Şifre :";
            // 
            // btnkayit
            // 
            this.btnkayit.Location = new System.Drawing.Point(78, 160);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(153, 23);
            this.btnkayit.TabIndex = 6;
            this.btnkayit.Text = "Kayıt Ol";
            this.btnkayit.UseVisualStyleBackColor = true;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(160, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "TOPLU MÜBAREKLE";
            // 
            // formGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKadi);
            this.Controls.Add(this.tboxSifre);
            this.Controls.Add(this.tboxKadi);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplu Mübarekle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formGiris_FormClosed);
            this.Load += new System.EventHandler(this.formGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox tboxKadi;
        private System.Windows.Forms.TextBox tboxSifre;
        private System.Windows.Forms.Label lblKadi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.Label label1;
    }
}

