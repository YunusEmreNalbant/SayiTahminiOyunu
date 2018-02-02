using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SayiTahminiOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        int deneme = 0;
        Random gerceksayi = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sayi = gerceksayi.Next(1, 101);
          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int girilensayi = Convert.ToInt32(TxtTahmin.Text);

            if(sayi==girilensayi)
            {
                timer1.Stop();
                MessageBox.Show("TEBRİKLER!" + deneme+ " .seferde bildiniz!");
                


            }
            if(sayi<girilensayi)
            {
                LblGirilenTahmin.Text = "Daha küçük!";
                deneme++;
            }
            if (sayi>girilensayi)
            {
                LblGirilenTahmin.Text = "Daha büyük!";
                deneme++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            if(progressBar1.Value==5)
            {
                richTextBox1.Text = "SÜRE DOLUYOR !";
            }
            if(progressBar1.Value % 10==5)
            {
                richTextBox1.BackColor = Color.Red;
            }
            if(progressBar1.Value % 10 == 0)
            {
                richTextBox1.BackColor = Color.White;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                richTextBox1.Text = " KAYBETTİN ! ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
