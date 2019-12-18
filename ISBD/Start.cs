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
    public partial class Start : Form
    {
        SqlConnection con;

        public Start()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=SPLOTTLAPTOP;Initial Catalog=ISBD;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AtrPrzegl atrPrz = new AtrPrzegl(this, con);
            atrPrz.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KlientLog klientLog = new KlientLog(this, con);
            this.Hide();
            klientLog.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PracLog pracLog = new PracLog(this, con);
            this.Hide();
            pracLog.Show();
        }
    }
}
