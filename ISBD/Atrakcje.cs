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
    public partial class Atrakcje : Form
    {
        public Atrakcje()
        {
            InitializeComponent();
        }

        private void atrakcjaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.atrakcjaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSBDDataSet);

        }

        private void Atrakcje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSBDDataSet.Atrakcja' table. You can move, or remove it, as needed.
            this.atrakcjaTableAdapter.Fill(this.iSBDDataSet.Atrakcja);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
