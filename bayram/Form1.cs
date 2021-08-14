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
    public partial class formGiris : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public formGiris()
        {
            InitializeComponent();
        }
        
        
        private void formGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string ad = tboxKadi.Text;
            string sifre = tboxSifre.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=bayram.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici where k_ad='" + tboxKadi.Text + "' AND k_sifre='" + tboxSifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                formMain main = new formMain();
                main.Show();
                main.lblAd.Text="Hoş Geldin "+ tboxKadi.Text;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış!", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
            
            con.Close();

        }

        private void lblKadi_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            formKayit kayit = new formKayit();
            kayit.Show();
        }

        private void formGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
