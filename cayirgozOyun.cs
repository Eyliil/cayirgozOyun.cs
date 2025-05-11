using System;
using System.Windows.Forms;

namespace denememe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private string girilenVeri="";

        private void button1_Click(object sender, EventArgs e)
        {
            sayac = sayac + 1;
            label2.Text = sayac.ToString();
            if (sayac == 5)
            {
                MessageBox.Show("5'e ulaştınız! Dolap kilidini açtınız ancak dolap içinde bir şifre var. ipucu için butona tekrar tıklayın");
            }

            else if (sayac == 6)
            {

                MessageBox.Show("Ekşidür, yüz ekşitür.. Olgunlaşmazsa yeşildür, ağaçta yetişür.");
                textBox1.Visible = true;
                
            }

                else if (sayac==7)
                {
                girilenVeri = textBox1.Text;
            }
            if (girilenVeri.ToLower() == "limon")
            {
                MessageBox.Show("Doğru. Dolabın içini açtınız.");
            }
            if (sayac==7 && girilenVeri.ToLower() != "limon")
            {
                MessageBox.Show("Sıradanlık Çukuruna Düştünüz..");
               
            }
            }

        
    }
    }

