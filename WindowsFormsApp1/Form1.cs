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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void cARBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cARBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ayzanGroupDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayzanGroupDataSet.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.ayzanGroupDataSet.CLIENT);
            // TODO: This line of code loads data into the 'ayzanGroupDataSet.CAR' table. You can move, or remove it, as needed.
            this.cARTableAdapter.Fill(this.ayzanGroupDataSet.CAR);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
