using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void rENTALBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rENTALBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ayzanGroupDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayzanGroupDataSet.RENTAL' table. You can move, or remove it, as needed.
            this.rENTALTableAdapter.Fill(this.ayzanGroupDataSet.RENTAL);

        }
    }
}
