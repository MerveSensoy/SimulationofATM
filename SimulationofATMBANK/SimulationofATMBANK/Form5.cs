using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationofATMBANK
{
    public partial class Form5 : Form
    {
        int i;
        // Yeni Bir Panel eklenip Giriş ve kart bölümleri oluşturulacak.
        public Form5()
        {
            InitializeComponent();
        }

        private void giris_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void giris_sec_1_Click(object sender, EventArgs e)
        {
            i = 1;
        }

        private void giris_sec_2_Click(object sender, EventArgs e)
        {
            i = 2;
        }

        private void giris_sec_3_Click(object sender, EventArgs e)
        {
            i = 3;
        }

        private void giris_sec_4_Click(object sender, EventArgs e)
        {
            i = 4;
        }

        private void giris_sec_5_Click(object sender, EventArgs e)
        {
            i = 5;
        }

        private void giris_sec_6_Click(object sender, EventArgs e)
        {
            i = 6;
        }

        private void giris_sec_7_Click(object sender, EventArgs e)
        {
            i = 7;
        }

        private void giris_sec_8_Click(object sender, EventArgs e)
        {
            i = 8;
        }

        private void giris_sec_9_Click(object sender, EventArgs e)
        {
            i = 9;
        }

        private void giris_sec_0_Click(object sender, EventArgs e)
        {
            i = 0;
        }

        private void giris_sec_eksi_Click(object sender, EventArgs e)
        {

        }

        private void giris_sec_arti_Click(object sender, EventArgs e)
        {

        }

        private void giris_giris_Click(object sender, EventArgs e)
        {
            //Database kontrol işlemleri gerçekleştirilecek
            panel18.Visible = false;
            panel1.Visible = true;
        }

        private void giris_duzeltme_Click(object sender, EventArgs e)
        {

        }

        private void giris_iptal_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_bakiye_Click(object sender, EventArgs e)
        {

        }

        private void panel1_paracekme_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel1_kendihesabinaparayatirma_Click(object sender, EventArgs e)
        {

        }

        private void panel1_paratransferi_Click(object sender, EventArgs e)
        {

        }

        private void panel1_hizlielliTLcek_Click(object sender, EventArgs e)
        {

        }

        private void panel1_hesapbilgileri_Click(object sender, EventArgs e)
        {

        }

        private void panel1_digerislemler_Click(object sender, EventArgs e)
        {

        }

        private void panel1_kartiade_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void panel2_onTLcek_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel2_yirmiTLcek_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel2_otuzTLcek_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel2_elliTLcek_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel2_yuzTLcek_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel2_ikiyuzelliTLcek_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel2_binTLcek_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel2_digerTLcek_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void panel3_paracekilenhesapnumarasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_musteriisimsoyisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_cekilenmiktar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_guncelbakiye_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_yeniislem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
        }

        private void panel3_kartiade_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible= false;
            panel3.Visible = false;

        }

        private void panel4_digermiktari_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_sec_1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_sec_2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_sec_3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_sec_4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_sec_5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_sec_6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_sec_7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_sec_8_Click(object sender, EventArgs e)
        {

        }

        private void panel4_sec_9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_sec_0_Click(object sender, EventArgs e)
        {

        }

        private void panel4_sec_eksi_Click(object sender, EventArgs e)
        {

        }

        private void panel4_sec_arti_Click(object sender, EventArgs e)
        {

        }

        private void panel4_giris_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
        }

        private void panel4_duzeltme_Click(object sender, EventArgs e)
        {

        }

        private void panel4_iptal_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = false;
        }

        private void panel5_kartinhesabinaparayatirma_Click(object sender, EventArgs e)
        {

        }

        private void panel5_digerhesaplarimaparayatirma_Click(object sender, EventArgs e)
        {

        }

        private void panel5_anasayfa_Click(object sender, EventArgs e)
        {

        }
        
        private void panel5_kartiade_Click(object sender, EventArgs e)
        {

        }


        private void panel6_yatirilacakpara_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_sec_1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_sec_2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_sec_3_Click(object sender, EventArgs e)
        {

        }

        private void panel6_sec_4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_sec_5_Click(object sender, EventArgs e)
        {

        }

        private void panel6_sec_6_Click(object sender, EventArgs e)
        {

        }

        private void panel6_sec_7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_sec_8_Click(object sender, EventArgs e)
        {

        }

        private void panel6_sec_9_Click(object sender, EventArgs e)
        {

        }

        private void panel6_sec_0_Click(object sender, EventArgs e)
        {

        }

        private void panel6_sec_eksi_Click(object sender, EventArgs e)
        {

        }

        private void panel6_sec_arti_Click(object sender, EventArgs e)
        {

        }

        private void panel6_giris_Click(object sender, EventArgs e)
        {

        }

        private void panel6_duzeltme_Click(object sender, EventArgs e)
        {

        }

        private void panel6_iptal_Click(object sender, EventArgs e)
        {

        }

        private void panel7_makbuzistiyorum_Click(object sender, EventArgs e)
        {

        }

        private void panel7_makbuzistemiyorum_Click(object sender, EventArgs e)
        {

        }

        private void panel8_paragonderilenhesapnumarasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_parayatirilanhesapnumarasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_musteriisimsoyisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_gonderilenmiktar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_guncelbakiye_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_yatirilacakhesapnumarasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_sec_1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_sec_2_Click(object sender, EventArgs e)
        {

        }

        private void panel9_sec_3_Click(object sender, EventArgs e)
        {

        }

        private void panel9_sec_4_Click(object sender, EventArgs e)
        {

        }

        private void panel9_sec_5_Click(object sender, EventArgs e)
        {

        }

        private void panel9_sec_6_Click(object sender, EventArgs e)
        {

        }

        private void panel9_sec_7_Click(object sender, EventArgs e)
        {

        }

        private void panel9_sec_8_Click(object sender, EventArgs e)
        {

        }

        private void panel9_sec_9_Click(object sender, EventArgs e)
        {

        }

        private void panel9_sec_0_Click(object sender, EventArgs e)
        {

        }

        private void panel9_sec_eksi_Click(object sender, EventArgs e)
        {

        }

        private void panel9_sec_arti_Click(object sender, EventArgs e)
        {

        }

        private void panel9_giris_Click(object sender, EventArgs e)
        {

        }

        private void panel9_duzeltme_Click(object sender, EventArgs e)
        {

        }

        private void panel9_iptal_Click(object sender, EventArgs e)
        {

        }

        private void panel9_anasayfa_Click(object sender, EventArgs e)
        {

        }

        private void panel9_kartiade_Click(object sender, EventArgs e)
        {

        }

        private void panel10_baskahesabaparatransferi_Click(object sender, EventArgs e)
        {

        }

        private void panel10_tanimlihesabaparayatirma_Click(object sender, EventArgs e)
        {

        }

        private void panel10_anasayfa_Click(object sender, EventArgs e)
        {

        }

        private void panel10_kartiade_Click(object sender, EventArgs e)
        {

        }

        private void panel11_digerhesap1_Click(object sender, EventArgs e)
        {

        }

        private void panel11_digerhesap2_Click(object sender, EventArgs e)
        {

        }

        private void panel11_anasayfa_Click(object sender, EventArgs e)
        {

        }

        private void panel11_kartiade_Click(object sender, EventArgs e)
        {

        }

        private void panel12_tanimlidigerhesap1_Click(object sender, EventArgs e)
        {

        }

        private void panel12_tanimlidigerhesap2_Click(object sender, EventArgs e)
        {

        }

        private void panel12_tanimlidigerhesap3_Click(object sender, EventArgs e)
        {

        }

        private void panel12_anasayfa_Click(object sender, EventArgs e)
        {

        }

        private void panel12_kartiade_Click(object sender, EventArgs e)
        {

        }

        private void panel13_eskibakiye_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel13_cekilenmiktar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel13_yenibakiye_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel13_makbuzistiyorum_Click(object sender, EventArgs e)
        {

        }

        private void panel13_makbuzistemiyorum_Click(object sender, EventArgs e)
        {

        }

        private void panel14_guncelbakiyesorgulama_Click(object sender, EventArgs e)
        {

        }

        private void panel14_hesapozeti_Click(object sender, EventArgs e)
        {

        }

        private void panel14_anasayfa_Click(object sender, EventArgs e)
        {

        }

        private void panel14_kartiade_Click(object sender, EventArgs e)
        {

        }

        private void panel15_musteriisimsoyisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel15_guncelbakiye_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel15_yeniislem_Click(object sender, EventArgs e)
        {

        }

        private void panel15_kartiade_Click(object sender, EventArgs e)
        {

        }

        private void panel15_hesapnumarasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel16_eskisifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel16_yenisifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel16_yenisifretekrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel16_sec_1_Click(object sender, EventArgs e)
        {

        }

        private void panel16_sec_2_Click(object sender, EventArgs e)
        {

        }

        private void panel16_sec_3_Click(object sender, EventArgs e)
        {

        }

        private void panel16_sec_4_Click(object sender, EventArgs e)
        {

        }

        private void panel16_sec_5_Click(object sender, EventArgs e)
        {

        }

        private void panel16_sec_6_Click(object sender, EventArgs e)
        {

        }

        private void panel16_sec_7_Click(object sender, EventArgs e)
        {

        }

        private void panel16_sec_8_Click(object sender, EventArgs e)
        {

        }

        private void panel16_sec_9_Click(object sender, EventArgs e)
        {

        }

        private void panel16_sec_0_Click(object sender, EventArgs e)
        {

        }

        private void panel16_sec_eksi_Click(object sender, EventArgs e)
        {

        }

        private void panel16_sec_1panel16_sec_arti_Click(object sender, EventArgs e)
        {

        }

        private void panel16_onayla_Click(object sender, EventArgs e)
        {

        }

        private void panel16_duzeltme_Click(object sender, EventArgs e)
        {

        }

        private void panel16_iptal_Click(object sender, EventArgs e)
        {

        }

        private void panel17_yeniislem_Click(object sender, EventArgs e)
        {

        }

        private void panel17_kartiade_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void giris_sec_2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
