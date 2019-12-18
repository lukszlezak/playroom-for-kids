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
    public partial class Pracownicy : Form
    {
        Pracownik prac;

        public Pracownicy(Pracownik prac)
        {
            InitializeComponent();
            this.prac = prac;
        }

        private void pracownikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pracownikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSBDDataSet);

        }

        private void Pracownicy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSBDDataSet.Pracownik' table. You can move, or remove it, as needed.
            this.pracownikTableAdapter.Fill(this.iSBDDataSet.Pracownik);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            prac.Show();
        }
    }
}
