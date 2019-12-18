using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ISBD
{
    public partial class Klient : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Start start;
        string tel;

        public Klient(Start start, SqlConnection con, string tel)
        {
            InitializeComponent();
            this.start = start;
            this.con = con;
            this.tel = tel;
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            start.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            con.Open();
            string str = "SELECT Dziecko.Nazwisko + ' ' + Dziecko.Imie AS Dziecko, Pracownik.Nazwisko + ' ' + Pracownik.Imie AS Pracownik, Sale.Nazwa AS Sala, Pobyt.DataPobytu AS [Data Pobytu], " +
                            "Pobyt.CzasWejscia AS [Czas wejścia], Pobyt.CzasWyjscia AS [Czas wyjścia], Pobyt.Koszt FROM Pobyt INNER JOIN  Dziecko ON Pobyt.IdD = Dziecko.IdD INNER JOIN " +
                            "Klient ON Dziecko.IdK = Klient.IdK INNER JOIN Pracownik ON Pobyt.IdP = Pracownik.IdP INNER JOIN Sale ON Pobyt.IdSali = Sale.IdSali ";
                            //"WHERE Klient.Telefon = '" + tel + "'";
            cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource src = new BindingSource();
            src.DataSource = dr;
            dataGridView1.DataSource = src;
            con.Close();
            dataGridView1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            con.Open();
            string str = "SELECT Klient.Nazwisko + ' ' + Klient.Imie AS Klient, Pracownik.Nazwisko + ' ' + Pracownik.Imie AS Pracownik, Zamowienie.DataZam, Zamowienie.Wartosc " + 
                         "FROM Zamowienie INNER JOIN Klient ON Zamowienie.IdK = Klient.IdK INNER JOIN Pracownik ON Zamowienie.IdP = Pracownik.IdP";
            cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource src = new BindingSource();
            src.DataSource = dr;
            dataGridView2.DataSource = src;
            con.Close();
            dataGridView2.Visible = true;
        }
    }
}
