
namespace bayram
{
    partial class formKayit
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
            this.tboxKadi = new System.Windows.Forms.TextBox();
            this.tboxSifre = new System.Windows.Forms.TextBox();
            this.lblKadikayit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxKadi
            // 
            this.tboxKadi.Location = new System.Drawing.Point(148, 112);
            this.tboxKadi.Name = "tboxKadi";
            this.tboxKadi.Size = new System.Drawing.Size(148, 20);
            this.tboxKadi.TabIndex = 0;
            // 
            // tboxSifre
            // 
            this.tboxSifre.Location = new System.Drawing.Point(148, 138);
            this.tboxSifre.Name = "tboxSifre";
            this.tboxSifre.PasswordChar = '•';
            this.tboxSifre.Size = new System.Drawing.Size(148, 20);
            this.tboxSifre.TabIndex = 1;
            // 
            // lblKadikayit
            // 
            this.lblKadikayit.AutoSize = true;
            this.lblKadikayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKadikayit.Location = new System.Drawing.Point(41, 110);
            this.lblKadikayit.Name = "lblKadikayit";
            this.lblKadikayit.Size = new System.Drawing.Size(101, 20);
            this.lblKadikayit.TabIndex = 2;
            this.lblKadikayit.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(92, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(101, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "KAYIT OL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(107, 197);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(138, 23);
            this.btnKayit.TabIndex = 5;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(107, 226);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(138, 23);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // formKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 271);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKadikayit);
            this.Controls.Add(this.tboxSifre);
            this.Controls.Add(this.tboxKadi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxKadi;
        private System.Windows.Forms.TextBox tboxSifre;
        private System.Windows.Forms.Label lblKadikayit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnKapat;
    }
}