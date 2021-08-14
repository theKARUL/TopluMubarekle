using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace bayram
{
    public partial class formKayit : Form
    {

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public formKayit()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (tboxKadi.Text=="" || tboxSifre.Text=="")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı veya Şifreyi giriniz!", "HATALI KAYIT",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            else
            {
                string ad = tboxKadi.Text;
                string sifre = tboxSifre.Text;
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=bayram.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into kullanici(k_ad,k_sifre) values(@ad,@sifre)";
                cmd.Parameters.AddWithValue("@ad", tboxKadi.Text);
                cmd.Parameters.AddWithValue("@sifre", tboxSifre.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Başarıyla kayıt oldunuz!", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
          
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
