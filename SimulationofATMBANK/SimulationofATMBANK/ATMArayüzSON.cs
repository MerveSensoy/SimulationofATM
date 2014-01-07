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
        int numara, Sifre, HesapNo , cekilecekMiktar,EkHesap1,EkHesap2,EkHesap1Bakiye,EkHesap2Bakiye,Bakiye,KullanıcıID,i;
        string kontrol,Musteriİsim,MusteriSoyİsim,İslemTipi;
        public ATMArayüzSON()
        {
            InitializeComponent();
        }

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
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
            }
            else if (panel2.Visible == true)
            {
            }
            else if (panel3.Visible == true)
            {
                cekilecekMiktar = 10;
                panel3.Visible = false;
                panel14.Visible = true;
            }
            else if (panel4.Visible == true)
            {
            }
            else if (panel5.Visible == true)
            {
            }
            //else if (panel6.Visible == true)
            //{
            //}
            //else if (panel7.Visible == true)
            //{
            //}
            //else if (panel8.Visible == true)
            //{
            //}
            //else if (panel9.Visible == true)
            //{
            //}
            //else if (panel10.Visible == true)
            //{
            //}
            //else if (panel11.Visible == true)
            //{
            //}
            else if (panel12.Visible == true)
            {
                panel12.Visible = false;
                panel7.Visible = true;
            }
            else if (panel13.Visible == true)
            {
               
                panel13.Visible = false;
                panel20.Visible = true;
            }
            //else if (panel14.Visible == true)
            //{
            //}
            //else if (panel15.Visible == true)
            //{
            //}
            //else if (panel16.Visible == true)
            //{
            //}
            //else if (panel17.Visible == true)
            //{
            //}
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
                cekilecekMiktar = 20;
                panel3.Visible = false;
                panel14.Visible = true;
            }
            else if (panel4.Visible == true)
            {
            }
            else if (panel5.Visible == true)
            {
            }
            else if (panel6.Visible == true)
            {
                panel6.Visible = false;
                panel7.Visible = true;
            }
            //else if (panel7.Visible == true)
            //{
            //}
            //else if (panel8.Visible == true)
            //{
            //}
            //else if (panel9.Visible == true)
            //{
            //}
            //else if (panel10.Visible == true)
            //{
            //}
            else if (panel11.Visible == true)
            {
                panel11.Visible = false;
                panel13.Visible = true;
            }
            else if (panel12.Visible == true)
            {
                panel12.Visible = false;
                panel7.Visible = true;
            }
            else if (panel13.Visible == true)
            {
                panel13.Visible = false;
                panel20.Visible = true;
            }
            //else if (panel14.Visible == true)
            //{
            //}
            else if (panel15.Visible == true)
            {
                panel15.Visible = false;
                panel16.Visible = true;
            }
            //else if (panel16.Visible == true)
            //{
            //}
            //else if (panel17.Visible == true)
            //{
            //}
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
            }
            else if (panel2.Visible == true)
            {
                panel2.Visible = false;
                panel6.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                cekilecekMiktar = 30;
                panel3.Visible = false;
                panel14.Visible = true;
            }
            else if (panel4.Visible == true)
            {
            }
            else if (panel5.Visible == true)
            {
            }
            //else if (panel6.Visible == true)
            //{
            //}
            //else if (panel7.Visible == true)
            //{
            //}
            //else if (panel8.Visible == true)
            //{
            //}
            //else if (panel9.Visible == true)
            //{
            //}
            //else if (panel10.Visible == true)
            //{
            //}
            //else if (panel11.Visible == true)
            //{
            //}
            //else if (panel12.Visible == true)
            //{
            //}
            //else if (panel13.Visible == true)
            //{
            //}
            //else if (panel14.Visible == true)
            //{
            //}
            //else if (panel15.Visible == true)
            //{
            //}
            //else if (panel16.Visible == true)
            //{
            //}
            //else if (panel17.Visible == true)
            //{
            //}
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel2.Visible == true)
            {
                panel2.Visible = false;
                panel11.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                cekilecekMiktar = 50;
                panel3.Visible = false;
                panel14.Visible = true;
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
            }
            else if (panel24.Visible == true)
            {
                panel24.Visible = false;
                panel2.Visible = true;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
            }
            else if (panel2.Visible == true)
            {
                panel2.Visible = false;
                //50 tl çekilmesi için işlemler sağlanacak
                panel14.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                cekilecekMiktar = 100;
                panel3.Visible = false;
                panel14.Visible = true;
            }
            else if (panel4.Visible == true)
            {
            }
            else if (panel5.Visible == true)
            {
            }
            //else if (panel6.Visible == true)
            //{
            //}
            //else if (panel7.Visible == true)
            //{
            //}
            //else if (panel8.Visible == true)
            //{
            //}
            //else if (panel9.Visible == true)
            //{
            //}
            //else if (panel10.Visible == true)
            //{
            //}
            //else if (panel11.Visible == true)
            //{
            //}
            //else if (panel12.Visible == true)
            //{
            //}
            //else if (panel13.Visible == true)
            //{
            //}
            //else if (panel14.Visible == true)
            //{
            //}
            //else if (panel15.Visible == true)
            //{
            //}
            //else if (panel16.Visible == true)
            //{
            //}
            //else if (panel17.Visible == true)
            //{
            //}
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
            }
            else if (panel2.Visible == true)
            {
                panel2.Visible = false;
                panel15.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                cekilecekMiktar = 250;
                panel3.Visible = false;
                panel14.Visible = true;
            }
            else if (panel4.Visible == true)
            {
            }
            else if (panel5.Visible == true)
            {
            }
            else if (panel6.Visible == true)
            {
                panel6.Visible = false;
                panel12.Visible = true;
            }
            //else if (panel7.Visible == true)
            //{
            //}
            //else if (panel8.Visible == true)
            //{
            //}
            //else if (panel9.Visible == true)
            //{
            //}
            //else if (panel10.Visible == true)
            //{
            //}
            else if (panel11.Visible == true)
            {
                panel11.Visible = false;
                panel10.Visible = true;
            }
            //else if (panel12.Visible == true)
            //{
            //}
            //else if (panel13.Visible == true)
            //{
            //}
            //else if (panel14.Visible == true)
            //{
            //}
            //else if (panel15.Visible == true)
            //{
            //    panel15.Visible = false;
                
            //}
            //else if (panel16.Visible == true)
            //{
            //}
            //else if (panel17.Visible == true)
            //{
            //}
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
            }
            else if (panel2.Visible == true)
            {
            }
            else if (panel3.Visible == true)
            {
                cekilecekMiktar = 1000;
                panel3.Visible = false;
                panel14.Visible = true;
            }
            else if (panel4.Visible == true)
            {
            }
            else if (panel5.Visible == true)
            {
                textBox2.Text += numara.ToString();
            }
            //else if (panel6.Visible == true)
            //{
            //}
            //else if (panel7.Visible == true)
            //{
            //}
            //else if (panel8.Visible == true)
            //{
            //}
            //else if (panel9.Visible == true)
            //{
            //}
            //else if (panel10.Visible == true)
            //{
            //}
            //else if (panel11.Visible == true)
            //{
            //}
            //else if (panel12.Visible == true)
            //{
            //}
            //else if (panel13.Visible == true)
            //{
            //}
            //else if (panel14.Visible == true)
            //{
            //}
            //else if (panel15.Visible == true)
            //{
            //}
            //else if (panel16.Visible == true)
            //{
            //}
            //else if (panel17.Visible == true)
            //{
            //}
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
                    HesapNo = Convert.ToInt32(oku1[0].ToString());
                    EkHesap1 = Convert.ToInt32(oku1[1].ToString());
                    EkHesap2 = Convert.ToInt32(oku1[2].ToString());
                    MessageBox.Show(HesapNo.ToString() + EkHesap1.ToString() + EkHesap2.ToString());

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
                //Para Çekme İşlemleri Halledilecek
                panel5.Visible = false;
                panel14.Visible = true;
            }
            else if (panel6.Visible == true)
            {
                panel6.Visible = false;
                panel22.Visible = true;
                kontrol = null;
            }
            else if (panel7.Visible == true)
            {
                panel7.Visible = false;
                panel8.Visible = true;
            }
            else if (panel8.Visible == true)
            {
                panel8.Visible = false;
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
                panel10.Visible = false;
                panel20.Visible = true;
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
                //onaylama kaydetme işlemleri gerçekleştirilecek
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
                //onaylama kaydetme işlemleri gerçekleştirilecek
                panel20.Visible = false;
                panel21.Visible = true;
            }
            else if (panel21.Visible == true)
            {
                //onaylama kaydetme işlemleri gerçekleştirilecek
                panel21.Visible = false;
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
            }
            else if (panel24.Visible == true)
            {
                panel24.Visible = false;
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


            if (panel1.Visible == false)
            {
                textBox1.Clear();
            }

            else if (panel5.Visible == false)
            {
                textBox2.Clear();
            }

            else if (panel7.Visible == false)
            {
                textBox3.Clear();
            }

            else if (panel10.Visible == false)
            {
                textBox4.Clear();
            }

            else if (panel17.Visible == false)
            {
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }

            else if (panel20.Visible == false)
            {
                textBox8.Clear();
            }

            else if (panel23.Visible == false)
            {
                textBox9.Clear();
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


            if (panel1.Visible == false)
            {
                textBox1.Clear();
            }

            else if (panel5.Visible == false)
            {
                textBox2.Clear();
            }

            else if (panel7.Visible == false)
            {
                textBox3.Clear();
            }

            else if (panel10.Visible == false)
            {
                textBox4.Clear();
            }

            else if (panel17.Visible == false)
            {
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }

            else if (panel20.Visible == false)
            {
                textBox8.Clear();
            }

            else if (panel23.Visible == false)
            {
                textBox9.Clear();
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


            if (panel1.Visible == false)
            {
                textBox1.Clear();
            }

            else if (panel5.Visible == false)
            {
                textBox2.Clear();
            }

            else if (panel7.Visible == false)
            {
                textBox3.Clear();
            }

            else if (panel10.Visible == false)
            {
                textBox4.Clear();
            }

            else if (panel17.Visible == false)
            {
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }

            else if (panel20.Visible == false)
            {
                textBox8.Clear();
            }

            else if (panel23.Visible == false)
            {
                textBox9.Clear();
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


            if (panel1.Visible == false)
            {
                textBox1.Clear();
            }

            else if (panel5.Visible == false)
            {
                textBox2.Clear();
            }

            else if (panel7.Visible == false)
            {
                textBox3.Clear();
            }

            else if (panel10.Visible == false)
            {
                textBox4.Clear();
            }

            else if (panel17.Visible == false)
            {
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }

            else if (panel20.Visible == false)
            {
                textBox8.Clear();
            }

            else if (panel23.Visible == false)
            {
                textBox9.Clear();
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


            if (panel1.Visible == false)
            {
                textBox1.Clear();
            }

            else if (panel5.Visible == false)
            {
                textBox2.Clear();
            }

            else if (panel7.Visible == false)
            {
                textBox3.Clear();
            }

            else if (panel10.Visible == false)
            {
                textBox4.Clear();
            }

            else if (panel17.Visible == false)
            {
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }

            else if (panel20.Visible == false)
            {
                textBox8.Clear();
            }

            else if (panel23.Visible == false)
            {
                textBox9.Clear();
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


            if (panel1.Visible == false)
            {
                textBox1.Clear();
            }

            else if (panel5.Visible == false)
            {
                textBox2.Clear();
            }

            else if (panel7.Visible == false)
            {
                textBox3.Clear();
            }

            else if (panel10.Visible == false)
            {
                textBox4.Clear();
            }

            else if (panel17.Visible == false)
            {
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }

            else if (panel20.Visible == false)
            {
                textBox8.Clear();
            }

            else if (panel23.Visible == false)
            {
                textBox9.Clear();
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


            if (panel1.Visible == false)
            {
                textBox1.Clear();
            }

            else if (panel5.Visible == false)
            {
                textBox2.Clear();
            }

            else if (panel7.Visible == false)
            {
                textBox3.Clear();
            }

            else if (panel10.Visible == false)
            {
                textBox4.Clear();
            }

            else if (panel17.Visible == false)
            {
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }

            else if (panel20.Visible == false)
            {
                textBox8.Clear();
            }

            else if (panel23.Visible == false)
            {
                textBox9.Clear();
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


            if (panel1.Visible == false)
            {
                textBox1.Clear();
            }

            else if (panel5.Visible == false)
            {
                textBox2.Clear();
            }

            else if (panel7.Visible == false)
            {
                textBox3.Clear();
            }

            else if (panel10.Visible == false)
            {
                textBox4.Clear();
            }

            else if (panel17.Visible == false)
            {
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }

            else if (panel20.Visible == false)
            {
                textBox8.Clear();
            }

            else if (panel23.Visible == false)
            {
                textBox9.Clear();
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


            if (panel1.Visible == false)
            {
                textBox1.Clear();
            }

            else if (panel5.Visible == false)
            {
                textBox2.Clear();
            }

            else if (panel7.Visible == false)
            {
                textBox3.Clear();
            }

            else if (panel10.Visible == false)
            {
                textBox4.Clear();
            }

            else if (panel17.Visible == false)
            {
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }

            else if (panel20.Visible == false)
            {
                textBox8.Clear();
            }

            else if (panel23.Visible == false)
            {
                textBox9.Clear();
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


            if (panel1.Visible == false)
            {
                textBox1.Clear();
            }

            else if (panel5.Visible == false)
            {
                textBox2.Clear();
            }

            else if (panel7.Visible == false)
            {
                textBox3.Clear();
            }

            else if (panel10.Visible == false)
            {
                textBox4.Clear();
            }

            else if (panel17.Visible == false)
            {
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }

            else if (panel20.Visible == false)
            {
                textBox8.Clear();
            }

            else if (panel23.Visible == false)
            {
                textBox9.Clear();
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


    }
}

 