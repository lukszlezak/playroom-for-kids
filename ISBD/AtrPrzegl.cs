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
    public partial class AtrPrzegl : Form
    {
        Start start;
        SqlConnection con;
        SqlCommand cmd;

        public AtrPrzegl(Start start, SqlConnection con)
        {
            InitializeComponent();
            this.start = start;
            this.con = con;
            con.Open();
            string str = "SELECT Atrakcja.Nazwa, Atrakcja.Cena, TypAtr.NazwaTypu AS Typ, Sale.Nazwa AS Sala, Atrakcja.Liczba " +
                         "FROM Atrakcja " +
                         "INNER JOIN Sale ON Atrakcja.IdSali = Sale.IdSali INNER JOIN TypAtr ON Atrakcja.IdTypu = TypAtr.IdTypu";
            cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource src = new BindingSource();
            src.DataSource = dr;
            dataGridView1.DataSource = src;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            start.Show();
        }
    }
}
