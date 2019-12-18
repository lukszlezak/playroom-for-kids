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
    public partial class PracLog : Form
    {
        Start start;
        SqlConnection con;
        SqlCommand cmd;

        public PracLog(Start start, SqlConnection con)
        {
            InitializeComponent();
            this.start = start;
            this.con = con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM Pracownik WHERE Login = '" + textBox1.Text + "' AND Haslo = '" + textBox2.Text + "'";
            cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                con.Close();
                //Klient klient = new Klient(start, con, textBox1.Text);
                Pracownik prac = new Pracownik(start, textBox1.Text);
                this.Hide();
                prac.Show();
            }
            else
                MessageBox.Show("Błąd");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Hide();
            start.Show();
        }
    }
}
