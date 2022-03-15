using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegaty
{
    public partial class Form1 : Form
    {
        public double kwadrat(double a)
        {
            return a * a;
        }

        public double pierwiastek(double a)
        {
            return Math.Sqrt(a);
        }

        public double odwrotnosc(double a)
        {
            return 1 / a;
        }

        public void zmiana_tla()
        {
            if (BackColor == Color.White)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.White;
            }
        }

        public void zmiana_kolor()
        {
            
            if (liczbaTextBox.ForeColor == Color.Red)
            {
                liczbaTextBox.ForeColor = Color.Black;
            }
            else
            {
                liczbaTextBox.ForeColor = Color.Red;
            }
        }

        public void zmiana_rozmiaru()
        {
            liczbaTextBox.Multiline = true;
            liczbaTextBox.Font = DefaultFont;
        }


        public Form1()
        {
            InitializeComponent();
        }

        delegate double Dzialanie(double a);

        Dzialanie dzialanie;

        private void kwadratButton_Click(object sender, EventArgs e)
        {
            dzialanie = kwadrat;
        }

        private void pierwiastekButton_Click(object sender, EventArgs e)
        {
            dzialanie = pierwiastek;
        }

        private void odwrotnoscButton_Click(object sender, EventArgs e)
        {
            dzialanie = odwrotnosc;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {

            liczbaTextBox.Text = dzialanie(Convert.ToDouble(liczbaTextBox.Text)).ToString();
        }

        delegate void Change();

        Change change;

        private void zmiannaTlaButton_Click(object sender, EventArgs e)
        {
            change += zmiana_tla;
        }

        private void zmianaKoloruButton_Click(object sender, EventArgs e)
        {
            change += zmiana_kolor;
        }

        private void zmianaRozmiaru_Click(object sender, EventArgs e)
        {
            change += zmiana_rozmiaru;
        }

        private void buttonSecond_Click(object sender, EventArgs e)
        {
            change();
        }

    }
}
