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
using System.Data;

namespace SimulationofATMBANK
{
    public partial class ATMArayüzSON : Form
    {
        int numara, Sifre, HesapNo , kullanılacakMiktar,EkHesap1,EkHesap2,EkHesap1Bakiye,EkHesap2Bakiye,Bakiye,KullanıcıID,i,gonderilecekHesapNo,gonderilenBakiye;
        string kontrol,Musteriİsim,MusteriSoyİsim,HesapKontrol;

        public ATMArayüzSON()
        {
            InitializeComponent();
        }

        private void ParacekmeMakbuzGosterPanel4()
        {
            label27.Text = HesapNo.ToString();
            label28.Text = Musteriİsim + " " + MusteriSoyİsim;
            label29.Text = kullanılacakMiktar.ToString();
            label30.Text = Bakiye.ToString();
        } // Halledildi

        private void ParacekmeBilgiGosterPanel14()
        {
            Bakiye -= kullanılacakMiktar;
            SqlConnection con;
            con = new SqlConnection("Data Source=BOĞAÇHAN-;Initial Catalog=Bankamatik;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            con.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Hesap Set  Bakiye='" + Bakiye + "' Where HesapNo='" + HesapNo + "' ", con);
            SqlDataReader oku = sqlCommand.ExecuteReader();

            oku.Read();
            oku.Close();
            oku.Dispose();

            label92.Text = (Bakiye + kullanılacakMiktar).ToString();
            label91.Text = kullanılacakMiktar.ToString();
            label90.Text = Bakiye.ToString();

        } // Halledildi

        private void GuncelBakiyeGosterme()
        {
            label109.Text = HesapNo.ToString();
            label108.Text = Musteriİsim + " " + MusteriSoyİsim;
            label107.Text = Bakiye.ToString();
        } //Halledildi

        private void ParaYatırmaBilgiGosterPanel19()
        {
            if(HesapKontrol=="EkHesap1")
            {
                label132.Text = EkHesap1.ToString();
                label131.Text = Musteriİsim + " " + MusteriSoyİsim;
                label130.Text = kullanılacakMiktar.ToString();
                label129.Text = EkHesap1Bakiye.ToString();
            }
            else if (HesapKontrol == "EkHesap2")
            {
                label132.Text = EkHesap2.ToString();
                label131.Text = Musteriİsim + " " + MusteriSoyİsim;
                label130.Text = kullanılacakMiktar.ToString();
                label129.Text = EkHesap2Bakiye.ToString();
            }
            else
            {
                label132.Text = HesapNo.ToString();
                label131.Text = Musteriİsim + " " + MusteriSoyİsim;
                label130.Text = kullanılacakMiktar.ToString();
                label129.Text = Bakiye.ToString();
            }
        } //Halledildi
        
        private void SifreDegistir()
        {
            SqlConnection con;
            con = new SqlConnection("Data Source=BOĞAÇHAN-;Initial Catalog=Bankamatik;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            con.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Kullanıcı Set  KullanıcıSifre='" + Convert.ToInt32(textBox6.Text) + "' Where KullanıcıID='" + KullanıcıID + "' ", con);
            SqlDataReader oku = sqlCommand.ExecuteReader();

            oku.Read();
            oku.Close();
            oku.Dispose();
            con.Close();
            con.Dispose();
        } //Halledildi

        private void ParaTransferUpdate()
        {
            Bakiye -= kullanılacakMiktar;
            SqlConnection con;
            con = new SqlConnection("Data Source=BOĞAÇHAN-;Initial Catalog=Bankamatik;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            con.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Hesap Set  Bakiye='" + Bakiye + "' Where HesapNo='" + HesapNo + "' ", con);
            SqlDataReader oku = sqlCommand.ExecuteReader();

            oku.Read();
            oku.Close();
            oku.Dispose();

            SqlCommand sqlCommand2 = new SqlCommand("select Bakiye from Hesap where HesapNo='" + gonderilecekHesapNo + "'", con);
            SqlDataReader oku2 = sqlCommand2.ExecuteReader();

            oku2.Read();
            gonderilenBakiye = Convert.ToInt32(oku2["Bakiye"].ToString());
            oku2.Close();
            oku2.Dispose();

            gonderilenBakiye += kullanılacakMiktar;
            SqlCommand sqlCommand1 = new SqlCommand("Update Hesap Set  Bakiye='" + gonderilenBakiye + "' Where HesapNo='" + gonderilecekHesapNo + "' ", con);
            SqlDataReader oku1 = sqlCommand1.ExecuteReader();

            oku1.Read();
            oku1.Close();
            oku1.Dispose();
            con.Close();
            con.Dispose();
        } //Halledildi

        private void ParaYatırmaPanel8(int kullanılacakMiktar)
        {
            
            SqlConnection con;
            con = new SqlConnection("Data Source=BOĞAÇHAN-;Initial Catalog=Bankamatik;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            con.Open();
            if (HesapKontrol == "EkHesap1")
            {
                EkHesap1Bakiye += kullanılacakMiktar;
                SqlCommand sqlCommand = new SqlCommand("Update Hesap Set  Bakiye='" + EkHesap1Bakiye + "' Where HesapNo='" + EkHesap1 + "' ", con);
                SqlDataReader oku = sqlCommand.ExecuteReader();
                oku.Read();
                oku.Close();
                oku.Dispose();
            }
            else if (HesapKontrol == "EkHesap2")
            {
                EkHesap2Bakiye += kullanılacakMiktar;
                SqlCommand sqlCommand1 = new SqlCommand("Update Hesap Set  Bakiye='" + EkHesap2Bakiye + "' Where HesapNo='" + EkHesap2 + "' ", con);
                SqlDataReader oku = sqlCommand1.ExecuteReader();
                oku.Read();
                oku.Close();
                oku.Dispose();
            }
            else
            {
                Bakiye += kullanılacakMiktar;
                SqlCommand sqlCommand2 = new SqlCommand("Update Hesap Set  Bakiye='" + Bakiye + "' Where HesapNo='" + HesapNo + "' ", con);
                SqlDataReader oku = sqlCommand2.ExecuteReader();
                oku.Read();
                oku.Close();
                oku.Dispose();
            }
           
        } //Halledildi

        private void ParaTransferGosterim()
        {
            label61.Text = gonderilecekHesapNo.ToString();
            label69.Text = HesapNo.ToString();
            label60.Text = Musteriİsim + " " + MusteriSoyİsim;
            label59.Text = kullanılacakMiktar.ToString();
            label58.Text = Bakiye.ToString();
        } //Halledildi


        private void ATMArayüzSON_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = true; 
            panel23.Visible = false;
            panel24.Visible = false;
            panel25.Visible = false;
            panel26.Visible = false; 
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            
            if (panel3.Visible == true)
            {
                kullanılacakMiktar = 10;
                if (Bakiye - kullanılacakMiktar < 0)
                {
                    panel3.Visible = false;
                    panel24.Visible = true;
                }
                else
                {
                    panel3.Visible = false;
                    panel14.Visible = true;
                    ParacekmeBilgiGosterPanel14();
                }
            }
            else if (panel12.Visible == true)
            {
                panel12.Visible = false;
                HesapKontrol = "EkHesap1";
                panel7.Visible = true;
            }
            else if (panel13.Visible == true)
            {
               
                panel13.Visible = false;
                if (HesapNo == 111111 || HesapNo == 222222 || HesapNo == 333333)
                {
                    gonderilecekHesapNo = 444444;
                }
                else if (HesapNo == 444444 || HesapNo == 555555 || HesapNo == 666666)
                {
                    gonderilecekHesapNo = 111111;
                }
                else if (HesapNo == 777777 || HesapNo == 888888 || HesapNo == 999999)
                {
                    gonderilecekHesapNo = 444444;
                }
                panel20.Visible = true;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
            }
            else if (panel2.Visible == true)
            {
                panel2.Visible = false;
                panel3.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                kullanılacakMiktar = 20;
                if (Bakiye - kullanılacakMiktar < 0)
                {
                    panel3.Visible = false;
                    panel24.Visible = true;
                }
                else
                {
                    panel3.Visible = false;
                    panel14.Visible = true;
                    ParacekmeBilgiGosterPanel14();
                }
            }
            else if (panel6.Visible == true)
            {
                panel6.Visible = false;
                HesapKontrol = "KartınHesabı";
                panel7.Visible = true;
            }
            else if (panel11.Visible == true)
            {
                panel11.Visible = false;
                if (HesapNo == 111111 || HesapNo == 222222 || HesapNo == 333333)
                {
                    label168.Text="Hesap No :" + "444444" + " İsim Soyİsim : Merve Şensoy";
                    label167.Text = "Hesap No :" + "777777" + " İsim Soyİsim : Ekrem Aksoy";
                }
                else if (HesapNo == 444444 || HesapNo == 555555 || HesapNo == 666666)
                {
                    label168.Text = "Hesap No :" + "111111" + " İsim Soyİsim : Boğaçhan Gençtürk";
                    label167.Text = "Hesap No :" + "777777" + " İsim Soyİsim : Ekrem Aksoy";
                }
                else if (HesapNo == 777777 || HesapNo == 888888 || HesapNo == 999999)
                {
                    label168.Text = "Hesap No :" + "444444" + " İsim Soyİsim : Merve Şensoy";
                    label167.Text = "Hesap No :" + "222222" + " İsim Soyİsim : Boğaçhan Gençtürk";
                }
                panel13.Visible = true;
            }
            else if (panel12.Visible == true)
            {
                panel12.Visible = false;
                HesapKontrol = "EkHesap2";
                panel7.Visible = true;
            }
            else if (panel13.Visible == true)
            {
                panel13.Visible = false;
                if (HesapNo == 111111 || HesapNo == 222222 || HesapNo == 333333)
                {
                    gonderilecekHesapNo = 777777;
                }
                else if (HesapNo == 444444 || HesapNo == 555555 || HesapNo == 666666)
                {
                    gonderilecekHesapNo = 777777;
                }
                else if (HesapNo == 777777 || HesapNo == 888888 || HesapNo == 999999)
                {
                    gonderilecekHesapNo = 222222;
                }
                panel20.Visible = true;
            }
            else if (panel15.Visible == true)
            {
                panel15.Visible = false;
                GuncelBakiyeGosterme();
                panel16.Visible = true;
            }
            else if (panel26.Visible == true)
            {
                panel26.Visible = false;
                panel17.Visible = true;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
                panel6.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                kullanılacakMiktar = 30;
                if (Bakiye - kullanılacakMiktar < 0)
                {
                    panel3.Visible = false;
                    panel24.Visible = true;
                }
                else
                {
                    panel3.Visible = false;
                    panel14.Visible = true;
                    ParacekmeBilgiGosterPanel14();
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel22.Visible = true;
                kontrol = null;
                textBox1.Clear();
            }
            else if (panel2.Visible == true)
            {
                panel2.Visible = false;
                panel11.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                kullanılacakMiktar = 50;
                if (Bakiye - kullanılacakMiktar < 0)
                {
                    panel3.Visible = false;
                    panel24.Visible = true;
                }
                else
                {
                    panel3.Visible = false;
                    panel14.Visible = true;
                    ParacekmeBilgiGosterPanel14();
                }
            }
            else if (panel4.Visible == true)
            {
                panel4.Visible = false;
                panel2.Visible = true;
            }
            else if (panel5.Visible == true)
            {
                panel5.Visible = false;
                panel2.Visible = true;
                textBox2.Clear();
            }
            else if (panel6.Visible == true)
            {
                panel6.Visible = false;
                panel2.Visible = true;
            }
            else if (panel7.Visible == true)
            {
                panel7.Visible = false;
                panel2.Visible = true;
                textBox3.Clear();
            }
            else if (panel8.Visible == true)
            {
                panel8.Visible = false;
                panel18.Visible = true;
            }
            else if (panel9.Visible == true)
            {
                panel9.Visible = false;
                panel2.Visible = true;
            }
            else if (panel10.Visible == true)
            {
                panel10.Visible = false;
                panel2.Visible = true;
                textBox4.Clear();
            }
            else if (panel11.Visible == true)
            {
                panel11.Visible = false;
                panel2.Visible = true;
            }
            else if (panel12.Visible == true)
            {
                panel12.Visible = false;
                panel2.Visible = true;
            }
            else if (panel13.Visible == true)
            {
                panel13.Visible = false;
                panel2.Visible = true;
            }
            else if (panel14.Visible == true)
            {
                panel14.Visible = false;
                panel18.Visible = true;
            }
            else if (panel15.Visible == true)
            {
                panel15.Visible = false;
                panel2.Visible = true;
            }
            else if (panel16.Visible == true)
            {
                panel16.Visible = false;
                panel2.Visible = true;
            }
            else if (panel17.Visible == true)
            {
                panel17.Visible = false;
                panel2.Visible = true;
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
            else if (panel18.Visible == true)
            {
                panel18.Visible = false;
                panel2.Visible = true;
            }
            else if (panel19.Visible == true)
            {
                panel19.Visible = false;
                panel2.Visible = true;
            }
            else if (panel20.Visible == true)
            {
                panel20.Visible = false;
                panel2.Visible = true;
                textBox8.Clear();
            }
            else if (panel21.Visible == true)
            {
                panel21.Visible = false;
                panel18.Visible = true;
            }
            else if (panel23.Visible == true)
            {
                panel23.Visible = false;
                panel22.Visible = true;
                textBox9.Clear();
            }
            else if (panel24.Visible == true)
            {
                panel24.Visible = false;
                panel2.Visible = true;
            }
            else if (panel25.Visible == true)
            {
                panel25.Visible = false;
                panel2.Visible = true;
            }
            else if (panel26.Visible == true)
            {
                panel26.Visible = false;
                panel2.Visible = true;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                kullanılacakMiktar = 50;
                if (Bakiye - kullanılacakMiktar < 0)
                {
                    panel2.Visible = false;
                    panel24.Visible = true;
                }
                else
                {
                    panel2.Visible = false;
                    panel14.Visible = true;
                    ParacekmeBilgiGosterPanel14();
                }
            }
            else if (panel3.Visible == true)
            {
                kullanılacakMiktar = 100;
                if (Bakiye - kullanılacakMiktar < 0)
                {
                    panel3.Visible = false;
                    panel24.Visible = true;
                }
                else
                {
                    panel3.Visible = false;
                    panel14.Visible = true;
                    ParacekmeBilgiGosterPanel14();
                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
                panel15.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                kullanılacakMiktar = 250;
                if (Bakiye - kullanılacakMiktar < 0)
                {
                    panel3.Visible = false;
                    panel24.Visible = true;
                }
                else
                {
                    panel3.Visible = false;
                    panel14.Visible = true;
                    ParacekmeBilgiGosterPanel14();
                }
            }
            else if (panel6.Visible == true)
            {
                panel6.Visible = false;
                label165.Text = "Hesap No " +EkHesap1.ToString();
                label166.Text = "Hesap No " + EkHesap2.ToString();
                panel12.Visible = true;
            }
            else if (panel11.Visible == true)
            {
                panel11.Visible = false;
                panel10.Visible = true;
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
                panel26.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                kullanılacakMiktar = 1000;
                if (Bakiye - kullanılacakMiktar < 0)
                {
                    panel3.Visible = false;
                    panel24.Visible = true;
                }
                else
                {
                    panel3.Visible = false;
                    panel14.Visible = true;
                    ParacekmeBilgiGosterPanel14();
                }
            }
           
            else if (panel5.Visible == true)
            {
                textBox2.Text += numara.ToString();
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                if (Sifre == Convert.ToInt32(textBox1.Text))
                {
                    SqlConnection con;
                    con = new SqlConnection("Data Source=BOĞAÇHAN-;Initial Catalog=Bankamatik;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand("select k.Kullanıcıİsim,k.KullanıcıSoyİsim,k.KullanıcıID from Hesap h , Kullanıcı k where h.HesapNo='" + HesapNo + "'and k.KullanıcıID=h.KullanıcıID ", con);
                    SqlDataReader oku = sqlCommand.ExecuteReader();

                    oku.Read();
                    Musteriİsim = oku["Kullanıcıİsim"].ToString();
                    MusteriSoyİsim = oku["KullanıcıSoyİsim"].ToString();
                    KullanıcıID = Convert.ToInt32(oku["KullanıcıID"].ToString());

                    
                    oku.Close();
                    oku.Dispose();

                    SqlCommand sqlCommand1 = new SqlCommand("select MIN(h.HesapNo),AVG(h.HesapNo),MAX(h.HesapNo) from Hesap h , Kullanıcı k where  k.KullanıcıID='" + KullanıcıID + "'and k.KullanıcıID=h.KullanıcıID", con);
                    SqlDataReader oku1 = sqlCommand1.ExecuteReader();

                    oku1.Read();
                    if(HesapNo==Convert.ToInt32(oku1[0].ToString()))
                    {
                        EkHesap1 = Convert.ToInt32(oku1[1].ToString());
                        EkHesap2 = Convert.ToInt32(oku1[2].ToString());
                    }
                    else if (HesapNo == Convert.ToInt32(oku1[1].ToString()))
                    {
                        EkHesap1 = Convert.ToInt32(oku1[0].ToString());
                        EkHesap2 = Convert.ToInt32(oku1[2].ToString());
                    }
                    else if (HesapNo == Convert.ToInt32(oku1[2].ToString()))
                    {
                        EkHesap1 = Convert.ToInt32(oku1[0].ToString());
                        EkHesap2 = Convert.ToInt32(oku1[1].ToString());
                    }

                    oku1.Close();
                    oku1.Dispose();

                    for(i=0;i<3;i++)
                    {
                        int saglayici;
                        if(i==0)
                            saglayici=HesapNo;
                        else if(i==1)
                            saglayici=EkHesap1;
                        else
                            saglayici=EkHesap2;

                        SqlCommand sqlCommand2 = new SqlCommand("select h.Bakiye from Hesap h , Kullanıcı k where  h.HesapNo='" + saglayici + "'and k.KullanıcıID=h.KullanıcıID", con);
                        SqlDataReader oku2 = sqlCommand2.ExecuteReader();

                        oku2.Read();
                        if (i == 0)
                            Bakiye = Convert.ToInt32(oku2["Bakiye"].ToString());
                        else if (i == 1)
                            EkHesap1Bakiye = Convert.ToInt32(oku2["Bakiye"].ToString());
                        else
                            EkHesap2Bakiye = Convert.ToInt32(oku2["Bakiye"].ToString());
                      
                        oku2.Close();
                        oku2.Dispose();
                    }
                    con.Close();
                    con.Dispose();
                    textBox1.Clear();
                    panel1.Visible = false;
                    panel2.Visible = true;
                }
                else
                    MessageBox.Show("Yanlış Şifre!");
            }

            else if (panel2.Visible == true)
            {
                panel2.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel3.Visible == true)
            {
                panel3.Visible = false;
                panel5.Visible = true;
            }
            else if (panel4.Visible == true)
            {
                panel4.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel5.Visible == true)
            {
                if (Convert.ToInt32(textBox2.Text) % 10 != 0 || Convert.ToInt32(textBox2.Text) == 0 || textBox2.Text == null)
                {
                    panel5.Visible = false;
                    panel25.Visible = true;
                }
                else
                {
                    panel5.Visible = false;
                    panel14.Visible = true;
                    kullanılacakMiktar = Convert.ToInt32(textBox2.Text);
                    ParacekmeBilgiGosterPanel14();
                }
                textBox2.Clear();
            }
            else if (panel6.Visible == true)
            {
                panel6.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel7.Visible == true)
            {
                if (Convert.ToInt32(textBox3.Text) % 5 != 0 || Convert.ToInt32(textBox3.Text) == 0 || textBox3.Text == null)
                {
                    panel7.Visible = false;
                    panel25.Visible = true;
                }
                else
                {
                    panel7.Visible = false;
                    panel8.Visible = true;
                    kullanılacakMiktar = Convert.ToInt32(textBox3.Text);
                    ParaYatırmaPanel8(kullanılacakMiktar);
                }
                textBox3.Clear();
            }
            else if (panel8.Visible == true)
            {
                panel8.Visible = false;
                ParaYatırmaBilgiGosterPanel19();
                panel19.Visible = true;
                
            }
            else if (panel9.Visible == true)
            {
                panel9.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel10.Visible == true)
            {
                SqlConnection con;
                con = new SqlConnection("Data Source=BOĞAÇHAN-;Initial Catalog=Bankamatik;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

                con.Open();

                SqlCommand sqlCommand = new SqlCommand("select h.HesapNo from Hesap h where HesapNo='" + textBox4.Text + "'", con);
                SqlDataReader oku = sqlCommand.ExecuteReader();

                if (oku.Read())
                {
                    gonderilecekHesapNo = Convert.ToInt32(oku["HesapNo"].ToString());
                    panel10.Visible = false;
                    panel20.Visible = true;
                }
                else
                {
                    panel10.Visible = false;
                    panel25.Visible = true;
                }
                oku.Close();
                oku.Dispose();

                con.Close();
                con.Dispose();
                textBox4.Clear();
            }
            else if (panel11.Visible == true)
            {
                panel11.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel12.Visible == true)
            {
                panel12.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel13.Visible == true)
            {
                panel13.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel14.Visible == true)
            {
                panel14.Visible = false;
                ParacekmeMakbuzGosterPanel4();
                panel4.Visible = true;
            }
            else if (panel15.Visible == true)
            {
                panel15.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel16.Visible == true)
            {
                panel16.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel17.Visible == true)
            {
                if (textBox5.Text == Sifre.ToString() && textBox6.Text == textBox7.Text)
                {
                    SifreDegistir();
                    panel17.Visible=false;
                    panel18.Visible=true;
                }
                else
                {
                    panel17.Visible = false;
                    panel25.Visible = true;
                }
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
            else if (panel18.Visible == true)
            {
                panel18.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel19.Visible == true)
            {
                panel19.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel20.Visible == true)
            {
                if (Convert.ToInt32(textBox8.Text) % 5 != 0 || Convert.ToInt32(textBox8.Text) == 0 || textBox8.Text == null)
                {
                    panel20.Visible = false;
                    panel25.Visible = true;
                }
                else if (Bakiye - Convert.ToInt32(textBox8.Text) < 0)
                {
                    panel20.Visible = false;
                    panel24.Visible = true;
                }
                else
                {
                    panel20.Visible = false;
                    panel21.Visible = true;
                    kullanılacakMiktar = Convert.ToInt32(textBox8.Text);
                    ParaTransferUpdate();
                }
                textBox8.Clear();
            }
            else if (panel21.Visible == true)
            {
                panel21.Visible = false;
                ParaTransferGosterim();
                panel9.Visible = true;
            }
            else if (panel22.Visible == true)
            {
                panel22.Visible = false;
                panel23.Visible = true;
            }
            else if (panel23.Visible == true)
            {
                SqlConnection con;
                con = new SqlConnection("Data Source=BOĞAÇHAN-;Initial Catalog=Bankamatik;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                con.Open();

                SqlCommand sqlCommand = new SqlCommand("select h.HesapNo,k.KullanıcıSifre from Hesap h , Kullanıcı k where HesapNo='" + textBox9.Text + "'and k.KullanıcıID=h.KullanıcıID ", con);
                SqlDataReader oku = sqlCommand.ExecuteReader();

                if (oku.Read())
                {
                    HesapNo = Convert.ToInt32(oku["HesapNo"].ToString());
                    Sifre = Convert.ToInt32(oku["KullanıcıSifre"].ToString());
                    kontrol = "Kartsız Giriş";
                    panel23.Visible = false;
                    panel1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Böyle Bir Hesap Numarası Mevcut Değildir Tekrar Deneyin!");
                }
                oku.Close();
                oku.Dispose();

                con.Close();
                con.Dispose();
                textBox9.Clear();
            }
            else if (panel24.Visible == true)
            {
                panel24.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel25.Visible == true)
            {
                panel25.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel26.Visible == true)
            {
                panel26.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            numara = 1;
            if (panel1.Visible == true)
            {
                textBox1.Text += numara.ToString();
            }
            
            else if (panel5.Visible == true)
            {
                textBox2.Text += numara.ToString();
            }
            
            else if (panel7.Visible == true)
            {
                textBox3.Text += numara.ToString();
            }
            
            else if (panel10.Visible == true)
            {
                textBox4.Text += numara.ToString();
            }

            else if (panel17.Visible == true)
            {
                textBox5.Text += numara.ToString();
                textBox6.Text += numara.ToString();
                textBox7.Text += numara.ToString();
            }

            else if (panel20.Visible == true)
            {
                textBox8.Text += numara.ToString();
            }

            else if (panel23.Visible == true)
            {
                textBox9.Text += numara.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            numara = 2;
            if (panel1.Visible == true)
            {
                textBox1.Text += numara.ToString();
            }

            else if (panel5.Visible == true)
            {
                textBox2.Text += numara.ToString();
            }

            else if (panel7.Visible == true)
            {
                textBox3.Text += numara.ToString();
            }

            else if (panel10.Visible == true)
            {
                textBox4.Text += numara.ToString();
            }

            else if (panel17.Visible == true)
            {
                textBox5.Text += numara.ToString();
                textBox6.Text += numara.ToString();
                textBox7.Text += numara.ToString();
            }

            else if (panel20.Visible == true)
            {
                textBox8.Text += numara.ToString();
            }

            else if (panel23.Visible == true)
            {
                textBox9.Text += numara.ToString();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            numara = 3;
            if (panel1.Visible == true)
            {
                textBox1.Text += numara.ToString();
            }

            else if (panel5.Visible == true)
            {
                textBox2.Text += numara.ToString();
            }

            else if (panel7.Visible == true)
            {
                textBox3.Text += numara.ToString();
            }

            else if (panel10.Visible == true)
            {
                textBox4.Text += numara.ToString();
            }

            else if (panel17.Visible == true)
            {
                textBox5.Text += numara.ToString();
                textBox6.Text += numara.ToString();
                textBox7.Text += numara.ToString();
            }

            else if (panel20.Visible == true)
            {
                textBox8.Text += numara.ToString();
            }

            else if (panel23.Visible == true)
            {
                textBox9.Text += numara.ToString();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            numara = 4;
            if (panel1.Visible == true)
            {
                textBox1.Text += numara.ToString();
            }

            else if (panel5.Visible == true)
            {
                textBox2.Text += numara.ToString();
            }

            else if (panel7.Visible == true)
            {
                textBox3.Text += numara.ToString();
            }

            else if (panel10.Visible == true)
            {
                textBox4.Text += numara.ToString();
            }

            else if (panel17.Visible == true)
            {
                textBox5.Text += numara.ToString();
                textBox6.Text += numara.ToString();
                textBox7.Text += numara.ToString();
            }

            else if (panel20.Visible == true)
            {
                textBox8.Text += numara.ToString();
            }

            else if (panel23.Visible == true)
            {
                textBox9.Text += numara.ToString();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            numara = 5;
            if (panel1.Visible == true)
            {
                textBox1.Text += numara.ToString();
            }

            else if (panel5.Visible == true)
            {
                textBox2.Text += numara.ToString();
            }

            else if (panel7.Visible == true)
            {
                textBox3.Text += numara.ToString();
            }

            else if (panel10.Visible == true)
            {
                textBox4.Text += numara.ToString();
            }

            else if (panel17.Visible == true)
            {
                textBox5.Text += numara.ToString();
                textBox6.Text += numara.ToString();
                textBox7.Text += numara.ToString();
            }

            else if (panel20.Visible == true)
            {
                textBox8.Text += numara.ToString();
            }

            else if (panel23.Visible == true)
            {
                textBox9.Text += numara.ToString();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            numara = 6;
            if (panel1.Visible == true)
            {
                textBox1.Text += numara.ToString();
            }

            else if (panel5.Visible == true)
            {
                textBox2.Text += numara.ToString();
            }

            else if (panel7.Visible == true)
            {
                textBox3.Text += numara.ToString();
            }

            else if (panel10.Visible == true)
            {
                textBox4.Text += numara.ToString();
            }

            else if (panel17.Visible == true)
            {
                textBox5.Text += numara.ToString();
                textBox6.Text += numara.ToString();
                textBox7.Text += numara.ToString();
            }

            else if (panel20.Visible == true)
            {
                textBox8.Text += numara.ToString();
            }

            else if (panel23.Visible == true)
            {
                textBox9.Text += numara.ToString();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            numara = 7;
            if (panel1.Visible == true)
            {
                textBox1.Text += numara.ToString();
            }

            else if (panel5.Visible == true)
            {
                textBox2.Text += numara.ToString();
            }

            else if (panel7.Visible == true)
            {
                textBox3.Text += numara.ToString();
            }

            else if (panel10.Visible == true)
            {
                textBox4.Text += numara.ToString();
            }

            else if (panel17.Visible == true)
            {
                textBox5.Text += numara.ToString();
                textBox6.Text += numara.ToString();
                textBox7.Text += numara.ToString();
            }

            else if (panel20.Visible == true)
            {
                textBox8.Text += numara.ToString();
            }

            else if (panel23.Visible == true)
            {
                textBox9.Text += numara.ToString();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            numara = 8;
            if (panel1.Visible == true)
            {
                textBox1.Text += numara.ToString();
            }

            else if (panel5.Visible == true)
            {
                textBox2.Text += numara.ToString();
            }

            else if (panel7.Visible == true)
            {
                textBox3.Text += numara.ToString();
            }

            else if (panel10.Visible == true)
            {
                textBox4.Text += numara.ToString();
            }

            else if (panel17.Visible == true)
            {
                textBox5.Text += numara.ToString();
                textBox6.Text += numara.ToString();
                textBox7.Text += numara.ToString();
            }

            else if (panel20.Visible == true)
            {
                textBox8.Text += numara.ToString();
            }

            else if (panel23.Visible == true)
            {
                textBox9.Text += numara.ToString();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            numara = 9;
            if (panel1.Visible == true)
            {
                textBox1.Text += numara.ToString();
            }

            else if (panel5.Visible == true)
            {
                textBox2.Text += numara.ToString();
            }

            else if (panel7.Visible == true)
            {
                textBox3.Text += numara.ToString();
            }

            else if (panel10.Visible == true)
            {
                textBox4.Text += numara.ToString();
            }

            else if (panel17.Visible == true)
            {
                textBox5.Text += numara.ToString();
                textBox6.Text += numara.ToString();
                textBox7.Text += numara.ToString();
            }

            else if (panel20.Visible == true)
            {
                textBox8.Text += numara.ToString();
            }

            else if (panel23.Visible == true)
            {
                textBox9.Text += numara.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            numara = 0;
            if (panel1.Visible == true)
            {
                textBox1.Text += numara.ToString();
            }

            else if (panel5.Visible == true)
            {
                textBox2.Text += numara.ToString();
            }

            else if (panel7.Visible == true)
            {
                textBox3.Text += numara.ToString();
            }

            else if (panel10.Visible == true)
            {
                textBox4.Text += numara.ToString();
            }

            else if (panel17.Visible == true)
            {
                textBox5.Text += numara.ToString();
                textBox6.Text += numara.ToString();
                textBox7.Text += numara.ToString();
            }

            else if (panel20.Visible == true)
            {
                textBox8.Text += numara.ToString();
            }

            else if (panel23.Visible == true)
            {
                textBox9.Text += numara.ToString();
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

            else if (panel5.Visible == true)
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }

            else if (panel7.Visible == true)
            {
                textBox3.Text = textBox3.Text.Substring(0, textBox3.Text.Length - 1);
            }

            else if (panel10.Visible == true)
            {
                textBox4.Text = textBox4.Text.Substring(0, textBox4.Text.Length - 1);
            }

            else if (panel17.Visible == true)
            {
                textBox5.Text = textBox5.Text.Substring(0, textBox5.Text.Length - 1);
                textBox6.Text = textBox6.Text.Substring(0, textBox6.Text.Length - 1);
                textBox7.Text = textBox7.Text.Substring(0, textBox7.Text.Length - 1);
            }

            else if (panel20.Visible == true)
            {
                textBox8.Text = textBox8.Text.Substring(0, textBox8.Text.Length - 1);
            }

            else if (panel23.Visible == true)
            {
                textBox9.Text = textBox9.Text.Substring(0, textBox9.Text.Length - 1);
            }
        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label114_Click(object sender, EventArgs e)
        {

        }

        private void label113_Click(object sender, EventArgs e)
        {

        }

        private void label115_Click(object sender, EventArgs e)
        {

        }

        private void label116_Click(object sender, EventArgs e)
        {

        }

        private void label117_Click(object sender, EventArgs e)
        {

        }

        private void label118_Click(object sender, EventArgs e)
        {

        }

        private void label119_Click(object sender, EventArgs e)
        {

        }

        private void label120_Click(object sender, EventArgs e)
        {

        }

        private void label121_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void label129_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void label133_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }
        private void label140_Click(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void label151_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (panel22.Visible == true)
            {
                kontrol = "Insert Card";
                HesapNo = 111111;
                Sifre = 6110;
                panel22.Visible = false;
                panel1.Visible = true;
            }
            else if (panel23.Visible == true)
            {
                MessageBox.Show("İşlem İptal Edildi.Kartla Giriş Sağlanıyor!");
                HesapNo = 111111;
                Sifre = 6110;
                kontrol = "Insert Card";
                panel23.Visible = false;
                panel1.Visible = true;
            }
            else if (kontrol == "Insert Card")
            {
                MessageBox.Show("Kart Zaten Takılmış Durumda!");
            }
            else if (kontrol == "Kartsız Giriş")
            {
                MessageBox.Show("Oturumu Sonlandırmadan Kartı Yerleştiremezsiniz!");
            }

        }

        private void label144_Click(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


    }
}

 