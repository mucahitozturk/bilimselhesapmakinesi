/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2018-2019 YAZ DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3
**				ÖĞRENCİ ADI............: ÖMER FARUK AĞAÇ
**				ÖĞRENCİ NUMARASI.......: s181210185
**              DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilimselHesapMakinesi
{
    public partial class Form1 : Form
    {


       // Değişkenler tanımlandı.

        private double birinciSayi = 0.0;
        private double ikinciSayi = 0.0;
        private string islem = "";
        private double sonuc = 0.0;

        public Form1()
        {
            InitializeComponent();
        }




        private void zerobutton_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }


        private void sayiGir(int sayi) // Seçilen sayıyı textBox'a yazdır.
        {
            if (textBox1.Text == "0") 
                textBox1.Text = sayi.ToString();
            else
                textBox1.Text += sayi.ToString();
        }

        // Numpad'den sayı seçme işlemleri.

        private void onebutton4_Click(object sender, EventArgs e)
        {
            sayiGir(1);
        }

        private void twobutton_Click(object sender, EventArgs e)
        {
            sayiGir(2);
        }

        private void threebutton6_Click(object sender, EventArgs e)
        {
            sayiGir(3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sayiGir(4);
        }

        private void fivebutton_Click(object sender, EventArgs e)
        {
            sayiGir(5);
        }

        private void sixbutton_Click(object sender, EventArgs e)
        {
            sayiGir(6);
        }

        private void sevenbutton_Click(object sender, EventArgs e)
        {
            sayiGir(7);
        }

        private void eightbutton_Click(object sender, EventArgs e)
        {
            sayiGir(8);
        }

        private void ninebutton_Click(object sender, EventArgs e)
        {
            sayiGir(9);
        }


        private void Cebutton_Click(object sender, EventArgs e)
        {
            // Silme tuşuna basıldığında textBox'ta bulunan sayıları tek tek siler.

            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

        }


        private void dotbutton3_Click(object sender, EventArgs e)
        {
            // textBox'a virgül yazdırır.

            if (!textBox1.Text.Contains(",")) 
                textBox1.Text += ",";         
        }



        private void multibutton_Click(object sender, EventArgs e)
        {
            islem = "*"; // Çarpma işlemi seçeneği.
            birinciSayiDegeriniBellekteTut();
        }


        
        private void birinciSayiDegeriniBellekteTut()
        {
            birinciSayi = Convert.ToDouble(textBox1.Text); // textBox'ta girilen sayının değerini 1. sayı olarak atar ve bellekte tutar.
            textBox1.Text = "0"; // Sayıyı aldıktan sonra textBox'a 0 değerini girer.
        }

       
        // İşlem seçimi ve işlemin uygulanacağı birinci sayıyı tutmak için fonksiyon çağırımı.

        private void minusbutton_Click(object sender, EventArgs e)
        {
            islem = "-"; // Çıkartma işlemi seçeneği.
            birinciSayiDegeriniBellekteTut();
        }

        private void percentbutton_Click(object sender, EventArgs e)
        {
            islem = "%"; // Mod alma işlemi seçeneği.
            birinciSayiDegeriniBellekteTut();
        }

        private void dividebutton_Click(object sender, EventArgs e)
        {
            islem = "/"; // Bölme işlemi seçeneği.
            birinciSayiDegeriniBellekteTut();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            islem = "+"; // Toplama işlemi seçeneği.
            birinciSayiDegeriniBellekteTut(); 
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            islem = "^"; // Mod alma işlemi seçeneği.
            birinciSayiDegeriniBellekteTut();
        }


        private void equallbutton_Click(object sender, EventArgs e)
        {
            ikinciSayi = Convert.ToDouble(textBox1.Text); // textBox'a girilen ikinci sayıyı double'a çevirip ikinciSayi değişkeninde saklar.

           

            switch (islem) // Seçilen işlemler için sonuçları döndürür.
            {

                case "+":
                    sonuc = birinciSayi + ikinciSayi;
                    break;
                case "-":
                    sonuc = birinciSayi - ikinciSayi;
                    break;
                case "*":
                    sonuc = birinciSayi * ikinciSayi;
                    break;
                case "/":
                    sonuc = birinciSayi / ikinciSayi;
                    break;
                case "%":
                    sonuc = birinciSayi % ikinciSayi;
                    break;
                case "^":
                    sonuc = (Math.Pow(birinciSayi, ikinciSayi));
                    break;

            }
            textBox1.Text = sonuc.ToString(); // textBox'a sonucu yazdırır.
        }



        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(textBox1.Text))); // Sinüs alma işlemi.
        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(textBox1.Text))); // Kosinüs alma işlemi
        }

        private void tanbutton_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(textBox1.Text))); // Tanjant alma işlemi.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Log(Convert.ToDouble(textBox1.Text))); // Logaritma (Ln).

        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Log10(Convert.ToDouble(textBox1.Text))); // Logaritma (Log10).
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(textBox1.Text))); // Kök alma işlemi.
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)); // Kare alma işlemi
        }

        private void xKiPoWbutton_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)); // Küp alma işlemi.
        }

        private void button9_Click(object sender, EventArgs e) // Faktoriyel alma işlemi
        {
            birinciSayiDegeriniBellekteTut();

            if (birinciSayi < 0 || birinciSayi.ToString().Contains("."))
            {
                textBox1.Text = "HATA!";
                return;
            }

            double n = 1;
            if (birinciSayi == 1 || birinciSayi == 0)
                textBox1.Text = n.ToString();
            else
            {
                for (int i = 2; i <= birinciSayi; i++)
                {
                    n *= i;
                }
            }
            textBox1.Text = n.ToString();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592654"; // Pi sayısı.
        }

        private void acbutton_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // CE butonuna basınca textBox'u temizler ve 0 değerini textBox'a yazdırır.
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(-Convert.ToDouble(textBox1.Text)); // Girilen değeri negatif yapar (Başına eksi ekler)

        }

    }
}
