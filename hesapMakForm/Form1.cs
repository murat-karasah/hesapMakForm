using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakForm
{
    public partial class Form1 : Form
    {
        static double sayi1=0, sayi2 = 0, sonuc;


        public Form1()
        {
            InitializeComponent();
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    artı.Visible=true;
                    cıkar.Visible = true;
                    bol.Visible = true;
                    carp.Visible = true;
                    kok.Visible = false;
                    kare.Visible = false;
                    break;
                case 1:

                    gizle();
                    textBox2.Visible = false;
                    label2.Visible = false;
                    kok.Visible = false;
                    kare.Visible = true;

            double sonuc = Math.Sqrt(sayi1);
                    break;
                case 2:

                    gizle();
                    textBox2.Visible = false;
                    kok.Visible = true;
                    kare.Visible = false;
                    label2.Visible = false;
                    break;
                default:
                    break;
            }
        }

       

        

       

        private void gizle()
        {
            artı.Visible = false;
            cıkar.Visible = false;
            bol.Visible = false;
            carp.Visible = false;
        }

        private void artı_Click(object sender, EventArgs e)
        {
            sayilar();
           

            double sonuc = sayi1 + sayi2;
            textBox3.Text = sonuc.ToString();
        }

        public void sayilar()
        {
            sayi1 = Convert.ToDouble(textBox1.Text);

            sayi2 = Convert.ToDouble(textBox2.Text);
        }

        private void cıkar_Click(object sender, EventArgs e)
        {
            sayilar();


            double sonuc = sayi1 - sayi2;
            textBox3.Text = sonuc.ToString();

        }

       

        private void kare_Click(object sender, EventArgs e)
        {
          
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sonuc = Math.Pow(sayi1, 2);
            textBox3.Text = sonuc.ToString();
        }

        private void kok_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);

            sonuc = Math.Sqrt(sayi1);
            textBox3.Text = sonuc.ToString();
        }

        private void carp_Click(object sender, EventArgs e)
        {
            sayilar();


            double sonuc = sayi1 * sayi2;
            textBox3.Text = sonuc.ToString();
        }

        private void bol_Click(object sender, EventArgs e)
        {
            sayilar();


            double sonuc = sayi1 / sayi2;
            textBox3.Text = sonuc.ToString();
        }

       

       
    }
}
