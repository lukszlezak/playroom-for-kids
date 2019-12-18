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
    public partial class Klienci : Form
    {
        Pracownik prac;

        public Klienci(Pracownik prac)
        {
            InitializeComponent();
            this.prac = prac;
        }

        private void klientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSBDDataSet);

        }

        private void Klienci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSBDDataSet.Klient' table. You can move, or remove it, as needed.
            this.klientTableAdapter.Fill(this.iSBDDataSet.Klient);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            prac.Show();
        }
    }
}
