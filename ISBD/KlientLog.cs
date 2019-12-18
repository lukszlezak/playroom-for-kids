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
    public partial class KlientLog : Form
    {
        SqlConnection con;
        Start start;

        public KlientLog(Start start, SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            this.start = start;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from klient where Telefon = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.HasRows)
            {
                con.Close();
                Klient klient = new Klient(start, con, textBox1.Text);
                this.Hide();
                klient.Show();
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
