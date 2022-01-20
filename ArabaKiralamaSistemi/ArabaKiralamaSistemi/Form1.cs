using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ArabaKiralamaSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=GORKEM;Initial Catalog=AracKiralama;Integrated Security=True");
        int aracId = -1;
        void goster()
        {
            lst_araclar.Items.Clear();
            conn.Open();
            SqlCommand komut = new SqlCommand("Select * From Araclar", conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["aracId"].ToString();
                ekle.SubItems.Add(oku["aracMarka"].ToString());
                ekle.SubItems.Add(oku["aracModel"].ToString());
                ekle.SubItems.Add(oku["aracRenk"].ToString());
                ekle.SubItems.Add(oku["aracKilometre"].ToString());
                ekle.SubItems.Add(oku["aracYakit"].ToString());
                ekle.SubItems.Add(oku["aracVites"].ToString());
                ekle.SubItems.Add(oku["aracKasa"].ToString());
                ekle.SubItems.Add(oku["aracKodu"].ToString());
                lst_araclar.Items.Add(ekle);
            }
            conn.Close();
        }
        void kaydet()
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into Araclar (aracMarka,aracModel,aracRenk,aracKilometre,aracYakit,aracVites,aracKasa) values" +
                "('" + txt_aracMarka.Text + "','" + txt_aracModel.Text + "','" + cmb_renk.Text + "','" + txt_kilometre.Text +
                "','" + cmb_yakit.Text + "','" + cmb_vite.Text + "','" + cmb_kasa.Text + "')", conn);
            komut.ExecuteNonQuery();
            conn.Close();
            goster();
        }
        void degistir()
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("Update Araclar set aracMarka ='" + txt_aracMarka.Text + "',aracModel='" + txt_aracModel.Text + "',aracKodu ='" + txt_aracKodu.Text + "',aracRenk='" + cmb_renk.Text +
                "',aracKilometre='" + txt_kilometre.Text + "',aracYakit='" + cmb_yakit.Text + "',aracVites='" + cmb_vite.Text + "',aracKasa='" + cmb_kasa.Text + "'where aracId = " + aracId + "", conn);
            komut.ExecuteNonQuery();
            conn.Close();
            goster();
        }
        void sil()
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("Delete from Araclar where aracId = (" + aracId + ")", conn);
            komut.ExecuteNonQuery();
            conn.Close();
            goster();
        }
        void sec()
        {
            aracId = int.Parse(lst_araclar.SelectedItems[0].SubItems[0].Text);
            txt_aracMarka.Text = lst_araclar.SelectedItems[0].SubItems[1].Text;
            txt_aracModel.Text = lst_araclar.SelectedItems[0].SubItems[2].Text;
            cmb_renk.Text = lst_araclar.SelectedItems[0].SubItems[3].Text;
            txt_kilometre.Text = lst_araclar.SelectedItems[0].SubItems[4].Text;
            cmb_yakit.Text = lst_araclar.SelectedItems[0].SubItems[5].Text;
            cmb_vite.Text = lst_araclar.SelectedItems[0].SubItems[6].Text;
            cmb_kasa.Text = lst_araclar.SelectedItems[0].SubItems[7].Text;
            txt_aracKodu.Text = lst_araclar.SelectedItems[0].SubItems[8].Text;
        }

        private void btn_goruntule_Click(object sender, EventArgs e)
        {
            goster();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void lst_araclar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sec();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (aracId > 0)
            {
                sil();
            }
        }

        private void btn_duzelt_Click(object sender, EventArgs e)
        {
            if (aracId > 0)
            {
                degistir();
            }
        }
    }
}
