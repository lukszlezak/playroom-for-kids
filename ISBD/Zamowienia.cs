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
    public partial class Zamowienia : Form
    {
        Pracownik prac;

        public Zamowienia(Pracownik prac)
        {
            InitializeComponent();
            this.prac = prac;
        }

        private void zamowienieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zamowienieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSBDDataSet);

        }

        private void Zamowienia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSBDDataSet.Zamowienie' table. You can move, or remove it, as needed.
            this.zamowienieTableAdapter.Fill(this.iSBDDataSet.Zamowienie);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            prac.Show();
        }
    }
}
