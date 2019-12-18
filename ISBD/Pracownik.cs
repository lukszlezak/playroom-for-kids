using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISBD
{
    public partial class Pracownik : Form
    {
        Start start;
        string login;
        
        public Pracownik(Start start, string login)
        {
            InitializeComponent();
            this.start = start;
            this.login = login;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pracownicy prac = new Pracownicy(this);
            prac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klienci klienci = new Klienci(this);
            klienci.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dzieci dzieci = new Dzieci(this);
            dzieci.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zamowienia zam = new Zamowienia(this);
            zam.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            start.Show();
        }
    }
}
