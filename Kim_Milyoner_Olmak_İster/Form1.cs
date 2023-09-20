using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kim_Milyoner_Olmak_İster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.Transparent)
            {
                label26.Text = "Yedi renkten oluşan gökkuşağının ortasındaki renk hangisidir?";
                label25.Text = "1";
                ASecenegi.Text = "A) Beyaz";
                BSecenegi.Text = "B) Yeşil";
                CSecenegi.Text = "C) Mavi";
                DSecenegi.Text = "D) Kırmızı";
            }

            if (panel1.BackColor == Color.DarkOrange)
            {
                label26.Text = "Atatürk'ün çok sevdiği atının ve köpeğinin isimleri neydi?";
                label25.Text = "2";
                ASecenegi.Text = "A)Devrim ve Çakır";
                BSecenegi.Text = "B)Foks ve Sakarya";
                CSecenegi.Text = "C)Yiğit ve Kont";
                DSecenegi.Text = "D)Anadolu ve Çakır";
                BSecenegi.FillColor = Color.DarkSlateGray;
            }
            
            if (panel2.BackColor == Color.DarkOrange)
            {
                label26.Text = "Türkiye Cumhuriyeti'nin 4. Başbakanı Dr. Refik Saydam hangi hastalığa karşı geliştirdiği aşıyla tıp literatürüne geçmiştir?";
                label25.Text = "3";
                ASecenegi.Text = "A)Kolera";
                BSecenegi.Text = "B)Tifüs";
                CSecenegi.Text = "C)Dizanteri";
                DSecenegi.Text = "D)Çiçek";
                BSecenegi.FillColor = Color.DarkSlateGray;
            }
            
            if (panel3.BackColor == Color.DarkOrange)
            {
                label26.Text = "Dede Korkut'un Türk Destanları'nın özgün kopyaları hangi iki kentte bulunmaktadır?";
                label25.Text = "4";
                ASecenegi.Text = "A)Dresden-Vatikan";
                BSecenegi.Text = "B)Londra-Budapeşte";
                CSecenegi.Text = "C)Paris-Varşova";
                DSecenegi.Text = "D)Lizbon-Roma";
                BSecenegi.FillColor = Color.DarkSlateGray;
            }
            
            if (panel4.BackColor == Color.DarkOrange)
            {
                label26.Text = "Her 100 yılda 7 cm. yere yaklaşan Pisa Kulesi hangi yöne doğru eğilmektedir?";
                label25.Text = "5";
                ASecenegi.Text = "A)Batı";
                BSecenegi.Text = "B)Kuzey";
                CSecenegi.Text = "C)Doğu";
                DSecenegi.Text = "D)Güney";
                ASecenegi.FillColor = Color.DarkSlateGray;
            }
            
            if (panel5.BackColor == Color.DarkOrange)
            {
                label26.Text = "Hangi ünlü, üniversite mezunudur?";
                label25.Text = "6";
                ASecenegi.Text = "A)Bülent Ecevit";
                BSecenegi.Text = "B)Tarkan";
                CSecenegi.Text = "C)Kadir İnanır";
                DSecenegi.Text = "D)Acun Ilıcalı";
                DSecenegi.FillColor = Color.DarkSlateGray;
            }
            
            if (panel6.BackColor == Color.DarkOrange)
            {
                label26.Text = "Türkiye'nin hapis cezası alan ilk bilgisayar korsanı kimdir?";
                label25.Text = "7";
                ASecenegi.Text = "A)Tamer Şahin";
                BSecenegi.Text = "B)Burak Çağlar";
                CSecenegi.Text = "C)Mahir Arabul";
                DSecenegi.Text = "D)Tolga Bilge";
                ASecenegi.FillColor = Color.DarkSlateGray;
            }
            
            if (panel7.BackColor == Color.DarkOrange)
            {
                label26.Text = "Ülkemizde 'Devlet Sanatçısı' unvanını ilk alan isim kimdir?";
                label25.Text = "8";
                ASecenegi.Text = "A)Cüneyt Gökçer";
                BSecenegi.Text = "B)Ahmet Adnan Saygun";
                CSecenegi.Text = "C)Yıldız Kenter";
                DSecenegi.Text = "D)Cemal Reşit Rey";
                BSecenegi.FillColor = Color.DarkSlateGray;
            }
            
            if (panel8.BackColor == Color.DarkOrange)
            {
                label26.Text = "Aspirinin ham maddesi olan ağaç hangisidir?";
                label25.Text = "9";
                ASecenegi.Text = "A)Çobanpüskülü";
                BSecenegi.Text = "B)Söğüt";
                CSecenegi.Text = "C)Sığla";
                DSecenegi.Text = "D)Gülibrişim";
                BSecenegi.FillColor = Color.DarkSlateGray;
            }
            
            if (panel9.BackColor == Color.DarkOrange)
            {
                label26.Text = "Hangi ünlünün ikizi yoktur?";
                label25.Text = "10";
                ASecenegi.Text = "A)Kofi Annan";
                BSecenegi.Text = "B)Sühely Uygur";
                CSecenegi.Text = "C)Adile Naşit";
                DSecenegi.Text = "D)Athena Gökhan";
                CSecenegi.FillColor = Color.DarkSlateGray;
            }
            
            if (panel10.BackColor == Color.DarkOrange)
            {
                label26.Text = "Heredot'un yazdığı, Mısır firavununun dilin kökeni deneyinde, doğunca çobana verilerek kapatılan o dahil kimse ile konuşturulmayan çocuğun söylediği il kelime nedir?";
                label25.Text = "11";
                ASecenegi.Text = "A)Ver";
                BSecenegi.Text = "B)Ekmek";
                CSecenegi.Text = "C)Anne";
                DSecenegi.Text = "D)Su";
                BSecenegi.FillColor = Color.DarkSlateGray;
            }
            
            if (panel11.BackColor == Color.DarkOrange)
            {
                label26.Text = "Milli Savunma Bakanlığı'nın resmi sitesinde yer alan Atatürk'e ait özlük bilgilerine göre, Atatürk'ün boyu, kilosu ve ayakkabı numarası sırasıyla nasıldı?";
                label25.Text = "12";
                ASecenegi.Text = "A)170 cm, 68-70 kg, 40 numara";
                BSecenegi.Text = "B)172 cm, 71-73 kg, 41 numara";
                CSecenegi.Text = "C)174 cm, 74-76 kg, 42 numara";
                DSecenegi.Text = "D)176 cm, 77-79 kg, 43 numara";
                CSecenegi.FillColor = Color.DarkSlateGray;
            }
            
         


            if (label25.Text =="1")
            {
                panel1.BackColor = Color.DarkOrange;
            } 
            if (label25.Text =="2")
            {
                panel2.BackColor = Color.DarkOrange;
                panel1.BackColor = Color.Transparent;
            }
            if (label25.Text =="3")
            {
                panel3.BackColor = Color.DarkOrange;
                panel2.BackColor = Color.Transparent;
            } 
            if (label25.Text =="4")
            {
                panel4.BackColor = Color.DarkOrange;
                panel3.BackColor = Color.Transparent;
            }
            if (label25.Text =="5")
            {
                panel5.BackColor = Color.DarkOrange;
                panel4.BackColor = Color.Transparent;
            } 
            if (label25.Text =="6")
            {
                panel6.BackColor = Color.DarkOrange;
                panel5.BackColor = Color.Transparent;
            } 
            if (label25.Text =="7")
            {
                panel7.BackColor = Color.DarkOrange;
                panel6.BackColor = Color.Transparent;
            } 
            if (label25.Text =="8")
            {
                panel8.BackColor = Color.DarkOrange;
                panel7.BackColor = Color.Transparent;
            }
            if (label25.Text =="9")
            {
                panel9.BackColor = Color.DarkOrange;
                panel8.BackColor = Color.Transparent;
            } 
            if (label25.Text =="10")
            {
                panel10.BackColor = Color.DarkOrange;
                panel9.BackColor = Color.Transparent;
            } 
            if (label25.Text =="11")
            {
                panel11.BackColor = Color.DarkOrange;
                panel10.BackColor = Color.Transparent;
            } 
            if (label25.Text =="12")
            {
                panel12.BackColor = Color.DarkOrange;
                panel11.BackColor = Color.Transparent;
            }
        }

        private void BSecenegi_Click(object sender, EventArgs e)
        {
            if (label25.Text == "1" || label25.Text == "2" || label25.Text == "3" || label25.Text == "8" || label25.Text == "9" || label25.Text == "11")
            {
                BSecenegi.FillColor = Color.DarkGreen;
            }
            else
            {
                BSecenegi.FillColor = Color.DarkRed;
                MessageBox.Show("Yanlış Cevap Maalesef Kaybettiniz");
            }
        }

        private void ASecenegi_Click(object sender, EventArgs e)
        {
            if (label25.Text == "4" || label25.Text == "7" )
            {
                ASecenegi.FillColor = Color.DarkGreen;
            }
            else
            {
                ASecenegi.FillColor = Color.DarkRed;
                MessageBox.Show("Yanlış Cevap Maalesef Kaybettiniz");
            }
        }

        private void CSecenegi_Click(object sender, EventArgs e)
        {
            if (label25.Text == "6" || label25.Text == "10" || label25.Text == "12")
            {
                CSecenegi.FillColor = Color.DarkGreen;
            }
            else
            {
                CSecenegi.FillColor = Color.DarkRed;
                MessageBox.Show("Yanlış Cevap Maalesef Kaybettiniz");
            }
            if (CSecenegi.FillColor == Color.DarkGreen && label25.Text == "12")
            {
                MessageBox.Show("Tebrikler Büyük Ödülün Sahibi Oldunuz");
            }
        }

        private void DSecenegi_Click(object sender, EventArgs e)
        {
            if (label25.Text == "5")
            {
                DSecenegi.FillColor = Color.DarkGreen;
            }
            else
            {
                DSecenegi.FillColor = Color.DarkRed;
                MessageBox.Show("Yanlış Cevap Maalesef Kaybettiniz");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            label29.Text = "A şıkkı ile B şıkkı arasında kaldım";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            label29.Text = "A şıkkından eminim";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            label29.Text = "Alo alo sesin gelmiyor";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PanelTelefon.Visible = true;
        }

        private void label27_Click(object sender, EventArgs e)
        {
            PanelTelefon.Visible = false;
            pictureBox1.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 65;
            progressBar2.Value = 20;
            progressBar3.Value = 5;
            progressBar4.Value = 15;

            label33.Text = "65%";
            label34.Text = "20%";
            label35.Text = "5%";
            label36.Text = "15%";
        }

        private void label28_Click(object sender, EventArgs e)
        {
            panel14.Visible = false;
            pictureBox3.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel14.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ASecenegi.Text = "";
            DSecenegi.Text = "";
            pictureBox2.Visible = false;
        }
    }
}
