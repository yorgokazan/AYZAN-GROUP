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
    public partial class maintenance : Form
    {
        public maintenance()
        {
            InitializeComponent();
        }

        private void mAINTENANCEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mAINTENANCEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ayzanGroupDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayzanGroupDataSet.SERVICE_DETAIL' table. You can move, or remove it, as needed.
            this.sERVICE_DETAILTableAdapter.Fill(this.ayzanGroupDataSet.SERVICE_DETAIL);
            // TODO: This line of code loads data into the 'ayzanGroupDataSet.MAINTENANCE' table. You can move, or remove it, as needed.
            this.mAINTENANCETableAdapter.Fill(this.ayzanGroupDataSet.MAINTENANCE);

        }
    }
}
