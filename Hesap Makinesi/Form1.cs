using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public int yazilanSayi = 0, sayi1, sayi2, sonuc;
        public bool sayiVarMi = false,islemİptal = false;
        public string islem;


        private void button1_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false)
            {
                textBox1.Clear();
                textBox1.Text = "1";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
                sayiVarMi = true;
            }
            else
            {
                textBox1.Text += "1";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false)
            {
                textBox1.Clear();
                textBox1.Text = "2";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
                sayiVarMi = true;
            }
            else
            {
                textBox1.Text += "2";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false)
            {
                textBox1.Clear();
                textBox1.Text = "3";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
                sayiVarMi = true;
            }
            else
            {
                textBox1.Text += "3";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false)
            {
                textBox1.Clear();
                textBox1.Text = "4";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
                sayiVarMi = true;
            }
            else
            {
                textBox1.Text += "4";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false)
            {
                textBox1.Clear();
                textBox1.Text = "5";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
                sayiVarMi = true;
            }
            else
            {
                textBox1.Text += "5";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false)
            {
                textBox1.Clear();
                textBox1.Text = "6";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
                sayiVarMi = true;
            }
            else
            {
                textBox1.Text += "6";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false)
            {
                textBox1.Clear();
                textBox1.Text = "7";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
                sayiVarMi = true;
            }
            else
            {
                textBox1.Text += "7";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false)
            {
                textBox1.Clear();
                textBox1.Text = "8";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
                sayiVarMi = true;
            }
            else
            {
                textBox1.Text += "8";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false)
            {
                textBox1.Clear();
                textBox1.Text = "9";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
                sayiVarMi = true;
            }
            else
            {
                textBox1.Text += "9";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
            }
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            if(islem != "" && sayi1 != 0 && yazilanSayi != 0)
            {
                sayi2 = yazilanSayi;
            }
           
            if (sayi2 != 0)
            {
                sayiVarMi = false;
                if (islem == "topla")
                {
                    sonuc = sayi1 + sayi2;
                }
                else if (islem == "cikar")
                {
                    sonuc = sayi1 - sayi2;
                }
                else if (islem == "carp")
                {
                    sonuc = sayi1 * sayi2;
                }
                else if (islem == "bol")
                {
                    sonuc = sayi1 / sayi2;
                }
                else
                {
                    MessageBox.Show("Hiçbir giriş yapmadınız!");
                }
                islem = "";
                sayi1 = 0;
                sayi2 = 0;
                textBox1.Text = Convert.ToString(sonuc);
            }        
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false && islemİptal == true)
            {
                islem = "";
                islem = "cikar";
                textBox1.Clear();
                textBox1.Text = "-";

            }

            if (sayiVarMi == true)
            {
                sayi1 = yazilanSayi;
                yazilanSayi = 0;
                islem = "cikar";
                textBox1.Clear();
                textBox1.Text = "-";
                sayiVarMi = false;
            }

        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false && islemİptal == true)
            {
                islem = "";
                islem = "carp";
                textBox1.Clear();
                textBox1.Text = "*";

            }

            if (sayiVarMi == true)
            {
                sayi1 = yazilanSayi;
                yazilanSayi = 0;
                islem = "carp";
                textBox1.Clear();
                textBox1.Text = "*";
                sayiVarMi = false;
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false && islemİptal == true)
            {
                islem = "";
                islem = "bol";
                textBox1.Clear();
                textBox1.Text = "/";

            }

            if (sayiVarMi == true)
            {
                sayi1 = yazilanSayi;
                yazilanSayi = 0;
                islem = "bol";
                textBox1.Clear();
                textBox1.Text = "/";
                sayiVarMi = false;
            }
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false && islemİptal == true)
            {
                islem = "";
                islem = "topla";
                textBox1.Clear();
                textBox1.Text = "+";

            }

            if (sayiVarMi == true)
            {
                sayi1 = yazilanSayi;
                yazilanSayi = 0;
                islem = "topla";
                textBox1.Clear();
                textBox1.Text = "+";
                sayiVarMi = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (islem != "" && sayiVarMi == false)
            {
                islemİptal = true;
            }
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                button2.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                button6.PerformClick();
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                button7.PerformClick();
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                button8.PerformClick();
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                button9.PerformClick();
            }
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                button10.PerformClick();
            }
            else if(e.KeyCode == Keys.Add)
            {
                btnTopla.PerformClick();
            }
            else if(e.KeyCode == Keys.Subtract)
            {
                btnCikar.PerformClick();
            }
            else if(e.KeyCode == Keys.Multiply)
            {
                btnCarp.PerformClick();
            }
            else if(e.KeyCode == Keys.Divide)
            {
                btnBol.PerformClick();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                btnEsittir.PerformClick();
            }
            else if(e.KeyCode == Keys.Back)
            {
                button11.PerformClick();
            }
            else if(e.KeyCode == Keys.Add)
            {
                btnTopla.PerformClick();
            }
            else if(e.KeyCode == Keys.Subtract)
            {
                btnCikar.PerformClick();
            }
            else if(e.KeyCode == Keys.Multiply)
            {
                btnCarp.PerformClick();
            }
            else if(e.KeyCode == Keys.Divide)
            {
                btnBol.PerformClick();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                btnEsittir.PerformClick();
            }
            else if(e.KeyCode == Keys.Back)
            {
                button11.PerformClick();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sayiVarMi == false)
            {
                textBox1.Text = "0";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
                sayiVarMi = true;
            }
            else
            {
                textBox1.Text += "0";
                yazilanSayi = Convert.ToInt32(textBox1.Text);
            }
        }


        public Form1()
        {
            InitializeComponent();
        }
    }
}
