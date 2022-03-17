/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3.Ödev Proje ödevi
**				ÖĞRENCİ ADI............: Dilan Çelik
**				ÖĞRENCİ NUMARASI.......: B201210399
**                         DERSİN ALINDIĞI GRUP...: 1-C
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


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        
        int sayac = 60; // sayac değişkenine deger atandı
        elma elm = new elma(); //elma classından yeni nesne oluşturuldu
        çilek clk = new çilek(); //çilek classından yeni nesne oluşturuldu
        armut armt = new armut(); //armut classından yeni nesne oluşturuldu
        portakal prtkl = new portakal(); //portakal classından yeni nesne oluşturuldu
        mandalina mndln = new mandalina(); //mandalina classından yeni nesne oluşturuldu
        greyfurt gryfrt = new greyfurt(); //greyfurt classından yeni nesne oluşturuldu
        double toplamC ; // toplam C vitamini ifade eden toplamC tanımlandı
        double toplamA; // toplam A vitamini ifade eden toplamC tanımlandı
        double toplampure; // toplam pure miktarını ifade eden toplamC tanımlandı
        double toplamsivi; // toplam sivi miktarını ifade eden toplamC tanımlandı
        public static Random rnd = new Random(); //random nesnesi oluşturuldu
       
        int ind ;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop(); //Program açıldığında yeni oyuna basmadan her şey sıfırlanıp başlar.
            button2.Enabled = false; 
            button3.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = false;
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            ind = rnd.Next(0, 6); //random deger atanır
            timer1.Start(); //sayac calısmaya baslar
            pictureBox1.Image = ımageList1.Images[ind]; //rastgele resim gelir


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            sayac--;
            label1.Text = sayac.ToString(); //sayac labelde gösterilir
           
            if (sayac == 0) //sayac sıfırlanınca
            {

                timer1.Stop(); // sayac durur

                label6.Text = Convert.ToString(toplamA); //labele toplam A vitamini yazdırılır 
                label7.Text = Convert.ToString(toplamC); //labele toplam C vitamini yazdırılır 
                button1.Enabled = false; 
                button2.Enabled = false;
                label12.Text = Convert.ToString(toplamsivi);  //labele toplam sıvı miktarı yazdırılır 
                label13.Text = Convert.ToString(toplampure);  //labele toplam pure miktarı yazdırılır 


            }

        }

        private void button2_Click(object sender, EventArgs e) // Katı meyve sıkacağına basıldığında
        {
             if (ind == 0) //armut resmi geldiğinde
            {

                double vitA = armt.verim * 0.25;
                double vitC = armt.verim * 0.05;


                label2.Text = vitA.ToString();
                label3.Text = vitC.ToString();
                ind = rnd.Next(0, 6);
                pictureBox1.Image = ımageList1.Images[ind];

                toplamA += vitA;
                toplamC += vitC;
                double pure = armt.agirlik - armt.verim;
                double sivi = armt.verim;
                toplampure += pure;
                toplamsivi += sivi;

            }
            else if (ind == 1) // çilek resmi geldiğinde
            {

                double vitA = clk.verim * 0.12;
                double vitC = clk.verim * 0.6;


                label2.Text = vitA.ToString();
                label3.Text = vitC.ToString();
                ind = rnd.Next(0, 6);
                pictureBox1.Image = ımageList1.Images[ind];
                toplamA += vitA;
                toplamC += vitC;
                double pure = armt.agirlik - armt.verim;
                double sivi = armt.verim;
                toplampure += pure;
                toplamsivi += sivi;


            }


             else if (ind == 2) //elma resmi geldiğinde
            {
                double vitA = elm.verim * 0.54;
                double vitC=elm.verim * 0.05;
                

                label2.Text = vitA.ToString();
                label3.Text = vitC.ToString();
                ind = rnd.Next(0, 6);
                pictureBox1.Image = ımageList1.Images[ind];
               
                toplamA += vitA;
                
                toplamC += vitC;
                double sivi = elm.agirlik - elm.verim;
                double pure = elm.verim;
                toplampure += pure;
                toplamsivi += sivi;
            }
           
            else
            {
                MessageBox.Show("Narenciye Sıkacağını deneyiniz..", "Yanlış Sıkacak",  MessageBoxButtons.OK, MessageBoxIcon.Error); // yanlış sıkacak secildiyse
            }
          


        }


        private void button3_Click(object sender, EventArgs e) //narenciye sıkacağı secildiğinde
        {
             if (ind == 3) //greyfurt resmi secildiyse
            {

                double vitA = gryfrt.verim * 0.03;
                double vitC = gryfrt.verim * 0.44;


                label2.Text = vitA.ToString();
                label3.Text = vitC.ToString();
                ind = rnd.Next(0, 6);
                pictureBox1.Image = ımageList1.Images[ind];
                toplamA += vitA;
                toplamC += vitC;
                double pure = gryfrt.agirlik - gryfrt.verim;
                double sivi = gryfrt.verim;
                toplampure += pure;
                toplamsivi += sivi;

            }

           
            else if (ind == 4) //mandalina resmi secildiyse
            {

                double vitA = mndln.verim * 6.81;
                double vitC = mndln.verim * 0.26;
                

                label2.Text = vitA.ToString();
                label3.Text = vitC.ToString();
                ind = rnd.Next(0, 6);
                pictureBox1.Image = ımageList1.Images[ind];
                toplamA += vitA;
                toplamC += vitC;
                double pure = mndln.agirlik - mndln.verim;
                double sivi = mndln.verim;
                toplampure += pure;
                toplamsivi += sivi;

            }
             else if (ind == 5) //portakal resmi geldiyse
            {
                double vitA = prtkl.verim * 2.25;
                double vitC = prtkl.verim * 0.45;
                label2.Text = vitA.ToString();
                label3.Text = vitC.ToString();
                ind = rnd.Next(0, 6);
                pictureBox1.Image = ımageList1.Images[ind];
                pictureBox1.Image = ımageList1.Images[ind];
                toplamA += vitA;
                toplamC += vitC;
                double pure = prtkl.agirlik - prtkl.verim;
                double sivi = prtkl.verim;
                toplampure += pure;
                toplamsivi += sivi;


            }

            else
            {
                MessageBox.Show("Katı Meyve Sıkacağını deneyiniz..", "Yanlış Sıkacak", MessageBoxButtons.OK, MessageBoxIcon.Error); //yanlış sıkacak secildiyse
            }
           
        }
        private void button4_Click(object sender, EventArgs e) // Cıkış butonu secildiyse
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e) //yeni tur butonu secildiyse
        {
            sayac = 60;
            timer1.Start();
            int ne = rnd.Next(0, 6);
            ind = ne;
            label2.Text = String.Empty;
            label3.Text = String.Empty;
            label6.Text = String.Empty;
            label7.Text = String.Empty;
            label12.Text = String.Empty;
            label13.Text = String.Empty;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.Enabled = true;
        }
        private void label1_Click(object sender, EventArgs e) //form elemanları tanımlanır
        { }

        private void label2_Click(object sender, EventArgs e)
        { }
        private void label6_Click(object sender, EventArgs e)
        { }
        private void label7_Click(object sender, EventArgs e)
        { }
        private void label10_Click(object sender, EventArgs e)
        { }

        private void label11_Click(object sender, EventArgs e)
        { }
        private void label12_Click(object sender, EventArgs e)
        { }
        private void label13_Click(object sender, EventArgs e)
        { }
        private void pictureBox1_Click(object sender, EventArgs e)
        { }
    }
}
