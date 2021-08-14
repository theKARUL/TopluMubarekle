using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace bayram
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }


        MailMessage eposta = new MailMessage();

        void MailGonder()
        {
            eposta.From = new MailAddress("*******@hotmail.com");
            eposta.To.Add(tboxEposta.Text.ToString());
            
            if (cbKurban.Checked==true)
            {
                
                eposta.Subject = cbKurban.Text+" Bayramın Kutlu olsun";
                eposta.Body = "Kurban Bayramı’nı kutluyor, sevgi ve kardeşlik " +
                    "duygularının coşkuya dönüştüğü bu mübarek günlerin tüm insanlığa barış," +
                    " huzur, sağlık ve mutluluk getirmesini diliyorum." + " Saygılarımla " + tboxAd.Text;
            }
            else if (cbRamazan.Checked == true)
            {
                eposta.Subject = cbRamazan.Text + " Bayramın Kutlu olsun";
                eposta.Body = "Kardeşliğin doğduğu, sevgilerin birleştiği, belki durgun, belki yorgun, " +
                    "yine de mutlu, yine de umutlu, yine de sevgi dolu nice bayramlara. " +
                    "Ramazan Bayramınızı kutlar, " +
                    "küçüklerin ellerinden, büyüklerin gözlerinden öperim." + " Saygılarımla " + tboxAd.Text;
            }
            else if (cbCumh.Checked == true)
            {
                eposta.Subject = cbCumh.Text + " Bayramın Kutlu olsun";
                eposta.Body = "Cumhuriyet; fikren, ilmen ve bedenen kuvvetli ve yüksek karekterli koruyucular İster. " +
                    "Bu duygularla Cumhuriyet Bayramımız kutlu olsun!" + " Saygılarımla " + tboxAd.Text;
            }
            else if (cb23.Checked == true)
            {
                eposta.Subject = cb23.Text + " Bayramın Kutlu olsun";
                eposta.Body = "23 Nisan, Türkiye milli tarihinin başlangıcı ve yeni bir dönüm noktasıdır. " +
                    "Bütün bir düşmanlık dünyasına karşı ayağa kalkan Türkiye halkının, " +
                    "Türkiye Büyük Millet Meclisi’ni meydana getirmek hususunda gösterdiği harikayı ifade eder." + " Saygılarımla " + tboxAd.Text;
            }
            else if (cbYilbasi.Checked == true)
            {
                eposta.Subject = cbYilbasi.Text + " Bayramın Kutlu olsun";
                eposta.Body = "Getirdiği mutluluğun tüm kötülükleri unutturacağı, " +
                    "başarıların tüm başarısızlıkları yok edeceği güzelliklerin hayatını dolduracağı bir yıl dileğiyle. " +
                    "İyi Yıllar.." + " Saygılarımla "+tboxAd.Text;
            }

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("****@hotmail.com", "*****");
            smtp.Host = ("smtp.live.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;

            smtp.Send(eposta);
            MessageBox.Show("Mailiniz Gönderilmiştir");

        }




        private void clbMesaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            formGiris giris = new formGiris();
            giris.Visible = true;
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailGonder();
        }

        private void cbKurban_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKurban.Checked == true)
            {

                cb23.Enabled = false;
                cbCumh.Enabled = false;
                cbRamazan.Enabled = false;
                cbYilbasi.Enabled = false;

            }
            else if (cbKurban.Checked == false)
            {
                cb23.Enabled = true;
                cbCumh.Enabled = true;
                cbRamazan.Enabled = true;
                cbYilbasi.Enabled = true;
            }
        }
        private void cbRamazan_CheckedChanged(object sender, EventArgs e)
            {
                if (cbRamazan.Checked == true)
                {

                    cb23.Enabled = false;
                    cbCumh.Enabled = false;
                    cbYilbasi.Enabled = false;
                    cbKurban.Enabled = false;

                }
                else if (cbRamazan.Checked == false)
                {
                    cb23.Enabled = true;
                    cbCumh.Enabled = true;
                    cbYilbasi.Enabled = true;
                    cbKurban.Enabled = true;
                }
            }
        private void cbCumh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCumh.Checked == true)
            {

                cb23.Enabled = false;
                cbYilbasi.Enabled = false;
                cbRamazan.Enabled = false;
                cbKurban.Enabled = false;

            }
            else if (cbCumh.Checked == false)
            {
                cb23.Enabled = true;
                cbYilbasi.Enabled = true;
                cbRamazan.Enabled = true;
                cbKurban.Enabled = true;
            }
        }
        private void cb23_CheckedChanged(object sender, EventArgs e)
        {
            if (cb23.Checked == true)
            {

                cbYilbasi.Enabled = false;
                cbCumh.Enabled = false;
                cbRamazan.Enabled = false;
                cbKurban.Enabled = false;

            }
            else if (cb23.Checked == false)
            {
                cbYilbasi.Enabled = true;
                cbCumh.Enabled = true;
                cbRamazan.Enabled = true;
                cbKurban.Enabled = true;
            }
        }
        private void cbYilbasi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYilbasi.Checked==true)
            {
                
                cb23.Enabled = false;
                cbCumh.Enabled = false;
                cbRamazan.Enabled = false;
                cbKurban.Enabled = false;

            }
            else if (cbYilbasi.Checked == false)
            {
                cb23.Enabled = true;
                cbCumh.Enabled = true;
                cbRamazan.Enabled = true;
                cbKurban.Enabled = true;

            }
                
        }
    }
}
