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
    public partial class Dzieci : Form
    {
        Pracownik prac;

        public Dzieci(Pracownik prac)
        {
            InitializeComponent();
            this.prac = prac;
        }

        private void dzieckoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dzieckoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSBDDataSet);

        }

        private void Dzieci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSBDDataSet.Dziecko' table. You can move, or remove it, as needed.
            this.dzieckoTableAdapter.Fill(this.iSBDDataSet.Dziecko);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            prac.Show();
        }
    }
}
