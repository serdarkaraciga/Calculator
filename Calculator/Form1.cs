using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlenecekmi;
        private int _ilkSayı;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi == true)
            {
                screen1.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (screen1.Text == "0")
            {
                screen1.Text = "";
            }

            screen1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _ekranTemizlenecekmi = true;
            int _ilkSayı = Convert.ToInt32(screen1.Text);
            _islem = '/';
        }

        private void number1_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekmi == true)
            {
                screen1.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (screen1.Text == "0")
            {
                screen1.Text = "";
            }

         screen1.Text += "1";
        }

        private void number2_Click(object sender, EventArgs e)
        {

                if (_ekranTemizlenecekmi == true)
                    {
                       screen1.Text = "";
                        _ekranTemizlenecekmi = false;
                    }

            if (screen1.Text == "0")
            {
                screen1.Text = "";
            }

            screen1.Text += "2";
        }

        private void number3_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekmi == true)
                 {
                    screen1.Text = "";
                    _ekranTemizlenecekmi = false;
                }

            if (screen1.Text == "0")
            {
                screen1.Text = "";
            }

            screen1.Text += "3";
        }

        private void number4_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekmi == true)
            {
                screen1.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (screen1.Text == "0")
            {
                screen1.Text = "";
            }

            screen1.Text += "4";
        }

        private void number5_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekmi == true)
            {
                screen1.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (screen1.Text == "0")
            {
                screen1.Text = "";
            }

            screen1.Text += "5";
        }

        private void number6_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekmi == true)
            {
                screen1.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (screen1.Text == "0")
            {
                screen1.Text = "";
            }

            screen1.Text += "6";
        }

        private void number8_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekmi == true)
            {
                screen1.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (screen1.Text == "0")
            {
                screen1.Text = "";
            }

            screen1.Text += "8";
        }

        private void number9_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekmi == true)
            {
                screen1.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (screen1.Text == "0")
            {
                screen1.Text = "";
            }

            screen1.Text += "9";
        }

        private void number0_Click(object sender, EventArgs e)
        {

            if (_ekranTemizlenecekmi == true)
            {
                screen1.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (screen1.Text == "0")
            {
                screen1.Text = "";
            }

            screen1.Text += "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            _ekranTemizlenecekmi = true;
            _ilkSayı = Convert.ToInt32(screen1.Text);
            _islem = '+';

        }

        private void minus_Click(object sender, EventArgs e)
        {
            _ekranTemizlenecekmi = true;
            _ilkSayı = Convert.ToInt32(screen1.Text);
            _islem = '-';
        }

        private void impact_Click(object sender, EventArgs e)
        {
            _ekranTemizlenecekmi = true;
            _ilkSayı = Convert.ToInt32(screen1.Text);
            _islem = '*';
        }

        private void equal_Click(object sender, EventArgs e)
        {
            int sonuc;
            int ikincisayi = Convert.ToInt32(screen1.Text);
            
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayı + ikincisayi;
                    break;

                case '-':
                    sonuc = _ilkSayı - ikincisayi;
                    break;

                case '*':
                    sonuc = _ilkSayı * ikincisayi;
                    break;

                case '/':
                    sonuc = _ilkSayı / ikincisayi;
                    break;

                default:
                    sonuc = 0;
                    break;

            }
            screen1.Text = Convert.ToString(sonuc);
        }
    }
}
